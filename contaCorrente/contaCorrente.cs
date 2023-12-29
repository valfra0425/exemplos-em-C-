namespace contaCorrente;
class ContaCorrente
{
    private string Name { get; set; }

    private float Saldo { get; set; }

    public ContaCorrente(string name){
        this.Name = name;
        this.Saldo = 0;
    }
    public void Deposito(float valor){
        this.Saldo += valor;
    }

    public void Saque(float valor){
        if (valor < this.Saldo){
            this.Saldo -= valor;
        } else {
            Console.WriteLine("saldo insuficiente");
        }
    }

    public float VerSaldo(){
        return this.Saldo;
    }

    static void Main(string[] args)
    {
        ContaCorrente n1 = new ContaCorrente("valmir");
        Console.WriteLine(n1.VerSaldo());
        n1.Deposito(2000);
        Console.WriteLine(n1.VerSaldo());
        n1.Saque(1000);
        Console.WriteLine(n1.VerSaldo());
        n1.Saque(2000);

    }
}
