//exemplo 01 de como instanciar uma classe e utilizar seus metodos

Pessoa obj1 = new Pessoa();
obj1.Nome = "Lucas";
obj1.Idade = 25;
obj1.Apresentar();

//exemplo 02 de como instanciar uma classe e utilizar seus metodos
Pessoa obj2 = new();
obj2.Nome = "Maria";
obj2.Idade = 17;
obj2.Apresentar();

//exemplo 03 de como instanciar uma classe e utilizar seus metodos
Pessoa obj3 = new()
{
    Nome = "João",
    Idade = 30
};
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);