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

    }
}
