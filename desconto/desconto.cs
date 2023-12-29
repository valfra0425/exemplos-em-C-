namespace desconto;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do produto");
        string produto = Console.ReadLine();
        Console.WriteLine("Informe o valor do produto");
        float preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o desconto do produto");
        int desconto = int.Parse(Console.ReadLine());

        double redu = preco*(0.01 * desconto);
        double valorf = preco-redu;

        Console.WriteLine("o Produto "+produto+" de valor "+preco+" teve um desconto de "
        +desconto+"%, reduzindo seu valor em "+redu);
        Console.WriteLine("seu valor final é de " + valorf);
    }
}
