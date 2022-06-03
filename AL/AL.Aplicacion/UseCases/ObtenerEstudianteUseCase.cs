using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ObtenerEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public Estudiante? Ejecutar(int id)
    {
        return _rEstudiante.GetEstudiante(id);
    }
}