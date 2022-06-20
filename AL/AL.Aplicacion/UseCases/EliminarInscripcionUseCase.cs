using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para eliminar una inscripcion en el repositorio.
public class EliminarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public EliminarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion= rInscripcion;
    }

    public void Ejecutar(int id)
    {
        _rInscripcion.EliminarInscripcion(id);
    }
}