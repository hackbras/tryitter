using Microsoft.AspNetCore.Mvc;
using Tryitter.Models;

namespace Tryitter.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        List<Usuario> Usuarios = new List<Usuario>();
        [HttpGet(Name = "Usuario")]
        public IEnumerable<Usuario> Get()
        {
            Usuarios.Add(new Usuario { Email = "email1", Password = "pass1" });
            Usuarios.Add(new Usuario { Email = "email2", Password = "pass1" });
            Usuarios.Add(new Usuario { Email = "email3", Password = "pass1" });
            
            return Usuarios;
        }

  


    }
}
