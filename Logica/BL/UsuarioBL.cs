using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class UsuarioBL : Context<Usuarios>
    {
        public async Task<Usuarios?> BuscarUsuario(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<Usuarios?> ValidadLogin(string login)
        {
            return await Task.FromResult(GET_ALL().Result.Where(x => x.Login == login && x.Estado == true).FirstOrDefault());
        }
        public async Task<IEnumerable<Usuarios>> ListaUsuario()
        {
            return await GET_ALL();
        }
        public async Task<Usuarios?> GuardarUsuario(Usuarios usuarios)
        {
            return await INSERT(usuarios);
        }
        public async Task<Usuarios?> ModificarUsuario(Usuarios usuarios)
        {
            await UPDATE(usuarios);
            return await GET_BYID(usuarios.Id);
        }
    }
}
