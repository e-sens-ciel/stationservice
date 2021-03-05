using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public Voiture Voiture { get; set; }
        public CompteBancaire CarteBancaire { get; private set; }
        public CarteFidelite CarteFidelite { get; private set; }

        public Personne(string nom, string prenom, CompteBancaire carteBancaire)
        {
            Nom = nom;
            Prenom = prenom;
            CarteBancaire = carteBancaire;
            CarteFidelite = new CarteFidelite();
        }

        public Personne(string nom, string prenom, CompteBancaire carteBancaire, Voiture voiture)
            : this(nom, prenom, carteBancaire)
        {
            Voiture = voiture;
        }

        public void Conduire(double km)
        {
            if (!(Voiture is null))
            {
                Voiture.Rouler(km);
            }
            else
                Console.WriteLine($"{Nom} {Prenom} n'a pas de véhicule  Il ne peut donc parcourir {km} kilomètre(s).");
        }

        public bool Payer(Personne p1, double somme)
        {
            if (!(p1 is null))
            {
                if (this.CarteBancaire.Retrait(somme))
                {
                    p1.CarteBancaire.Versement(somme);
                    return true;
                }
            }
            return false;
        }
        public bool Payer(StationService station, double somme)
        {
            if (!(station is null))
            {
                if (this.CarteBancaire.Retrait(somme))
                {
                    station.Compte.Versement(somme);
                    return true;
                }
            }

            return false;
        }

    }
}





