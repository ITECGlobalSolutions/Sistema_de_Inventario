
namespace Entidades.Modelos
{
    public class MovimientoAlmacen
    {
        public int Id { get; set; }
        public int IdAlmacen { get; set; }
        public int IdProducto { get; set; }
        public int UnidadesEntrantes { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal CostoPromedio { get; set; }
        public int UnidadesSalida { get; set; }
        public int Stock { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
