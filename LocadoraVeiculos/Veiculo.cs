using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    public class Veiculo : IVeiculo
    {
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _baseDiarioAluguel;

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public double BaseDiarioAluguel
        {
            get { return _baseDiarioAluguel; }
            set { _baseDiarioAluguel = value; }

        }

        public Veiculo(string modelo, string marca, int ano, double baseDiarioAluguel) 
        {
            modelo = Modelo;
            marca = Marca;
            ano = Ano;
            baseDiarioAluguel = BaseDiarioAluguel;
        }

        public virtual double CalcularAluguel(int dias)
        {
            double totalAluguel = 0;
            return totalAluguel;
        }
    }
}
