using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioEstudiante
{
    void AgregarEstudiante(Estudiante estudiante);
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(int id);
    Estudiante? GetEstudiante(int id);
    List<Estudiante> GetEstudiantes();
}