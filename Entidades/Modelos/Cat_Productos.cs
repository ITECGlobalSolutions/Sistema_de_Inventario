

namespace Entidades.Modelos
{
    public class Cat_Productos
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
        public bool Estado { get; set; }
    }

}
