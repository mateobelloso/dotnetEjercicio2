using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para modificar una inscripcion en el repositorio.
public class ModificarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ModificarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion= rInscripcion;
    }

    public void Ejecutar(Inscripcion inscripcion)
    {
        _rInscripcion.ModificarInscripcion(inscripcion);
    }
}