
using Microsoft.AspNetCore.Components;
using Modelos;
using Tercer_examen_LP3.Interfaces;

namespace Tercer_examen_LP3.Pages.Usuarios;

partial class Usuarios
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    private IEnumerable<Usuario> usuariosLista { get; set; }

    protected override async Task OnInitializedAsync()
    {
        usuariosLista = await _usuarioServicio.GetLista();
    }
}
