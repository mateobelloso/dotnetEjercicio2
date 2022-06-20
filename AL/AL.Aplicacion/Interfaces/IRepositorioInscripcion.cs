using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

//Interfaz que define el comportamiento que deben implementar los repositorios de Inscripcion.
public interface IRepositorioInscripcion
{
    void AgregarInscripcion(Inscripcion inscripcion);
    void ModificarInscripcion(Inscripcion inscripcion);
    void EliminarInscripcion(int id);
    Inscripcion? GetInscripcion(int id);
    List<Inscripcion> GetInscripciones();
}