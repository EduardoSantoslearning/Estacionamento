using System;

decimal valorInicial = 0;
decimal valorPorHora = 0;

Console.WriteLine("Seja bem vindo ao gerenciador do estacionamento!\n Informe o valor inicial: ");
valorInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe o valor cobrado por hora: ");
valorPorHora = Convert.ToDecimal(Console.ReadLine());

GerenciadorEstacionamento es = new GerenciadorEstacionamento(valorInicial, valorPorHora);
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Qual operaçao deseja realizar:");
    Console.WriteLine("1 - Cadastrar veículo.");
    Console.WriteLine("2 - Remover veículo.");
    Console.WriteLine("3 - Listar veículo.");
    Console.WriteLine("4 - Sair.");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;

    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}

Console.WriteLine("O programa foi encerrado com êxito!");