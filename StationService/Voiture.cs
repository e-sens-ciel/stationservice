using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class Voiture
    {

        public string Marque { get; private set; }
        public double Consommation { get; private set; }
        public double CapaciteReservoir { get; private set; }
        public double Prix { get; private set; }
        public double Reservoir { get; private set; }

        public Voiture(string marque, double prix, double consommation, double capaciteReservoir)
        {
            Marque = marque;
            Prix = prix;
            Consommation = consommation;
            CapaciteReservoir = capaciteReservoir;
        }

        /// <summary>
        /// Permet de rouler à une distance en consommant de l'essence
        /// </summary>
        /// <param name="km">km parcouru</param>
        public void Rouler(double km)
        {
            if (km > 0)
            {
                double ConsommationAuKm = Consommation / 100;
                double ConsommationTotale = ConsommationAuKm * km;

                if (Reservoir >= ConsommationTotale)
                {
                    Reservoir -= ConsommationTotale;
                    Console.WriteLine($"La voiture a parcouru {km} kolimètre(s).");
                }
                else
                {
                    Console.WriteLine("Vous n'avez plus d'essence! Veuillez faire le plein!");
                } 
            }
        }

        /// <summary>
        /// Sert à remettre du carburant
        /// </summary>
        public double MettreCarburant()
        {
            double CapaciteARemplir = CapaciteReservoir - Reservoir;
            Reservoir += CapaciteARemplir;
            return CapaciteARemplir;

        }
    }
}
