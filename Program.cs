using System;

namespace CSHARP_Boucles_Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //définir une variable aléatoire, l'âge de la dame
            Random aleatoire = new Random(); 
            int secretnumber = aleatoire.Next(1, 51);
            int attempts = 1;
            int success = 0;

            Console.WriteLine("Hey mon chou, devine mon âge, petit indice, j'ai entre 1 et 50 ans *wink* *wink*");
                int input = int.Parse(Console.ReadLine());

            do
            {
                if (input == secretnumber)
                {
                    Console.WriteLine($"attempts numéro {attempts} \n Bien deviné mon chou *wink* *wink*");
                    success = 1;}
                else if (input < secretnumber)
                {
                    Console.WriteLine($"attempts numéro {attempts} \n Vil flatteur, je sais que je ne fait pas mon âge, mais tout de même ! Essaie encore !");
                    attempts++;
                    input = int.Parse(Console.ReadLine());
                }
                else if (input > secretnumber)
                {
                    Console.WriteLine($"attempts numéro {attempts} \n Ah ! Traites moi tout de suite de vieille peau tant que tu y es! Essaie encore !");
                    attempts++;
                    input = int.Parse(Console.ReadLine());
                }
            } while (success == 0) ;
            }
        }
    } 

