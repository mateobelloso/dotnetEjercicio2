namespace AL.Aplicacion.Entidades;

public class Curso
{
    public int id { get; set; }
    public string titulo { get; set; }="";
    public string descripcion { get; set; }="";
    public DateTime fecha_inicio { get; set; }
    public DateTime fecha_finalizacion { get; set; }
}