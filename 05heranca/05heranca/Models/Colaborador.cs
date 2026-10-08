namespace _05heranca.Models;

    public class Colaborador : Pessoa
    {
        
        //atributos
        private string? _cargo;
        private double _salario;



        //Construtor
        public Colaborador(string nome, int idade, string cargo, double salario)
        {
            Nome = nome;
            Idade = idade;
            _cargo = cargo;
            _salario = salario;

            ApresentarPessoa();
            ApresentarColaborador();
        }


         //metodo para apresentar os dados
        private void ApresentarColaborador()
        {
            Console.WriteLine($"Cargo: {_cargo}, Salário: {_salario}");
        }
    }
