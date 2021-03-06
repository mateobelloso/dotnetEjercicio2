using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para agregar un curso al repositorio.
public class AgregarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public AgregarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso= rCurso;
    }

    public void Ejecutar(Curso curso)
    {
        _rCurso.AgregarCurso(curso);
    }
}