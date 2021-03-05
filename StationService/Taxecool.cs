using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class Taxecool : StationService
    {
        public Taxecool(string nom, double prixCarburant, CompteBancaire compte) 
            : base(nom, prixCarburant, compte)
        {
        }

        public override void VendreCarburant(Personne client)
        {
            if(!(client is null))
            {
                double montant = PrixaPayer(client, client.CarteFidelite.Reduction);
                int capaciteARemplir = (int)(client.Voiture.CapaciteReservoir - client.Voiture.Reservoir);

                if (client.Payer(this, montant))
                {
                    client.Voiture.MettreCarburant();
                    client.CarteFidelite.AjouterPoints(capaciteARemplir);
                    Console.WriteLine($"{client.Prenom} a fait le plein chez {GetType().Name} {Nom}.");
                }
                else if (montant == 0)
                {
                    Console.WriteLine($"{client.Prenom} ne fait pas le plein chez {GetType().Name} {Nom} car son réservoir est plein.");
                }
                else
                    Console.WriteLine($"{client.Prenom} ne peut pas faire le plein chez {GetType().Name} {Nom} car il n'a pas assez d'argent.");
            }
            else
                Console.WriteLine($"{client.Prenom} ne fait pas le plein chez {GetType().Name} {Nom} car il n'a pas de voiture.");
        }
    }
}
