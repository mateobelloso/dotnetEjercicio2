using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para listar todos los estudiantes que hay en el repositorio.
public class ListarEstudiantesUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantes();
    }
}