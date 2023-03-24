using ClassLibraryTryitter;
using Tryitter.Services;
using Tryitter.Data;
using Moq;
using Moq.AutoMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tryitter.Models;

namespace Tryitter.Test
{
    [TestClass]
    public class UnitTestTryitter
    {
       
        [TestMethod]
        public void TesteGet_CadastroUsuario()
        {
            var objeto = new Tryitter.Controllers.UsuarioController();
            objeto.Get();

            Assert.IsInstanceOfType(objeto, typeof(Usuario));         
        }

        [TestMethod]
        public void TesteAtualizacao_Postagem()
        {
            var objeto = new Tryitter.Controllers;
            //objeto.Twitte = "";            

            //Assert.IsNotNull(objeto);
        }
        [TestMethod]
        public void TesteGet_Postagem()
        {
            //var objeto = new Tryitter.Models.Post();
            //Assert.IsNotNull(objeto);
        }

        [TestMethod]
        public void Delete()
        {
            var objeto = new Tryitter.Controllers.PostController();
            objeto.Delete();

        }
    }
}