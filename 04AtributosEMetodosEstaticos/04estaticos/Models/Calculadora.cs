namespace _04estaticos.Models;

    public class Calculadora
    {
        
        //Atributo numérico
        public static int numero = 10;

        //Método estático
        public static void Soma(int n1, int n2)
        {
            Console.WriteLine($"Resultado da soma: {n1 + n2}");
        }
}
