using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;

namespace AL.Repositorios;

//Clase que representa la base de datos de institucion educativa
public class InstitucionEducativaContext : DbContext
{
    #nullable disable
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable enable

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=InstitucionEducativa.sqlite");
    }
}