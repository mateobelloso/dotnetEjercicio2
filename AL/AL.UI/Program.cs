using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AL.UI.Data;

//USING DE LAS DEMAS CARPETAS
using AL.Aplicacion.UseCases;
using AL.Aplicacion.Interfaces;
using AL.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//SE AGREGAN LOS SERVICIOS DE LOS CONTENEDORES DE INTERFACES
//CASOS DE USO DE LOS CURSOS
builder.Services.AddTransient<AgregarCursoUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ObtenerCursoUseCase>();
builder.Services.AddTransient<EliminarCursoUseCase>();
builder.Services.AddTransient<ListarCursosUseCase>();
//CASOS DE USO DE LOS ESTUDIANTES
builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ObtenerEstudianteUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudiantesUseCase>();
//CASOS DE USO DE LAS INSCRIPCIONES
builder.Services.AddTransient<AgregarInscripcionUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddTransient<ObtenerInscripcionUseCase>();
builder.Services.AddTransient<EliminarInscripcionUseCase>();
builder.Services.AddTransient<ListarInscripcionesUseCase>();
//CASOS ESPECIALES
builder.Services.AddTransient<ListarEstudiantesEstudiandoUseCase>();
builder.Services.AddTransient<ListarEstudiantesAntiguosUseCase>();
//CONFIGURA LOS REPOSITORIOS CON SUS INTERFACES
builder.Services.AddScoped<IRepositorioCurso,RepositorioCurso>();
builder.Services.AddScoped<IRepositorioEstudiante,RepositorioEstudiante>();
builder.Services.AddScoped<IRepositorioInscripcion,RepositorioInscripcion>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
