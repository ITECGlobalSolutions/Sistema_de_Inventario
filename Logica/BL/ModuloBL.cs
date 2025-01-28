using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class ModuloBL : Context<Modulo>
    {
        public async Task<Modulo?> BuscarModulo(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Modulo>> ListaModulo()
        {
            return await GET_ALL();
        }
        public async Task<Modulo?> GuardarModulo(Modulo modulo)
        {
            return await INSERT(modulo);
        }
        public async Task<Modulo?> ModificarModulo(Modulo modulo)
        {
            await UPDATE(modulo);
            return await GET_BYID(modulo.Id);
        }
    }
}
