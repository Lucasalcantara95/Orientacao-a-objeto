namespace _08abstracao.Models;

public abstract class Acoes
{
    //Métodos obrigatórios
    public abstract void Falar();
    public abstract void Andar();
    public abstract void Comer();

    //Métodos opcionais
    public void Pular()
    {
        Console.WriteLine("Pulando");
    }

    public void Correr()
    {
        Console.WriteLine("Correndo");
    }
}
