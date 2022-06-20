using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para modificar un curso en el repositorio.
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