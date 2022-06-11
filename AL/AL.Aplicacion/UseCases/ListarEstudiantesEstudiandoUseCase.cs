using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarEstudiantesEstudiandoUseCasesUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesEstudiandoUseCasesUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesEstudiando();
    }
}