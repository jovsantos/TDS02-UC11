using UtilitariosApp;

// == Testes com Clientes e Endereço ==

var gerenciador = new GerenciadorClientes(); // instancia o gerenciador

var endereco1 = new Endereco("Rua B", 123, "São Paulo", "SP");
var endereco2 = new Endereco("Travessa X", 544, "São Paulo", "SP");

var cliente1 = new Cliente(1, "Silva", "jsilva@mail.com", endereco1);
var cliente2 = new Cliente(2, "Marcio", "marcio@mail.com", endereco2);
var cliente3 = new Cliente(3, "Luana", "luana@mail.com", endereco2);


gerenciador.AdicionarCliente(cliente1);
gerenciador.AdicionarCliente(cliente2);
gerenciador.AdicionarCliente(cliente3);

gerenciador.RemoverPorId(1);

Console.WriteLine($"Total de Clientes: {gerenciador.ContarClientes()}");

Console.WriteLine($"Procurando cliente ID 2: {gerenciador.ProcurarPorId(3)?.Nome}");

Console.WriteLine();

Console.WriteLine(cliente1.ObterInformacoes());

Console.WriteLine(gerenciador.ProcurarPorId(1)?.ObterInformacoes());

