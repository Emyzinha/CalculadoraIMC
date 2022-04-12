public class Individuo{

    public float Altura { get; set; }
    public float Peso { get; set; }
  
     public Individuo(float altura, float peso)    
    {
        Altura = altura;
        Peso = peso;
    }

    public double Imc { get => Peso / (Altura * Altura); }

}