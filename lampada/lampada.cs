namespace lampada;
class Lampada
{
    private bool Ligada { get; set; }

    private double Potencia { get; set; }

    public void Ligar(){
        Ligada = true;
    }

    public void Desligar(){
        Ligada = false;
    }

    public bool EstaLigada(){
        return Ligada;
    }

    public Lampada(bool ligada, double potencia){
        this.Ligada = ligada;
        this.Potencia = potencia;
    }

    static void Main(string[] args)
    {
        Lampada vermelha = new Lampada(false, 100);
        Console.WriteLine(vermelha.EstaLigada());
        vermelha.Ligar();
        Console.WriteLine(vermelha.EstaLigada());
    }
}
