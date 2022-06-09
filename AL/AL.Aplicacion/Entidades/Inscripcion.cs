namespace AL.Aplicacion.Entidades;

public class Inscripcion
{
    public int Id { get; set; }
    public Estudiante? Estudiante { get; set; }
    public Curso? Curso { get; set; }
    //public int Estudiante_id { get; set; }
    //public int Curso_id { get; set; }
    public DateTime Fecha_inscripcion { get; set; }
    
}