namespace _05heranca.Models;

public class Pessoa
{

    // atributos
    private string? _nome;
    private int _idade;


    //Construtor
    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }


    //metodo para apresentar os dados
    protected void ApresentarPessoa()
    {

        Console.WriteLine($"Nome: {_nome}, Idade: {_idade}");
    }
}
