namespace media;

class Program{
    static void Main(){
        Console.WriteLine("Informe a primeira variável: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda variável: ");
        float b = float.Parse(Console.ReadLine());
        
        float media = (a + b)/2;
        Console.WriteLine("a média é: "+ media);
    }
}