namespace _02encapsulamento.Models;

public class Aluno
{
    //Atributos
    //1° maneira
    private string? _nome;
    public string? Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    //2° maneira
    public double Media { get; set; }
}
