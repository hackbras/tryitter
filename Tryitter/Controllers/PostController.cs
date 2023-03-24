using Microsoft.AspNetCore.Mvc;
using Tryitter.Models;

namespace Tryitter.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class PostController : Controller
    {
        [HttpPost]
        public void Twitar()
        {

        }
        [HttpGet]
        public IEnumerable<Post> ConsultarPosts(){
            return new List<Post>();
        }
        [HttpDelete]
        public void Delete() { 
            
        }

        [HttpPut]
        public void Atualizacao()
        {

        }
    }
}
