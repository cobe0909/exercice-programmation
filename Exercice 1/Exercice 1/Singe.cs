namespace Exercice_1;

public class Singe : EtreVivant
{
    public Singe (string firstName) : base(firstName)
    {
    }
    
    public override void DefineMyself()
    {
        // do something
        Console.WriteLine($"Je suis un singe qui s'appelle {FirstName}");
    }
    
    public void HitTheTambour()
    {
        // do something
        Console.WriteLine($"Je suis un singe qui s'appelle {FirstName}. Je fait un tour de musique avec un tambour");
    }
    
    public void Roulade()
    {
        // do something
        Console.WriteLine($"Je suis un singe qui s'appelle {FirstName}. Je fait un tour d'accrobatie en fesant une roulade");
    }
    
    
}