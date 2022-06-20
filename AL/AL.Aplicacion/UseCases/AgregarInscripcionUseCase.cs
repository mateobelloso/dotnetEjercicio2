using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para agregar una inscripcion al repositorio.
public class AgregarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    private readonly IRepositorioCurso _rCurso; 
    // usamos esta interfaz para poder evitar agregar una inscripcion al mismo curso para el mismo estudiante

    public AgregarInscripcionUseCase(IRepositorioInscripcion rInscripcion, IRepositorioCurso rCurso)
    {
        _rInscripcion= rInscripcion;
        _rCurso= rCurso;
    }

    public void Ejecutar(Inscripcion inscripcion)
    {
        Curso? curso= _rCurso.GetCurso(inscripcion.CursoId);
        Inscripcion? inscripcion_existente= curso?.Inscripciones?.Where(i => i.EstudianteId == inscripcion.EstudianteId).SingleOrDefault();
        if(inscripcion_existente == null)
        {
            _rInscripcion.AgregarInscripcion(inscripcion);
        }else
        {
            throw new Exception("Ese estudiante ya está inscripto en esa materia");
        }
    }
}