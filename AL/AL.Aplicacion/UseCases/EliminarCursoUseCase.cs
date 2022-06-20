using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para eliminar un curso en el repositorio.
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