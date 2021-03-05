using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class StationService
    {
        private double _prix;

        public string Nom { get; private set; }
        public double Prix
        {
            get { return _prix; }
            private set
            {
                if (value > 0)
                    _prix = value;
                else
                    throw new ArgumentOutOfRangeException($"Le prix du carburant de {GetType().Name} {Nom} est erroné.");
            }
        }

        public CompteBancaire Compte { get; private set; }

        public StationService(string nom, double prixCarburant, CompteBancaire compte)
        {
            try
            {
                Nom = nom;
                Prix = prixCarburant;
                Compte = compte;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ParamName);
            }
        }

        public virtual void VendreCarburant(Personne personne)
        {
            if (!(personne is null))
            {
                if (!(personne.Voiture is null))
                {
                    double prixAPayer = this.PrixaPayer(personne);

                    if (personne.Payer(this, prixAPayer))
                    {
                        personne.Voiture.MettreCarburant();
                        Console.WriteLine($"{personne.Prenom} a fait le plein chez {GetType().Name} {Nom}.");
                    }
                    else if (prixAPayer == 0)
                    {
                        Console.WriteLine($"{personne.Prenom} ne fait pas le plein chez {GetType().Name} {Nom} car son réservoir est plein.");
                    }
                    else
                        Console.WriteLine($"{personne.Prenom} ne peut pas faire le plein chez {GetType().Name} {Nom} car il n'a pas assez d'argent.");
                }
                else
                    Console.WriteLine($"{personne.Prenom} ne fait pas le plein chez {GetType().Name} {Nom} car il n'a pas de voiture.");
            }
        }

        protected double PrixaPayer(Personne client, int promotion = 0)
        {
            double capaciteARemplir = client.Voiture.CapaciteReservoir - client.Voiture.Reservoir;
            double prixAPayer = (capaciteARemplir * Prix) - promotion;
            return prixAPayer;
        }
    }
}
