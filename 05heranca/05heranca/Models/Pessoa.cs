namespace _05heranca.Models;

public class Pessoa
{

    // atributos
    protected string? Nome;
    protected int Idade;


    //metodo para apresentar os dados
    protected void ApresentarPessoa()
    {

        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }


}
