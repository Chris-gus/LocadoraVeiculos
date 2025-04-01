namespace LocadoraVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void EscolhaTipo(Veiculo v)
        {
            Console.WriteLine("Que tipo de veículo você deseja? ");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Caminhão");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case (char)1:
                    Carro cr = new Carro(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    InserirInf(cr);
                    break;
                case (char)2:
                    Moto m = new Moto(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    InserirInf(m);
                    break;

                case (char)3:
                    Caminhao cm = new Caminhao(v.Modelo, v.Marca, v.Ano, v.BaseDiarioAluguel);
                    InserirInf(cm);
                    break;

                default:
                    throw new Exception("Insira um valor válido.");
            }
        }
        static Veiculo InserirInf(Veiculo v)
        {
            Console.WriteLine("Insira o modelo do veículo: ");
            v.Modelo = Console.ReadLine();
            Console.WriteLine("Insira a marca do veículo: ");
            v.Marca = Console.ReadLine();
            Console.WriteLine("Insira o ano do veículo: ");
            v.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor base diário de aluguel desse veículo?");
            v.BaseDiarioAluguel = double.Parse(Console.ReadLine());
            return v;
        }
    }
}