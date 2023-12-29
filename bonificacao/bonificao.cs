namespace bonificacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("informe a quantidade de anos que o funcionário trabalhou: ");
        int anos = int.Parse(Console.ReadLine());

        Console.WriteLine("informe o valor do bônus anual do funcionário: ");
        float bonus = float.Parse(Console.ReadLine());

        float valor = (bonus*anos);
        Console.WriteLine("O funcionário ganhará o montante de: R$ " + valor);
    }
}
