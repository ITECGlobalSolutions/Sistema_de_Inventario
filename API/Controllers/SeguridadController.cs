
using Microsoft.AspNetCore.Mvc;
using Entidades.Modelos;
using Logica.BL;
using Mysqlx;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguridadController : ControllerBase
    {
        private readonly PerfilBL _perfilBL;
        private readonly UsuarioBL _usuarioBL;
        private readonly ClaveUsuarioBL _claveUsuarioBL;
        private readonly ModuloBL _moduloBL;
        private readonly SesionBL _sesionBL;
        public SeguridadController()
        {
            _perfilBL = new PerfilBL();
            _moduloBL = new ModuloBL();
            _usuarioBL = new UsuarioBL();
            _claveUsuarioBL = new ClaveUsuarioBL();
            _sesionBL = new SesionBL();
        }

        [HttpGet(Name = "ListaPerfiles")]
        public List<Perfil> ListaPerfiles()
        {
            return _perfilBL.ListaPerfil().Result.ToList();
        }

        [HttpPost("{login},{clave}")]
        public async Task<ActionResult> ValidarAcceso(string login, string clave)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(clave))
            {
                var usuario = await _usuarioBL.ValidadLogin(login);
                if (usuario != null)
                {
                    var claveUser = await _claveUsuarioBL.BuscarClaveUsuario(usuario.Id);
                    if (claveUser != null)
                    {
                        if (claveUser.Clave == clave)
                        {
                            return Ok();
                        }
                        else
                        {
                            //Clave es incorrecta
                        }
                    }
                    else
                    {
                        //La clave no existe
                    }
                }
                else
                {
                    //El usuario no es valido
                }
            }
            else
            {
                //Los campos vienen vacios
            }
            return Ok();
        }

    }
}
