using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class MovimientoAlmacenBL : Context<MovimientoAlmacen>
    {
        public async Task<MovimientoAlmacen?> BuscarMovimiento(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<MovimientoAlmacen>> ListaMovimiento()
        {
            return await GET_ALL();
        }
        public async Task<MovimientoAlmacen?> GuardarMovimiento(MovimientoAlmacen almacen)
        {
            return await INSERT(almacen);
        }
        public async Task<MovimientoAlmacen?> ModificarMovimiento(MovimientoAlmacen almacen)
        {
            await UPDATE(almacen);
            return await GET_BYID(almacen.Id);
        }
    }
}
