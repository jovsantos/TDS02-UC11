using UtilitariosApp;

namespace UtilitariosApp.Tests
{
    public class CalculadoraTests
    {
        [Fact] // Indica que este método é um teste
        public void Somar_DeveRetornarASomaCorreta()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Somar(5, 7);
            var resultadoZerado = calculadora.Somar(0, 0); // Teste para verificar a soma de zero, serve para garantir que a função lida corretamente com casos de borda

            Assert.Equal(12, resultado);
            Assert.Equal(0, resultadoZerado); // Verifica se a soma de zero é igual a zero
        }

        [Fact]
        public void Multiplicar_DeveRetornarAMultiplicacaoCorreta()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Multiplicar(3, 3); // 3 * 3 = 9

            Assert.Equal(9, resultado); // Verifica se o resultado é igual a 9

        }

        [Fact]
        public void Dividir_DeveRetornaroResultadoInteiroDaDivisaoArredondadoParaCima()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Divisao(5, 2); // 5 / 2 = 2.5, porem , como o método deve retornar um inteiro arredondado para cima, o resultado esperado é 3

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Dividir_AoDividirPorZero_DeveRetornarODividendo()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Divisao(5, 0); // 5 / 0 = indefinido

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarASubtracao()
        {
            Calculadora c1 = new Calculadora();
            var resultado = c1.SubtrairPositivoOuZero(6, 2); // 6 - 2 = 4, resultado esperado é 4

            Assert.Equal(4, resultado);

        }

        [Fact]

        public void Subtrair_AoSubtrairValorMaiorDeMenor_ResultadoEZero()
        {
            Calculadora c1 = new Calculadora();

            var resultado = c1.SubtrairPositivoOuZero(2, 6); // 2 - 6 = -4, resultado esperado é zero, pois o método deve retornar zero ou um valor positivo
            Assert.Equal(0, resultado);
        }

        [Theory]
        [InlineData(10, 3, 1000)]
        [InlineData(10, 2, 100)]                                                                                                                                                                                         
        [InlineData(5, 2, 25)]
        [InlineData(5, 3, 125)]
        [InlineData(2, 5, 32)]
        [InlineData(2, -2, 0.25)]
        [InlineData(2, 0, 1)]
        [InlineData(-32, 0, 1)]
        [InlineData(15, 1, 15)]
        [InlineData(-15, 1, -15)]

        public void PotenciaDeUmNumero_DeveRetornarAPotencia(int a, int b, double pot)
        {
            Calculadora c1 = new Calculadora();
            var resultado = c1.PotenciaDeUmNumero(a, b);

            Assert.Equal(pot, resultado);
        }


        [Theory]
        [InlineData(9, 3)]
        [InlineData(16, 4)]
        [InlineData(25, 5)]

        public void Raiz_DeveRetornarOResultadoCorreto(int numero, double resultado)
        {

            var c1 = new Calculadora();
            double raizCalculada = c1.Raiz(numero);

            Assert.Equal(resultado, raizCalculada);

        }

        [Fact]
        public void Raiz_DeUmNumeroNegativo_DeveLancarArgumentException()
        {
            //Arrange
            var c1 = new Calculadora();
            int numero = -4;
            //Act & Assert
            Assert.Throws<ArgumentException>(() => c1.Raiz(numero));

        }

    }
}