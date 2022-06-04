using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

public class RepositorioInscripcion : IRepositorioInscripcion
{
    public void AgregarInscripcion(Inscripcion inscripcion)
    {
        throw new NotImplementedException();
    }

    public void EliminarInscripcion(int estudiante_id, int curso_id)
    {
        throw new NotImplementedException();
    }

    public Inscripcion? GetInscripcion(int estudiante_id, int curso_id)
    {
        throw new NotImplementedException();
    }

    public List<Inscripcion> GetInscripciones()
    {
        throw new NotImplementedException();
    }

    public void ModificarInscripcion(Inscripcion inscripcion)
    {
        throw new NotImplementedException();
    }
}