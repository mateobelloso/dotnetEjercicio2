namespace AL.Aplicacion.Entidades;

//ENTIDAD INSCRIPCION
public class Inscripcion
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    public int CursoId { get; set; }
    public DateTime Fecha_inscripcion { get; set; }
    public Estudiante? Estudiante { get; set; }
    public Curso? Curso { get; set; }
}