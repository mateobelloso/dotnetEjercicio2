using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

//Interfaz que define el comportamiento que deben implementar los repositorios de Curso.
public interface IRepositorioCurso
{
    void AgregarCurso(Curso curso);
    void ModificarCurso(Curso curso);
    void EliminarCurso(int id);
    Curso? GetCurso(int id);
    List<Curso> GetCursos();
}