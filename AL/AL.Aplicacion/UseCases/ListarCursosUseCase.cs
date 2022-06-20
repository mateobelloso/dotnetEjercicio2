using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para listar todos los cursos que hay en el repositorio.
public class ListarCursosUseCase
{
    private readonly IRepositorioCurso _rcurso;

    public ListarCursosUseCase(IRepositorioCurso rcurso)
    {
        _rcurso= rcurso;
    }

    public List<Curso> Ejecutar()
    {
        return _rcurso.GetCursos();
    }
}