using System;

namespace GestionDeGarage.BLL
{
    public class Voiture : Automobile
    {
        private string couleur;
        private string marque;
        private string typeV;


        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        public string TypeV
        {
            get { return typeV; }
            set { typeV = value; }
        }
        public Voiture(int annee, string immatriculation, string couleur, string marque, string typeV)
             : base(annee, immatriculation)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }


        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Couleur : {couleur}, Marque : {marque}, TypeV : {typeV}");
        }

        public override string ToString()
        {
            return base.ToString() + this.couleur + this.marque + this.typeV;
        }
    }
}
