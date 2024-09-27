using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraJurosCompostos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Digite o valor investido (R$): ");
            Double valor = Convert.ToDouble(Console.ReadLine());

            calculadora.SetValor(valor);

            Console.Write("Digite a taxa de juros (em %): ");
            double taxajuros = Convert.ToDouble(Console.ReadLine());

            calculadora.SetTaxaJuros(taxajuros);

            Console.Write("Digite sua contribuição mensal (R$): ");
            int meses = Convert.ToInt32(Console.ReadLine());

            calculadora.SetMeses(meses);

            Console.Write("Digite a quantia de tempo (em Anos): ");
            int tempo = Convert.ToInt32(Console.ReadLine());

            calculadora.SetTempo(tempo);

            Console.WriteLine();

            double montante = calculadora.CalcualarMontante();
            Console.WriteLine($"O montante final após {tempo} anos é: {montante:C2}");

            Console.ReadKey();
        }
    }
}
