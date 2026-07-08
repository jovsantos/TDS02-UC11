using ProjetoSimples.API.Models;
using ProjetoSimples.API.Services;

namespace ProjetoSimples.Tests.Services
{
    public class ProdutoServiceTests
    {

        [Fact]
        public void Adicionar_Produto_Deve_Retornar_Produto_Com_Id()
        {
            // Arrange
            var service = new ProdutoService();
            var produto = new Produto
            {
                Nome = "Controle PS5",
                Preco = 150.00m
            };
            // Act
            var resultado = service.Adicionar(produto);
            // Assert
            Assert.True(resultado.Id > 0);
            Assert.Equal("Controle PS5", resultado.Nome);
            Assert.Single(service.ObterTodos());
        }

        [Fact]
        public void ObterPorId_DeveRetornarNulo_QuandoProdutoNaoExistir()
        {
            // Arrange
            var service = new ProdutoService();
            // Act
            var resultado = service.ObterPorId(999);
            // Assert
            Assert.Null(resultado);
        }
    }
}
