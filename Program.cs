using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4._11
{
    class Program
    {
        static double ObtenirNotesNièmeEtudiant()
        {
            const int nbDeNotes = 3;
            int compteurNote;
            double sommeRésultat = 0;

            for (compteurNote = 0; compteurNote < nbDeNotes; compteurNote++)
            {
                sommeRésultat += LireNièmeNote();
            }
            return sommeRésultat / nbDeNotes;

        }
        
        static double LireNièmeNote()
        {
            const int Min = 0;
            const int Max = 100;
            double note;

            do
            {
                Console.Write("Entrez la note [0,100]: ");
                note = double.Parse(Console.ReadLine());
            } while (note < Min || note > Max);

            return note;

        }

        static void Main(string[] args)
        {
            const int NombreEtudiants = 2;

            for (int compteur = 0; compteur < NombreEtudiants; compteur++)
            {
                double moyenne = ObtenirNotesNièmeEtudiant();
                Console.Write(moyenne);
            }

        }
    }
}
