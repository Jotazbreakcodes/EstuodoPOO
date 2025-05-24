using System;
using System.Diagnostics.Contracts;

namespace EstudoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numero, numero2;
            Console.Clear();
            Console.WriteLine("Digite um número");
            while (!decimal.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite apenas numeros por favor");
            }

            Console.WriteLine("Digite outro número");
            while (!decimal.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Digite apenas numeros por favor");
            }

            try
            {
                Console.WriteLine(Calculadora.Divisao(numero, numero2));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($" Não é possivel dividir por 0 {ex}");
            }
            Console.WriteLine(Calculadora.Soma(numero, numero2));
            Console.WriteLine(Calculadora.Multiplicacao(numero, numero2));
            Console.WriteLine(Calculadora.Subtracao(numero, numero2));
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