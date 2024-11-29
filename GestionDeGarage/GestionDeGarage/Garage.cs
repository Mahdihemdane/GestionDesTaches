using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeGarage.BLL
{
    public class Garage : IGarage
    {
        private string adresse;
        private List<Automobile> autos;


        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }


        public Garage()
        {
            autos = new List<Automobile>();
        }

        public Garage(string adresse) : this()
        {
            this.adresse = adresse;
        }


        public string AddAuto(Automobile au)
        {
            try
            {
                autos.Add(au);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void AfficherAutomobiles()
        {
            foreach (var au in autos)
            {
                au.Afficher();
            }
        }

        public void DeleteAuto(Automobile au)
        {
            autos.Remove(au);
        }

        public Automobile GetAuto(string immatriculation)
        {
            return autos.Find(a => a.Immatriculation == immatriculation);
        }

        public int GetIndexAuto(string immatriculation)
        {
            return autos.FindIndex(a => a.Immatriculation == immatriculation);
        }

        public void UpdateAuto(Automobile au)
        {
            int index = GetIndexAuto(au.Immatriculation);
            if (index >= 0)
            {
                autos[index] = au;
            }
        }

        public override string ToString()
        {
            return $"Garage [Adresse={adresse}, Nombre d'autos={autos.Count}]";
        }

        string IGarage.UpdateAuto(Automobile au)
        {
            throw new NotImplementedException();
        }

        public int GetIndexAuto(Automobile a1)
        {
            throw new NotImplementedException();
        }

        public string DeleteAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public List<Automobile> AfficherAutomobiles(SubType soustype)
        {
            throw new NotImplementedException();
        }
    }
}