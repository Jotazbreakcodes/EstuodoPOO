using System;
using System.Diagnostics.Contracts;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            try
            {
                Console.WriteLine(Calculadora.Divisao(5, 0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine(Calculadora.Soma(5, 5));
            Console.WriteLine(Calculadora.Multiplicacao(5, 5));
            Console.WriteLine(Calculadora.Subtracao(5, 5));

        }


        public static class Calculadora
        {
            public static decimal Soma(decimal a, decimal b)
            {
                return a + b;

            }

            public static decimal Subtracao(decimal a, decimal b)
            {
                return a - b;

            }
            public static decimal Multiplicacao(decimal a, decimal b)
            {
                return a * b;

            }

            public static decimal Divisao(decimal a, decimal b)
            {

                if (b == 0)
                {
                    throw new ArgumentException("Não é divisivel por 0");
                }

                return a / b;

            }
        }
    }
}