using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para listar todos las inscripciones que hay en el repositorio.
public class ListarInscripcionesUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ListarInscripcionesUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion= rInscripcion;
    }

    public List<Inscripcion> Ejecutar()
    {
        return _rInscripcion.GetInscripciones();
    }
}