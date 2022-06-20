using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para obtener un curso del repositorio.
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