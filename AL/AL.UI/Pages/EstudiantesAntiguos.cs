@page "/estudiantesAntiguos"

@inject ListarEstudiantesAntiguosUseCasesUseCase ListarEstudiantesAntiguosUseCasesUseCase
@inject NavigationManager Navegador

<h1>Estudiantes estudiando</h1>

<table class="table">
<thead>
    <tr>
        <th>ID</th>
        <th>DNI</th>
        <th>NOMBRE</th>
        <th>APELLIDO</th>
        <th>EMAIL</th>
    </tr>
</thead>

<tbody>
@if(_estudiantesEstudiando != null)
{
    @foreach (var estudiante in _estudiantesAntiguos)
    {
        <tr>                
            <td>@estudiante.Id</td>
            <td>@estudiante.Dni</td>
            <td>@estudiante.Nombre</td>
            <td>@estudiante.Apellido</td>
            <td>@estudiante.Email</td>        
        </tr>
    }
}
</tbody>
</table>




@code
{
    List<Estudiante> _estudiantesAntiguos = ListarEstudiantesAntiguosUseCase.Ejecutar();
}