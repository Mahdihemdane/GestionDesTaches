using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeGarage.BLL
{
    public class Automobile
    {
        private int annee;
        private string immatriculation;

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }

        public Automobile(int annee, string immatriculation)
        {
            this.annee = annee;
            this.immatriculation = immatriculation;
        }


        public virtual void Afficher()
        {
            Console.WriteLine($"Année : {annee}, Immatriculation : {immatriculation}");
        }

        public override string ToString()
        {
            return annee + immatriculation;
        }
    }
}