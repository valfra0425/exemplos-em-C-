namespace loop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("informe 1 ou 2.");
        while(true){
            string v1 = Console.ReadLine();
            if (v1 == "1" || v1 == "2"){
                break;
            }
            else{
                Console.WriteLine("eu falei 1 ou 2!!!");
            }
        }
    }
}
