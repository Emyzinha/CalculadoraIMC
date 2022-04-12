public class Individuo{

    public string Nome { get; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double Imc { get => Peso / (Altura * Altura); }
    
    public Individuo(float altura, float peso, string nome, double imc)    
    {
        Altura = altura;
        Peso = peso;
        Nome = nome;

    }

    

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

    if (imc < 18.50) {
    double pesoIdeal = 18.50 ;
    double pesoNecessario = Math.Round(pesoIdeal = imc, 2);
    Console.WriteLine("vc precisa ganhar {0}", pesoNecessario); 
    }

    else if (imc >= 25){
        double pesoIdeal = 24.99;
        double pesoNecessario = Math.Round(imc - pesoIdeal, 2 );
        Console.WriteLine("vc precisa perder {0}", pesoNecessario); 
    }
}          
