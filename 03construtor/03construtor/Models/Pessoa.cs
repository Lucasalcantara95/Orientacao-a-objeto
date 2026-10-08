namespace _03construtor.Models
{
    public class Pessoa
    {
        //Primeiro construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor padrão chamado");
        }

        //Segundo construtor
        public Pessoa(string nome)
        {
            Console.WriteLine($"Olá, {nome}! Construtor com um parâmetro chamado");
        }

        //Terceiro construtor
        public Pessoa(string nome, int idade)
        {
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos. Construtor com dois parâmetros chamado");
        }
    }
}