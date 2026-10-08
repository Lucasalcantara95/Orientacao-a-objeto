namespace _04estaticos.Models;

    public class Calculadora2
    {
        public static int numero = 20;

        public static void Subtracao(int n1, int n2)
        {
            Console.WriteLine($"Resultado da subtração: {n1 - n2}");
        }
    }