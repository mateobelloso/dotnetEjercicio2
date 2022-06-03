using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerCursoUseCase
{
    private readonly IRepositorioCurso _rcurso;

    public ObtenerCursoUseCase(IRepositorioCurso rcurso)
    {
        _rcurso= rcurso;
    }

    public Curso? Ejecutar(int id)
    {
        return _rcurso.GetCurso(id);
    }
}