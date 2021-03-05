using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class CompteBancaire
    {
        public string numero { get; private set; }

        private double _solde;

        public double Solde
        {
            get { return _solde; }
            private set
            {
                if (value >= 0)
                    _solde = value;
                else
                    throw new ArgumentOutOfRangeException("Le solde du compte ne peut être négatif");
            }
        }

        public CompteBancaire(string numero)
        {
            this.numero = numero;
            this.Solde = 0;
        }

        public CompteBancaire(string numero, double solde)
            : this(numero)
        {
            try
            {
                this.Solde = solde;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ParamName);
            }
        }

        public bool Retrait(double montant)
        {
            if (Solde >= montant && montant > 0)
            {
                this.Solde -= montant;
                return true;
            }
            return false;
        }

        public void Versement(double montant)
        {
            if (montant > 0)
                this.Solde += montant;
        }
    }
}
