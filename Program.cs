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

            double imc = Math.Round(peso / (altura * altura), 2);


            Console.WriteLine("{0} sua altura é {1} e seu peso {2}" , nome, altura, peso);
            Console.WriteLine("seu IMC {0}", imc);
          

           if (imc < 17.00 )
            {
             Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc >= 17.00 && imc < 18.50)
            {
             Console.WriteLine("Abaixo do peso {0}", imc);
            }
            else if (imc >= 18.50 && imc < 25.00)
            {
             Console.WriteLine("Peso normal {0}", imc);
            }
            else if (imc >= 25.00 && imc < 30.00 )
            {
             Console.WriteLine("Acima do peso {0}", imc);
            }
            else if (imc >= 30.00 && imc < 35.00  )
            {
             Console.WriteLine("Obesidade {0}", imc);
            }
            else if (imc >= 35.00 && imc < 40.00 )
            {
             Console.WriteLine("Obesidade II (severa) {0}", imc);
            }
            else 
            {
             Console.WriteLine("Obesidade III (mórbida) {0}", imc);
            }

            double engordar = (18.50 - imc);

            if (imc < 18.50)
            {
              Console.WriteLine( "você precisa engordar {0}", engordar);  
            }


            // 18.50    25.00

        
            

        }
    }
}
