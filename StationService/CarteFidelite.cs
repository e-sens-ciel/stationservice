using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class CarteFidelite
    {
        public int PointsBonus { get; private set; }
        public int Reduction { get; private set; }

        public CarteFidelite()
        {
        }

        public void AjouterPoints(int pointsGagnes)
        {
            if (PointsBonus + pointsGagnes >= 100)
            {
                PointsBonus = (PointsBonus + pointsGagnes) - 100;
                Reduction += 1;
            }
            else
                PointsBonus += pointsGagnes;
        }
    }
}
