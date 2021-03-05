namespace StationService
{
    public class TaxecoolBase
    {

        public override void VendreCarburant(Personne personne)
        {
            //base.VendreCarburant(personne);
            double capaciteARemplir = personne.Voiture.MettreCarburant();
            if (personne.CarteFidelite == null)
            {
                personne.CarteFidelite = new CarteFidelite();
            }
            double prixAPayer = this.PrixaPayer(capaciteARemplir);
            personne.CarteFidelite.AjouterPoints(capaciteARemplir);
            Console.WriteLine($"Le prix à payer pour l'essence est de : {prixAPayer}");
        }
    }
}