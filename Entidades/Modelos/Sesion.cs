

namespace Entidades.Modelos
{
    public class Sesion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public bool Estado { get; set; }
    }
}
