namespace _08interface.Models;

public class Calculadora : ICalculadoraBase, ICalculadoraAvancada
{

    //Métodos da ICalculadoraBase
    public double Soma()
    {
        Console.WriteLine("Executando Soma");
        Numeros numeros = new Numeros();
        numeros.resultado = numeros.Numero1 + numeros.Numero2;
        Console.WriteLine($"Resultado da Soma: {numeros.resultado}");
        return numeros.resultado;
    }

    public double subtracao()
    {
        Console.WriteLine("Executando Subtração");
        Numeros numeros = new Numeros();
        numeros.resultado = numeros.Numero1 - numeros.Numero2;
        Console.WriteLine($"Resultado da Subtração: {numeros.resultado}");
        return numeros.resultado;
    }

    public double multiplicacao()
    {
        Console.WriteLine("Executando Multiplicação");
        Numeros numeros = new Numeros();
        numeros.resultado = numeros.Numero1 * numeros.Numero2;
        Console.WriteLine($"Resultado da Multiplicação: {numeros.resultado}");
        return numeros.resultado;
    }

    public double divisao()
    {
        Console.WriteLine("Executando Divisão");
        Numeros numeros = new Numeros();
        numeros.resultado = numeros.Numero1 / numeros.Numero2;
        Console.WriteLine($"Resultado da Divisão: {numeros.resultado}");
        return numeros.resultado;
    }

    //Métodos da ICalculadoraAvancada
    public double Tangente()
    {
        return 0;
    }

    public double Coseno()
    {
        return 0;
    }

    public double Seno()
    {
        return 0;
    }
}