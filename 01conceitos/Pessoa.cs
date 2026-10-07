
public class Pessoa
{
    // Atributos
    public string? Nome { get; set; }
    public int Idade { get; set; }

    //Método de apresentação
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }


    //Método para retornar a situação da idade
    public int SituacaoIdade()
    {
        if (Idade < 18)
        {
            return 1; // Menor de idade
        }
        else if (Idade >= 18 && Idade < 65)
        {
            return 2; // Adulto
        }
        else
        {
            return 3; // Idoso
        }
    }   



        public string IdadeSituacao()
        {
            return Idade >= 18 ? "Adulto" : "Menor de idade";
        }
}



