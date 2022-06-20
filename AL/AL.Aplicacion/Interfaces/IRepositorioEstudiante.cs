using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

//Interfaz que define el comportamiento que deben implementar los repositorios de Estudiante.
public interface IRepositorioEstudiante
{
    void AgregarEstudiante(Estudiante estudiante);
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(int id);
    Estudiante? GetEstudiante(int id);
    Estudiante? GetEstudiantePorDni(int dni);
    List<Estudiante> GetEstudiantes();
    List<Estudiante> GetEstudiantesEstudiando();
    List<Estudiante> GetEstudiantesAntiguos(); 
}