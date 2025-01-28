using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class PerfilOpcionesBL : Context<PerfilOpciones>
    {
        public async Task<PerfilOpciones?> BuscarPerfilOpcion(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<PerfilOpciones>> ListaPerfilOpcion()
        {
            return await GET_ALL();
        }
        public async Task<PerfilOpciones?> GuardarPerfilOpcion(PerfilOpciones perfilOpciones)
        {
            return await INSERT(perfilOpciones);
        }
        public async Task<PerfilOpciones?> ModificarPerfilOpcion(PerfilOpciones perfilOpciones)
        {
            await UPDATE(perfilOpciones);
            return await GET_BYID(perfilOpciones.Id);
        }
    }
}
