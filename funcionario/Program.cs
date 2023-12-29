namespace funcionario;
class Funcionario
{
    private string nome;
    public string Nome
    {
        get {return nome;}
        set {nome = value;}
    }
    private double salario;
    public double Salario{
        get {return salario;}
        set {salario = value;}
    }

    public Funcionario(string Nome, double Salario){
        nome = Nome;
        salario = Salario;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("informe o nome do funcionario: ");
        string nome = Console.ReadLine();

        double salario = 0;
        while(true){
            Console.WriteLine("Entre com a venda em doláres(-1 para finalizar):");
            double venda = Double.Parse(Console.ReadLine());
            if(venda == -1){
                break;
            }
            else{
                salario = salario + 200 + venda*0.09;
            }
        }

        Funcionario f1 = new Funcionario(nome, salario);
        Console.WriteLine("o funcionário "+f1.Nome+" tem o salário de R$ "+ f1.Salario);
    }
}
