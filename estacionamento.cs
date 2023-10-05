using system;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorEstacionamento
{
	private decimal valorInicial = 0;
	private decimal valorPorHora = 0;
	private List<string> veiculos = new List<string>();

	public Estacionamento(decimal valorIncial, decimal valorPorHora)
	{
		this.valorInicial = valorIncial;
		this.valorPorHora = valorPorHora;
    }


	public void AdicionarVeiculo()
	{
		Console.WriteLine("Informe a placa do ve�culo que deseja adicionar: ");
		string placa = Console.ReadLine();
		veiculos.Add(placa);

		Console.WriteLine("Veiculo adicionado!");
	}


	public void RemoverVeiculo()
	{
        Console.WriteLine("Informe a placa do ve�culo que deseja remover: ");
        string placa = Console.ReadLine();
        if (veiculos.Any(x=> x.ToUpper() == placa.ToUpper()))
        {
			int tempoPermanecido = 0;
			decimal valorTotal = 0;

            Console.WriteLine("Informe a quantidade de horas que o ve�culo parmaneceu estacionado: ");
            tempoPermanecido = Int.Parse(Console.ReadLine());

			valorTotal = valorInicial + (this.valorPorHora * tempoPermanecido);

			veiculos.Remove(placa);

            Console.WriteLine($"O ve�culo placa {placa} foi removido e o pre�o total foi de: R$ {valorTotal}");
        }
		else
		{
			Console.WriteLine("Este ve�culo n�o se encontra estacionado. Verifique se a placa foi digitada corretamente.")
		}


        Console.WriteLine("Veiculo removido!");
	}


	public void ListarVeiculos()
	{
		if (veiculos.Any())
		{
			Console.WriteLine("Os ve�culos estacionados s�o:");
			foreach(string element in veiculos)
			{
				Console.WriteLine($"{element}");
            }

        }
		else
		{
            Console.WriteLine("N�o h� ve�culos no estacionamento.")
        }
        Console.WriteLine("Veiculos Listados!");
	}

}