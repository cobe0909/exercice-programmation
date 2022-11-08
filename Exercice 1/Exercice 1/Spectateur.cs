namespace Exercice_1;

public class Spectateur : EtreVivant
{
    public Spectateur (string firstName) : base(firstName)
    {
    }
    
    public override void DefineMyself()
    {
        // do something
        Console.WriteLine($"Je suis un·e spectateur-spectatrice qui s'appelle {FirstName}");
    }
    
    public void Siffler()
    {
        // do something
        Console.WriteLine($"Je suis un spectateur qui s'appele {FirstName}. Je siffle pour le tour de musique");
    }
    public void Applaudir()
    {
        // do something
        Console.WriteLine($"Je suis un spectateur qui s'appele {FirstName}. J'applaudis pour le tour d'acrobatie ");
    }
}