using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            string combustivel;
            double litros, valorReal;


            Console.Write("(A-Alcool ou G-Gasolina) \n \nQual tipo de combustivel o senhor deseja: ");
            combustivel = Console.ReadLine().ToLower();

            Console.Write("Quantos litros: ");
            litros = Convert.ToDouble(Console.ReadLine());

            valorReal = SaberCombustivelPreco(combustivel, litros);

            Console.Clear();

            Console.Write("Você pagará R$ " + valorReal);
            Console.Read();
        }

        public static double SaberCombustivelPreco(string combustivel, double litros)
        {
            double resultado;
            double valorReal = 0;

            if (combustivel == "a" && litros <= 20)
            {
                resultado = 2.90 * litros;
                valorReal = resultado - resultado * 0.03;
            }
            if (combustivel == "a" && litros > 20)
            {
                resultado = 2.90 * litros;
                valorReal = resultado - resultado * 0.05;
            }
            if (combustivel == "g" && litros <= 20)
            {
                resultado = 4.50 * litros;
                valorReal = resultado - resultado * 0.04;
            }
            if (combustivel == "g" && litros > 20)
            {
                resultado = 4.50 * litros;
                valorReal = resultado - resultado * 0.06;
            }

            return valorReal;
        }
    }
}
