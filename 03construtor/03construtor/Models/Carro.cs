namespace _03construtor.Models;

    public class Carro
    {
        public Carro()
        {
            Console.WriteLine("Construtor padrão chamado");
        }

        public Carro(string modelo)
        {
            Console.WriteLine($"O modelo do carro é: {modelo}. Construtor com um parâmetro chamado");
        }

        public Carro(string modelo, string cor)
        {
            Console.WriteLine($"O modelo do carro é: {modelo} e a cor é: {cor}. Construtor com dois parâmetros chamado");
        }
    }