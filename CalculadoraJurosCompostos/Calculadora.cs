using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraJurosCompostos
{
    internal class Calculadora
    {
        private double Valor { get; set; }
        private double TaxaJuros { get; set; }
        private int Anos { get; set; }
        private int Meses { get; set; }
        public void SetMeses (int meses)
        {
            if (meses >= 0)
            {
                Meses = meses;
            }
            else
            {
                throw new ArgumentException("O valor não pode ser negativo!");
            }
        }
        public void SetValor(double valor)
        {
            if (valor > 0)
            {
                Valor = valor;
            } else
            {
                throw new ArgumentException("O valor do montante deve ser maior que 0!");
            }
        }
        public void SetTaxaJuros (double taxajuros)
        {
            if (taxajuros > 0)
            {
                TaxaJuros = taxajuros;
            }
            else
            {
                throw new ArgumentException("O valor do juros deve ser maior que 0!");
            }
        }
        public void SetTempo (int tempo)
        {
            if (tempo > 0)
            {
                Anos = tempo;
            }
            else
            {
                throw new ArgumentException("O valor de anos deve ser maior que 0");
            }
        }
        public double CalcualarMontante ()
        {
            double i = TaxaJuros/100;  // Converte a taxa de juros para decimal
            int n = 12;  // Número de períodos (mensal)
            double t = Anos;

            // Cálculo do montante para o valor inicial
            double montanteInicial = Valor * Math.Pow((1 + i / n), n * t);

            // Cálculo do montante para a contribuição mensal
            double montanteContribuicoes = Meses * (Math.Pow((1 + i / n), n * t) - 1) / (i / n);

            // Retorna o montante total
            return montanteInicial + montanteContribuicoes;
        }
    }
}
