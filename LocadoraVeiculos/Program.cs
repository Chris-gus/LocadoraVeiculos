using System;
using Internal;
namespace LocadoraVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Veiculo> veiculos = new List<Veiculo>();
           EscolhaOperacao(veiculos);
        }

        static void EscolhaOperacao(List<Veiculo> veiculos)
        {
            Console.Clear();
            Console.WriteLine("Escolha o que você deseja fazer:");
            Console.WriteLine("1- Cadastrar novo veículo.");
            if(veiculos.Count > 0) Console.WriteLine("2- Exibir veículos");
            Console.WriteLine("0- Sair");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                case 1:
                    InserirInf(veiculos);
                    break;

                case 2:
                    if(veiculos.Count > 0) 
                    ExibirVeiculos(veiculos);
                    break;

                default:
                    throw new Exception("Insira um valor válido");

            }


        }
        
        static void InserirInf(List<Veiculo> veiculos)
        {
            Console.Clear();
            Console.WriteLine("Insira o modelo do veículo: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Insira a marca do veículo: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Insira o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor base diário de aluguel desse veículo?");
            double baseDiarioAluguel = double.Parse(Console.ReadLine());

            Console.WriteLine("Por quantos dias esse veículo será alugado?");
            int dias = int.Parse(Console.ReadLine());

            Veiculo v = new Veiculo(modelo,marca,ano,baseDiarioAluguel);

            EscolhaTipo(v,veiculos);
        }
        static void EscolhaTipo(Veiculo v, List<Veiculo> veiculos)
        {
            Console.WriteLine("Que tipo de veículo você deseja? ");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Caminhão");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Veiculo cr = new Carro(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    veiculos.Add(cr);
                    EscolhaOperacao(veiculos);
                    break;
                case 2:
                    Veiculo m = new Moto(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    veiculos.Add(m);
                    EscolhaOperacao(veiculos);
                    break;

                case 3:
                    Veiculo cm = new Caminhao(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    veiculos.Add(cm);
                    EscolhaOperacao(veiculos);
                    break;

                default:
                    throw new Exception("Insira um valor válido.");
            }
        }
        static void ExibirVeiculos(List<Veiculo> veiculos)
        {
            Console.Clear();
            foreach (Veiculo v in veiculos)
            {
                Console.WriteLine($"Marca: {v.Marca}");
                Console.WriteLine($"Modelo: {v.Modelo}");
                Console.WriteLine($"Ano: {v.Ano}");
            }
            Console.WriteLine("Enter para continuar...");
            EscolhaOperacao(veiculos);
        }
    }
}