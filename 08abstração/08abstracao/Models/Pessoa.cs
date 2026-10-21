namespace _08abstracao.Models;

public class Pessoa : Acoes
{
    public override void Andar()
    {
        Console.WriteLine("Andando");
    }

    public override void Falar()
    {
        Console.WriteLine("Falando");
    }
    
    public override void Comer()
    {
        Console.WriteLine("Comendo");
    }
}
    