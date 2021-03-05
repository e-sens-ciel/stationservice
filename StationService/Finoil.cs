using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class Finoil : StationService
    {
        private static Random Rng = new Random();
        private int _numeroGagnant = Rng.Next(101);

        public Finoil(string nom, double prixCarburant, CompteBancaire compte)
            : base(nom, prixCarburant, compte)
        {
        }

        public override void VendreCarburant(Personne personne)
        {
            if (!(personne is null))
            {
                if (!(personne.Voiture is null))
                {
                    double montant = PrixaPayer(personne);
                    int numeroJoue = Rng.Next(101);

                    if (_numeroGagnant != numeroJoue)
                    {
                        if (personne.Payer(this, montant))
                        {
                            personne.Voiture.MettreCarburant();
                            Console.WriteLine($"{personne.Prenom} a fait le plein chez {GetType().Name} {Nom}.");
                        }
                        else if (montant == 0)
                        {
                            Console.WriteLine($"{personne.Prenom} ne fait pas le plein chez {GetType().Name} {Nom} car son réservoir est plein ou qu'il ya une erreur de prix du carburant.");
                        }
                        else
                            Console.WriteLine($"{personne.Prenom} ne peut pas faire le plein chez {GetType().Name} {Nom} car il n'a pas assez d'argent.");
                    }
                    else
                    {
                        personne.Voiture.MettreCarburant();
                        Console.WriteLine($"{personne.Prenom} a fait le plein gratuitement chez {GetType().Name} {Nom}.");
                    }
                }
                else
                    Console.WriteLine($"{personne.Prenom} ne fait pas le plein chez {GetType().Name} {Nom} car il n'a pas de voiture.");
            }
        }
    }
}
