using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioInscripcion
{
    void AgregarInscripcion(Inscripcion inscripcion);
    void ModificarInscripcion(Inscripcion inscripcion);
    void EliminarInscripcion(int id);
    Inscripcion? GetInscripcion(int id);
    List<Inscripcion> GetInscripciones();
}