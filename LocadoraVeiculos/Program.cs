using System;
namespace LocadoraVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Veiculo> veiculos = new List<Veiculo>();
           int dias = 0;
           EscolhaOperacao(veiculos,dias);
        }

        static void EscolhaOperacao(List<Veiculo> veiculos, int dias)
        {
            try{
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
                    ExibirVeiculos(veiculos,dias);
                    break;

                default:
                    throw new Exception("Insira um valor válido");

            }
            }
            catch(Exception ex)
            {
                TratarExcecao(ex);
                EscolhaOperacao(veiculos,dias);
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

            EscolhaTipo(v,veiculos,dias);
        }
        static void EscolhaTipo(Veiculo v, List<Veiculo> veiculos,int dias)
        {
            try{
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
                    EscolhaOperacao(veiculos,dias);
                    break;
                case 2:
                    Veiculo m = new Moto(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    veiculos.Add(m);
                    EscolhaOperacao(veiculos,dias);
                    break;

                case 3:
                    Veiculo cm = new Caminhao(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    veiculos.Add(cm);
                    EscolhaOperacao(veiculos,dias);
                    break;

                default:
                    throw new Exception("Insira um valor válido.");
            }
            }
            catch(Exception ex){
                TratarExcecao(ex);
                EscolhaTipo(v,veiculos,dias);
            }
        }
        static void ExibirVeiculos(List<Veiculo> veiculos,int dias)
        {
            Console.Clear();
            foreach (Veiculo v in veiculos)
            {
                Console.WriteLine($"Dias Alugados: {dias}");
                Console.WriteLine($"Marca: {v.Marca}");
                Console.WriteLine($"Modelo: {v.Modelo}");
                Console.WriteLine($"Ano: {v.Ano}");
                Console.WriteLine($"Preço total do aluguel: {v.CalcularAluguel(dias)}\n");
            }
            Console.WriteLine("Enter para continuar...");
            Console.ReadKey();
            EscolhaOperacao(veiculos,dias);
        }
        static void TratarExcecao(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Enter para continuar...");
            Console.ReadKey();
        }
    }
}