using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarEstudiantesAntiguosUseCasesUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesAntiguosUseCasesUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesAntiguos();
    }
}