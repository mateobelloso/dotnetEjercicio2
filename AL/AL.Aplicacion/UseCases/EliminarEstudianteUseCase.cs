using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para eliminar un estudiante en el repositorio.
public class EliminarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public EliminarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public void Ejecutar(int id)
    {
        _rEstudiante.EliminarEstudiante(id);
    }
}