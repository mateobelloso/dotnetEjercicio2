using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para listar todos los estudiantes que hay en el repositorio que cursaron alguna materia.
public class ListarEstudiantesAntiguosUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesAntiguosUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesAntiguos();
    }
}