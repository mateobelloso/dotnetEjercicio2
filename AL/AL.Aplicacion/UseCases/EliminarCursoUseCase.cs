using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class EliminarCursoUseCase
{
    private readonly IRepositorioCurso _rcurso;

    public EliminarCursoUseCase(IRepositorioCurso rcurso)
    {
        _rcurso= rcurso;
    }

    public void Ejecutar(int id)
    {
        _rcurso.EliminarCurso(id);
    }
}