namespace Exercice_1;

public abstract class EtreVivant
{
    
    protected string FirstName { get; set; }

    // je peux indiquer mon constructeur comme "protected" (= accessible par mes enfants)
    protected EtreVivant(string firstName)
    {
        FirstName = firstName;
    }

    // Le mot clé 'virtual' indique aux autres développeurs que cette méthode peut être surchargée.
    // On lui définit un comportement 'de base', et si celui-ci ne voneint pas (ou demande complément d'information),
    // alors ils pourront changer ce comportement en redéfinissant cette méthode avec le mot clé "override".
    public virtual void DefineMyself()
    {
        Console.WriteLine($"Je suis une personne qui s'appelle {FirstName}");
    }
    

}
