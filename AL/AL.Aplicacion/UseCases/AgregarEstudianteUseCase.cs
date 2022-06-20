using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para agregar un estudiante al repositorio.
public class AgregarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public AgregarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante)
    {
        if(_rEstudiante.GetEstudiantePorDni(estudiante.Dni) == null)
        {
            _rEstudiante.AgregarEstudiante(estudiante);
        }else
        {
            throw new Exception("Ya existe un estudiante con ese DNI");
        }
    }
}