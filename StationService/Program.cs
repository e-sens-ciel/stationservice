using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("BE0123456789", 45000);
            CompteBancaire compte2 = new CompteBancaire("BE987654321", 35000);
            Personne OuiOui = new Personne("Oui", "Oui", compte);
            Concessionnaire concessionnaire = new Concessionnaire("jony", "Cash", compte2);
            Finoil BonneEssence = new Finoil("BonneEssence", -1.27, new CompteBancaire("BE98765", 15000));
            Taxecool MiamAuto = new Taxecool("MiamAuto", 1.35, new CompteBancaire("Be123567", 130000));

            concessionnaire.VendreVoiture(OuiOui, new Voiture("Mercedez", 12500, 5.3, 55));
            BonneEssence.VendreCarburant(OuiOui);
            OuiOui.Voiture.Rouler(653);
            MiamAuto.VendreCarburant(OuiOui);
            OuiOui.Voiture.Rouler(254);
            Console.WriteLine($"Solde : {OuiOui.CarteBancaire.Solde} , essence : {OuiOui.Voiture.Reservoir} , points TaxeCool : {OuiOui.CarteFidelite.PointsBonus}");


            Console.ReadLine();
        }
    }
}
