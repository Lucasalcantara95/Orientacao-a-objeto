Console.WriteLine("");
Console.WriteLine("================================");
Console.WriteLine("Agora vamos realizar a soma:");
Console.WriteLine("================================");
Console.WriteLine("");

Numeros numerosSoma = new Numeros();
Console.WriteLine("Digite o primeiro número:");
numerosSoma.Numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numerosSoma.Numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Você digitou: {numerosSoma.Numero1} e {numerosSoma.Numero2}");
Console.WriteLine("O resultado da soma é: " + (numerosSoma.Numero1 + numerosSoma.Numero2));


Console.WriteLine("");
Console.WriteLine("================================");
Console.WriteLine("Agora vamos realizar a subtração:");
Console.WriteLine("================================");
Console.WriteLine("");


Numeros numerosSubtracao = new Numeros();
Console.WriteLine("Digite o primeiro número:");
numerosSubtracao.Numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numerosSubtracao.Numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Você digitou: {numerosSubtracao.Numero1} e {numerosSubtracao.Numero2}");
Console.WriteLine("O resultado da subtração é: " + (numerosSubtracao.Numero1 - numerosSubtracao.Numero2));


Console.WriteLine("");
Console.WriteLine("================================");
Console.WriteLine("Agora vamos realizar a multiplicação:");
Console.WriteLine("================================");
Console.WriteLine("");


Numeros numerosMultiplicacao = new Numeros();
Console.WriteLine("Digite o primeiro número:");
numerosMultiplicacao.Numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numerosMultiplicacao.Numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Você digitou: {numerosMultiplicacao.Numero1} e {numerosMultiplicacao.Numero2}");
Console.WriteLine("O resultado da multiplicação é: " + (numerosMultiplicacao.Numero1 * numerosMultiplicacao.Numero2));


Console.WriteLine("");
Console.WriteLine("================================");
Console.WriteLine("Agora vamos realizar a divisão:");
Console.WriteLine("================================");
Console.WriteLine("");


Numeros numerosDivisao = new Numeros();
Console.WriteLine("Digite o primeiro número:");
numerosDivisao.Numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numerosDivisao.Numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Você digitou: {numerosDivisao.Numero1} e {numerosDivisao.Numero2}");
Console.WriteLine("O resultado da divisão é: " + (numerosDivisao.Numero1 / numerosDivisao.Numero2));