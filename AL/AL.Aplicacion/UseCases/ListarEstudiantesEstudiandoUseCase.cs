using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

// Caso de uso para listar todos los estudiantes que hay en el repositorio cursando actualmente una materia.
public class ListarEstudiantesEstudiandoUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesEstudiandoUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesEstudiando();
    }
}