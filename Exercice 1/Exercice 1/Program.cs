// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations.Schema;
using Exercice_1;

Console.WriteLine("Hello, World!");

var spectateur0 = new Spectateur( "Jerome");
var dresseur0 = new Dresseur( "ShangShi");
var dresseur1 = new Dresseur("Thor");// Créer deux dresseur pour l'exercice
var singe0 = new Singe ( "Aberrant");
var singe1 = new Singe ( "Miteux");

// test des differente méthodes
spectateur0.DefineMyself();
dresseur0.DefineMyself();
dresseur1.DefineMyself();
dresseur0.DemandeRoulade();
singe0.DefineMyself();
singe0.HitTheTambour();
spectateur0.Siffler();
dresseur1.DemandeTambour();
singe1.Roulade();
spectateur0.Applaudir();


/*
Tant que (While   x )
    
    
    if 0 Crée un spectateur
                ==> Nom  => X      ;  x =>> Methode crée un spectateur
        

    Que veux tu faire 0=!  on sort
    */


while (true)
{
    Console.WriteLine("Bienvenue. Pour jouer tapez 0 sinon tapez 1 pour arretez le programme");
    string nb = Console.ReadLine();
    int nombre = int.Parse(nb);

    if (nombre == 0)
    {
        Console.WriteLine("Nombre égal a 0");
        Console.WriteLine("Veuillez saisir le nom d'un spectateur");
        string nomspectateur = Console.ReadLine();
        var spectateur1 = new Spectateur( nomspectateur);
        spectateur1.DefineMyself();
        
        while (true)
        {
            Console.WriteLine("Veuillez saisir un nombre entre 2 et 3. 2 le singe nommé Abberant fait une roulade et 3 pour que le singe Miteux frappe du tambour");

            string  SaisiTour= Console.ReadLine();
            int y = int.Parse(SaisiTour);

            if (y == 2)
            {
                Console.WriteLine("Vous avez saisi 2, le singe va executer une roulage");
                dresseur0.DemandeRoulade();
                singe0.Roulade();
                spectateur1.Applaudir();
            }

            else if (y == 3)
            {
                Console.WriteLine("Vous avez saisi 3, le singe va executer son tour de tambour");
                dresseur1.DemandeTambour();
                singe1.HitTheTambour();
                spectateur1.Siffler();
            }
            
            else
            {
                Console.WriteLine("Vous n'avez pas saisi 2 ou 3");
                break;
            }
        }


    }

    else
    {
        Console.WriteLine("Fin du programme, vous avez saisi un autre nombre que 0");
        break;
    }
    // boucle infinie
}  