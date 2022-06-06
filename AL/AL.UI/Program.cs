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
builder.Services.AddTransient<AgregarCursoUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ObtenerCursoUseCase>();
builder.Services.AddTransient<EliminarCursoUseCase>();
builder.Services.AddTransient<ListarCursosUseCase>();
builder.Services.AddScoped<IRepositorioCurso,RepositorioCurso>();



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
