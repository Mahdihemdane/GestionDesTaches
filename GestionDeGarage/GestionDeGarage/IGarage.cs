using GestionDeGarage.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum SubType { Voiture,Moto}
public interface IGarage
{
    string AddAuto(Automobile au);
    string UpdateAuto(Automobile au);
    int GetIndexAuto(Automobile a1);
    string DeleteAuto(string immatriculation);
    Automobile GetAuto(string immatriculation);
    List<Automobile> AfficherAutomobiles
        (SubType soustype);
}
