using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class ProductosBL:Context<Cat_Productos>
    {
        public async Task<Cat_Productos?> BuscarProducto(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Cat_Productos>> ListaProducto()
        {
            return await GET_ALL();
        }
        public async Task<Cat_Productos?> GuardarProducto(Cat_Productos cat_Productos)
        {
            return await INSERT(cat_Productos);
        }
        public async Task<Cat_Productos?> ModificarProducto(Cat_Productos cat_Productos)
        {
            await UPDATE(cat_Productos);
            return await GET_BYID(cat_Productos.Id);
        }
    }
}
