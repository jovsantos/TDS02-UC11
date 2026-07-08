using Microsoft.AspNetCore.Mvc;
using Moq;
using ProjetoSimples.API.Controllers;
using ProjetoSimples.API.Models;
using ProjetoSimples.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSimples.Tests.Controllers
{
    public class ProdutoControllerTests
    {

        [Fact]
        public void GetById_DeveRetornarOk_QuandoProdutoExistir()
        {
            // Arrange
            var mockService = new Mock<IProdutoService>();

            mockService.Setup(s => s.ObterPorId(40))
                .Returns(new Produto {Nome = "Mouse USB", Preco = 150.0m });

            var controller = new ProdutosController(mockService.Object);
            // Act
            var result = controller.GetById(40);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            var produto = ((OkObjectResult)result).Value as Produto;
            Assert.NotNull(produto);
            Assert.Equal("Mouse USB", produto.Nome);
            Assert.Equal(150.0m, produto.Preco);
        }
    }
}
