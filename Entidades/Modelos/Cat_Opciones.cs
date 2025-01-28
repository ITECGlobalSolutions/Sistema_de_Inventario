

namespace Entidades.Modelos
{
    public class Cat_Opciones
    {
        public int Id { get; set; }
        public int IdModulo { get; set; }
        public int IdPadre { get; set; }
        public string? Descripcion { get; set; }
        public string? Url { get; set; }
        public string? Icono { get; set; }
        public bool Estado { get; set; }
    }
}
