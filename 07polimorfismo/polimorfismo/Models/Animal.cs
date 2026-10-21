namespace polimorfismo.Models;

public class Animal
{
    public virtual void Som()
    {
        Console.WriteLine("Animal desconhecido...");
    }
}
// a palavra virtual significa que o metodo SOM pode ser sobrescrito.