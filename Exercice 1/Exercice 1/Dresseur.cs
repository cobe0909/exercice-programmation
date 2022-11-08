namespace Exercice_1;


public class Dresseur : EtreVivant
{
    
       public Dresseur (string firstName) : base(firstName)
        {
        }
    
        public override void DefineMyself()
        {
            // do something
            Console.WriteLine($"Je suis un·e dresseur-dresseuse qui s'appelle {FirstName}");
        }
        public void DemandeTambour()
        {
            // do something
            Console.WriteLine($"Je suis un·e dresseur-dresseuse qui s'appelle {FirstName}. Je demande a mon singe de faire du tambour");
        }
        public void DemandeRoulade()
        {
            // do something
            Console.WriteLine($"Je suis un·e dresseur-dresseuse qui s'appelle {FirstName}. Je demande a mon singe de faire une roulade");
        }
}
