namespace UtilitariosApp.Tests
{
    public class GerenciadorClientesTests
    {

        [Fact]
        public void AdicionarCliente_AoAdicionarCliente_DeveAumentarQuantidade()
        {
            // Arrange
            var gerenciadorClientes= new GerenciadorClientes();
            var endereco = new Endereco("Rua B", 123, "São Paulo", "SP");
            var cliente = new Cliente(2, "Marcio", "marcio@mail.com", endereco);

            // Act
            gerenciadorClientes.AdicionarCliente(cliente);

            // Assert

            Assert.Equal(1, gerenciadorClientes.ContarClientes());
        }

        [Fact]

        public void AdicionarCliente_ComClienteNulo_DeveLancarArgumentNullException()

        {
            var gerenciador =new GerenciadorClientes();

            Assert.Throws<ArgumentNullException>(() => gerenciador.AdicionarCliente(null));
        }

        [Fact]

        public void AdicionarCliente_VariosClientesValidos_DeveAdicionarTodos()
        {
            var gerenciador = new GerenciadorClientes();


        }

        [Fact]

        public void ProcurarPorId_ComIdExistente_DeveRetornarCliente()
        {
            var gerenciadorClientes = new GerenciadorClientes();

            var clienteEncontrado = gerenciadorClientes.ProcurarPorId(2);

            Assert.Null(clienteEncontrado);
        }
    }
}
