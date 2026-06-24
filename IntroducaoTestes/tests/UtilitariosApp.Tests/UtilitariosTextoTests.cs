using UtilitariosApp;

namespace UltilitariosApp.Teste

{

    public class UltilitariosTextoTests

    {

        [Theory] // valide todos os casos de borda (edges cases)
        [InlineData("dotnet", 2, 10, true)]
        [InlineData("dotnet", 8, 10, false)]
        [InlineData("Cequela", 3, 3, false)]
        [InlineData("Curupira", 1, 5, false)]
        [InlineData("", 1, 10, false)]
        [InlineData("Catimguele", 1, 100000, true)]
        [InlineData("", 0, 10, true)]
        [InlineData(null, 0, 10, false)]

        public void ValidarTamanho_DeveRetornarTotalDePalavras(string texto, int min, int max, bool resultado)
        {
            var utilitario = new UtilitariosTexto();

            bool validacao = utilitario.ValidarTamanho(texto, min, max);

            Assert.Equal(resultado, validacao);

        }


        [Theory]
        [InlineData("Cachorro Manco", 2)]
        [InlineData("C# é muito bom", 4)]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void ContadorDePalavras_DeveRetornarTotalDePalavras(string texto, int resultadoEsperado)
        {
            // Arrange
            var utilitario = new UtilitariosTexto();

            // Act
            int contador = utilitario.ContadorDePalavras(texto);

            // Assert
            Assert.Equal(resultadoEsperado, contador);
        }


    }

}

