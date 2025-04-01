using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    internal class Moto : Veiculo
    {
        public Moto(string modelo, string marca, int ano, double baseDiarioAluguel) : base(modelo, marca, ano, baseDiarioAluguel)
        {
        }
        public override double CalcularAluguel(int dias)
        {
            return base.CalcularAluguel(dias);
        }
    }
}
