using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

//Clase repositorio que implementa la interfaz de repositorio de curso.
public class RepositorioCurso : IRepositorioCurso
{
    //Agrega un curso a la base de datos
    public void AgregarCurso(Curso curso)
    {
        //Si la base de datos no existe la crea y agrega un curso a la base de datos
        using(var context = new InstitucionEducativaContext())
        {
            context.Database.EnsureCreated();
            context.Add(curso);
            context.SaveChanges();
        }
    }

    //Elimina el curso con id igual al pasado como parametro en caso de existir.
    public void EliminarCurso(int id)
    {
        var cursoBorrar= GetCurso(id);
        using(var context = new InstitucionEducativaContext())
        {
            if(cursoBorrar != null)
            {
                context.Remove(cursoBorrar);
                context.SaveChanges();
            }
        }
    }

    //Devuelve el curso con el id pasado como parametro, caso de no existir el curso devuelve null.
    public Curso? GetCurso(int id)
    {
        using(var context= new InstitucionEducativaContext())
        {
            var curso= context.Cursos.Where(c => c.Id == id).Include(c => c.Inscripciones).ThenInclude(i => i.Estudiante).SingleOrDefault();
            return curso;
        }
    }

    //Devuelve un listado de todos los cursos que se encuentran en la base de datos con sus inscripciones matcheadas.
    public List<Curso> GetCursos()
    {
        using(var context= new InstitucionEducativaContext())
        {
            var listaCursos= context.Cursos.Include(c => c.Inscripciones).ToList();
            return listaCursos;
        }
    }

    //Modifica el curso pasado como parametro
    public void ModificarCurso(Curso curso)
    {
        using(var context= new InstitucionEducativaContext())
        {
            context.Cursos.Update(curso);
            context.SaveChanges();
        }
    }
}