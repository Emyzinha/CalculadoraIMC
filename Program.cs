using System;


namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("qual sua altura em metros?");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("qual sua peso em kg?");
            float peso = Convert.ToSingle(Console.ReadLine());

            Individuo pessoa = new Individuo( altura, peso, nome, imc);

        }
    }
}
