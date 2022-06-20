namespace AL.Aplicacion.Entidades;

//ENTIDAD ESTUDIANTE
public class Estudiante
{
    public int Id { get; set; }
    public int Dni { get; set; }
    public string Nombre { get; set; }="";
    public string Apellido { get; set; }="";
    public string Email { get; set; }="";

    public List<Inscripcion>? Inscripciones { get; set; }
}