using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using Tercer_examen_LP3.Data;
using Tercer_examen_LP3.Interfaces;

namespace Tercer_examen_LP3.Servicios;

public class UsuarioServicio : IUsuarioServicio
{

    private readonly MySQLConfiguration _configuration;
    private IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(MySQLConfiguration configuration)
    {


        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }


    public async Task<bool> Actualizar(Usuario usuario)
    {
        return await usuarioRepositorio.Actualizar(usuario);
    }

    public async Task<bool> Eliminar(Usuario usuario)
    {
        return await usuarioRepositorio.Eliminar(usuario);
    }

    public async Task<IEnumerable<Usuario>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public async Task<Usuario> GetPorCodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorCodigo(codigo);
    }

    public async Task<bool> Nuevo(Usuario usuario)
    {
        return await usuarioRepositorio.Nuevo(usuario);
    }



    //----------------NO BORRAR--------------------
    //public Task<bool> Actualizar(Usuario usuario)
    //{
    //    throw new NotImplementedException();
    //}


    //public Task<bool> Eliminar(Usuario usuario)
    //{
    // throw new NotImplementedException();
    //}

    //public Task<IEnumerable<Usuario>> GetLista()
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<Usuario> GetPorCodigo(string codigo)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<bool> Nuevo(Usuario usuario)
    //{
    //    throw new NotImplementedException();
    //}
}
