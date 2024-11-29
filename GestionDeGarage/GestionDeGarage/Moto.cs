using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeGarage.BLL
{
    public class Moto : Automobile
    {
        private int cylindre;
        private int vitesseMax;


        public int Cylindre
        {
            get { return cylindre; }
            set { cylindre = value; }
        }

        public int VitesseMax
        {
            get { return vitesseMax; }
            set { vitesseMax = value; }
        }

        public Moto(int annee, string immatriculation, int cylindre, int vitesseMax)
            : base(annee, immatriculation)
        {
            this.cylindre = cylindre;
            this.vitesseMax = vitesseMax;
        }


        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Cylindre : {cylindre}, Vitesse Max : {vitesseMax}");
        }

        public override string ToString()
        {
            return $"Moto [Cylindre={cylindre}, VitesseMax={vitesseMax}, {base.ToString()}]";
        }

    }
}
