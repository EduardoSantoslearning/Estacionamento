using System;

decimal valorInicial = 0;
decimal valorPorHora = 0;

Console.WriteLine("Seja bem vindo ao gerenciador do estacionamento!\n Informe o valor inicial: ");
valorInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe o valor cobrado por hora: ");
valorPorHora = Convert.ToDecimal(Console.ReadLine());

GerenciadorEstacionamento es = new GerenciadorEstacionamento();
bool exibirMenu = true;

while (exibirMenu)
{
    console.Clear();
    console.WriteLine("Qual opera�ao deseja realizar:");
    console.WriteLine("1 - Cadastrar ve�culo.");
    console.WriteLine("2 - Remover ve�culo.");
    console.WriteLine("3 - Listar ve�culo.");
    console.WriteLine("4 - Sair.");

    switch (console.ReadLine())
    {
        case "1":
            es.adicionarVeiculo();
            break;

        case "2":
            es.removerVeiculo();
            break;

        case "3":
            es.listarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Op��o inv�lida!")
            break;

    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}

Console.WriteLine("O programa foi encerrado com �xito!")