using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

//Clase repositorio que implementa la interfaz de repositorio de estudiante.
public class RepositorioEstudiante : IRepositorioEstudiante
{
    //Agrega un estudiante a la base de datos
    public void AgregarEstudiante(Estudiante estudiante)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Add(estudiante);
            context.SaveChanges();
        }
    }

    //Elimina el estudiante con id igual al pasado como parametro en caso de existir.
    public void EliminarEstudiante(int id)
    {
        var estudianteBorrar= GetEstudiante(id);
        using(var context = new InstitucionEducativaContext())
        {
            if(estudianteBorrar != null)
            {
                context.Remove(estudianteBorrar);
                context.SaveChanges();
            }
        }
    }

    //Devuelve el estudiante con el id pasado como parametro, caso de no existir el estudiante devuelve null.
    public Estudiante? GetEstudiante(int id)
    {
        using(var context = new InstitucionEducativaContext())
        {
            var estudiante= context.Estudiantes.Where(e => e.Id == id).Include(e => e.Inscripciones).ThenInclude(i => i.Curso).SingleOrDefault();
            return estudiante;
        }
    }

    //Modifica el estudiante pasado como parametro
    public void ModificarEstudiante(Estudiante estudiante)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Update(estudiante);
            context.SaveChanges();
        }
    }

    //Devuelve un listado de todos los estudiantes que se encuentran en la base de datos con sus inscripciones matcheadas.
    public List<Estudiante> GetEstudiantes()
    {
        using(var context = new InstitucionEducativaContext())
        {
            return context.Estudiantes.Include(e => e.Inscripciones).ToList();
        }
    }

    //Devuelve un listado de todos los estudiantes que se encuentran en la base de datos que actualmente estan cursando alguna materia.
    public List<Estudiante> GetEstudiantesEstudiando()
    {
        using(var context = new InstitucionEducativaContext())
        {
            // no se como hacer la consulta.
            List<Estudiante> estudiantesEstudiando= new List<Estudiante>();
            List<Curso> cursosActivos= context.Cursos.Include(c => c.Inscripciones)
                .ThenInclude(i => i.Estudiante)
                .Where(cur => cur.Fecha_inicio < DateTime.Now && cur.Fecha_finalizacion > DateTime.Now)
                .ToList();
            cursosActivos.ForEach(c => c.Inscripciones.ForEach(i => estudiantesEstudiando.Add(new Estudiante(){ Nombre=i.Estudiante.Nombre, Apellido=i.Estudiante.Apellido, Inscripciones= new List<Inscripcion>(){i}})));
            return estudiantesEstudiando;      
        }
    }

    //Devuelve un listado de todos los estudiantes que se encuentran en la base de datos que hayan cursado alguna materia.
    public List<Estudiante> GetEstudiantesAntiguos()
    {
        using(var context = new InstitucionEducativaContext())
        {
            List<Curso> cursosTerminados= context.Cursos.Include(c => c.Inscripciones)
                .ThenInclude(i => i.Estudiante)
                .Where(cur => cur.Fecha_finalizacion < DateTime.Now)
                .ToList();

            List<Estudiante> estudiantesAntiguos= new List<Estudiante>();
            cursosTerminados.ForEach(c => c.Inscripciones.ForEach(i => estudiantesAntiguos.Add(new Estudiante(){ Nombre=i.Estudiante.Nombre, Apellido=i.Estudiante.Apellido, Inscripciones= new List<Inscripcion>(){i}})));
            return estudiantesAntiguos;           
        }
    }

    //Devuelve el estudiante que tenga el dni igual al pasado como parametro, caso de no existir retorna null.
    public Estudiante? GetEstudiantePorDni(int dni)
    {
        using(var context= new InstitucionEducativaContext())
        {
            return context.Estudiantes.Where(e => e.Dni == dni).SingleOrDefault();
        }
    }
}