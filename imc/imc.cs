namespace imc;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("informe seu peso: ");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("informe sua altura em centimetros: ");
        float altura = float.Parse(Console.ReadLine());
        altura = altura/100;

        float imc = peso/(altura*altura);

        Console.WriteLine("seu indice de IMC é " + imc);
    }
}
