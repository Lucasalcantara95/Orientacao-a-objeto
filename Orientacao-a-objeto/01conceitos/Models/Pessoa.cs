namespace Models;

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }


    //Metodo de apresentação
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }

    //Metodo de apresentação com retorno
    public string ApresentarComRetorno()
    {
        return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";
    }

    //Metodo de apresentação com retorno e parametros
    public string ApresentarComRetornoParametros(string nome, int idade)
    {
        return $"Olá, meu nome é {nome} e tenho {idade} anos.";
    }


    //metodo de Verificação de idade
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
}
