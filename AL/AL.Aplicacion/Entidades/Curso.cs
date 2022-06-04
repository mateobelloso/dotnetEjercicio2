namespace AL.Aplicacion.Entidades;

public class Curso
{
    public int Id { get; set; }
    public string Titulo { get; set; }="";
    public string Descripcion { get; set; }="";
    public DateTime Fecha_inicio { get; set; }
    public DateTime Fecha_finalizacion { get; set; }

    public List<Inscripcion>? Inscripciones { get; set; }

    /*public Curso(string titulo,string descripcion,DateTime fecha_inicio,DateTime fecha_fin)
    {
        Titulo= titulo;
        Descripcion= descripcion;
        Fecha_inicio= fecha_inicio;
        Fecha_finalizacion= Fecha_finalizacion;
    }*/
}