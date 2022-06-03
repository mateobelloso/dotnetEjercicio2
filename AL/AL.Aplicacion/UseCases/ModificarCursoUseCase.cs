using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ModificarCursoUseCase
{
    private readonly IRepositorioCurso _rcurso;

    public ModificarCursoUseCase(IRepositorioCurso rcurso)
    {
        _rcurso= rcurso;
    }

    public void Ejecutar(Curso curso)
    {
        _rcurso.ModificarCurso(curso);
    }
}