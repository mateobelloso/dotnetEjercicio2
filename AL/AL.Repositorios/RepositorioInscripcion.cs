using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

//Clase repositorio que implementa la interfaz de repositorio de inscripcion.
public class RepositorioInscripcion : IRepositorioInscripcion
{
    //Agrega una inscripcion a la base de datos
    public void AgregarInscripcion(Inscripcion inscripcion)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Add(inscripcion);
            context.SaveChanges();
        }
    }

    //Elimina la inscripcion con id igual al pasado como parametro en caso de existir.
    public void EliminarInscripcion(int id)
    {
        var inscripcionBorrar= GetInscripcion(id);
        using(var context = new InstitucionEducativaContext())
        {
            if(inscripcionBorrar != null)
            {
                context.Remove(inscripcionBorrar);
                context.SaveChanges();
            }
        }
    }

    //Devuelve la inscripcion con el id pasado como parametro, caso de no existir la inscripcion devuelve null.
    public Inscripcion? GetInscripcion(int id)
    {
        using(var context = new InstitucionEducativaContext())
        {
            var inscripcion = context.Inscripciones.Where(i => i.Id == id).Include(i => i.Curso).Include(i => i.Estudiante).SingleOrDefault();
            return inscripcion;
        }
    }

    //Devuelve un listado de todos las inscripciones que se encuentran en la base de datos.
    public List<Inscripcion> GetInscripciones()
    {
        using(var context = new InstitucionEducativaContext())
        {
            List<Inscripcion> listaInscripciones= context.Inscripciones.Include(i => i.Curso).Include(i => i.Estudiante).ToList();
            return listaInscripciones;
        }
    }

    ////Modifica la inscripcion pasada como parametro
    public void ModificarInscripcion(Inscripcion inscripcion)
    {
        using(var context = new InstitucionEducativaContext())
        {
            //context.Update(inscripcion);
            context.Entry(inscripcion).State= EntityState.Modified;
            context.SaveChanges();
        }
    }
}