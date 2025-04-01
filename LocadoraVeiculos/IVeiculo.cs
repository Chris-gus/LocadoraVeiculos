using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    public interface IVeiculo
    {
        double CalcularAluguel(int dias);
    }
}
