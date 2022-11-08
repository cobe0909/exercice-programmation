// See https://aka.ms/new-console-template for more information

using System.Numerics;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

var integers0 = new List<int>() //Liste avant multiplication
{
    0,
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8
};
var integers1 = new List<int>() //liste après multiplication
{
    0,
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8
};

Console.WriteLine("Veuilez saisir un numero d'identé canadien sans ponctuation (10 chiffre compris entre 000 000 000 et 999 999 999 (Sans espace ,ni ponctuation ,ni virgule"); //Methode de saisie du numéro NAS
string  chiffre_nas= Console.ReadLine();
BigInteger chiffre_nas_conv = int.Parse(chiffre_nas);


while (true)
{
    if ( (chiffre_nas_conv/chiffre_nas_conv)==1  | chiffre_nas_conv > 999999999 | chiffre_nas_conv / 1 == chiffre_nas_conv ) //condition pour les chiffre trop grand  ((Conditions pas complete, à revoir)
    {
        for (int i = 0; i < integers0.Count; i++)   //For pour remplir le tableau a partir d'une chaine de caractère
        {
            string a;
            a = (chiffre_nas.Substring(i, 1));
            int b = int.Parse(a);
            integers0[i]=b;
        }
        
        for (int i = 0; i < integers0.Count; i++)  //test du tableau et des chiffres recus
        {
            Console.WriteLine(integers0[i]);
        }
        
        Console.WriteLine("Chiffre modifié:");
       
        for (int i = 0; i < integers0.Count; i++) //Modification du chiffre saisie par la multiplication 121 212 121
        {
            if ((i % 2) == 0)
            {
                integers1[i] = Nas.fois1(integers0[i]);  //Voir Methode fois1
            }
            else
            {
                integers1[i] = Nas.fois2(integers0[i]);  //Voir Methode fois2
            }
        }
        for (int i = 0; i < integers0.Count; i++) //Affichage des chiffres multipliés
        {
            Console.WriteLine(integers1[i]);
        }
        
        int somme=0;            //Somme des chiffres multipliés
        for (int i = 0; i < integers1.Count; i++)
        {
            somme = somme + integers1[i];
        }

        int correct = somme % 10; // Division de la somme par modulo 10

        if (correct == 0) //Si correct nul = Numéro Nas Valide 
        {
            Console.WriteLine("Le chiffre entré est un numéro NAS "+chiffre_nas);
        }

        else if (correct != 0)    //Si correct pas nul = numéro nas non valide

        {
            Console.WriteLine("Le chiffre entré n'est pas un numéro NAS "+chiffre_nas);
        }
        
    }


    else
    {
        Console.WriteLine("Chiffre entré pas correct");
        break;
    }
    break;

}

/*Console.WriteLine(integers[0]);

    for (int i = 0; i < integers.Count; i++)
    {
        integers[i]=(SaisiTour.Substring(0, 1));
    }
Console.WriteLine(integers[0]);11 */

/* integers1[0] = Nas.fois1(integers0[0]);
        integers1[1] = Nas.fois2(integers0[1]);
        integers1[2] = Nas.fois1(integers0[2]);
        integers1[3] = Nas.fois2(integers0[3]);
        integers1[4] = Nas.fois1(integers0[4]);
        integers1[5] = Nas.fois2(integers0[5]);
        integers1[6] = Nas.fois1(integers0[6]);
        integers1[7] = Nas.fois2(integers0[7]);
        integers1[8] = Nas.fois1(integers0[8]);*/