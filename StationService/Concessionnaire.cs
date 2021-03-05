using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class Concessionnaire : Personne
    {

        public Concessionnaire(string nom, string prenom, CompteBancaire carteBancaire) 
            : base(nom, prenom, carteBancaire)
        {
        }

        public Concessionnaire(string nom, string prenom, CompteBancaire carteBancaire, Voiture voiture) 
            : base(nom, prenom, carteBancaire, voiture)
        {
        }

        public void VendreVoiture(Personne client, Voiture voiture)
        {
            if (!(client is null) && !(voiture is null))
            {
                if (client.Voiture is null)
                {
                    if (client.Payer(this, voiture.Prix))
                        client.Voiture = voiture;
                    else
                        Console.WriteLine($"La {voiture.Marque} de {voiture.Prix} euros est trop chère.");
                }
                else
                    Console.WriteLine($"{client.Nom} a déjà une {client.Voiture.Marque}.");
            }
            
        }
    }
}
