using AL.Aplicacion.Entidades;

using AL.Aplicacion.Interfaces;

public interface IRepositorioInscripcion
{
    void AgregarInscripcion(Inscripcion inscripcion);
    void ModificarInscripcion(Inscripcion inscripcion);
    void EliminarInscripcion(int estudiante_id, int curso_id);
    Inscripcion? GetInscripcion(int estudiante_id, int curso_id);
    List<Inscripcion> GetInscripciones();
}