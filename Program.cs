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

            double imc = peso / (altura * altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso {2}" , nome, altura, peso);
            Console.WriteLine("seu IMC {0}", imc);






        }
    }
}
