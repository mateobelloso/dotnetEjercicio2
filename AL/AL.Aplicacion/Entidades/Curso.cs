namespace AL.Aplicacion.Entidades;

//ENTIDAD CURSO
public class Curso
{
    public int Id { get; set; }
    public string Titulo { get; set; }="";
    public string Descripcion { get; set; }="";
    public DateTime Fecha_inicio { get; set; }
    public DateTime Fecha_finalizacion { get; set; }

    public List<Inscripcion>? Inscripciones { get; set; }

}