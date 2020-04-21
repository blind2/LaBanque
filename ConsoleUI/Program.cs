using BanqueLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Créations des objets
            Banque banque1 = new Banque("Desjardins", 815);
            Succursale succursale1 = new Succursale("Caisse Desjardin", "300, boulevard des Bois-Francs Sud");
            Client client1 = new Client("Alexandre", "Trudelle", "52 rue fournier", "819-740-7201", "G6S2K9");
            Compte compte1 = new Compte("12345",0);
            Compte compte2 = new Compte("3456", 0);

            //Met les obejets les un dans les autres
            banque1.AjouterSuccursale(succursale1);
            succursale1.AjouterClient(client1);
            client1.AjouterCompte(compte1);
            banque1.DeposerArgent(compte1, 500);
            banque1.DeposerArgent(compte1, 600);
            compte1.VoirSolde();
            compte1.CompareTo(compte2);
            

        }
    }
}
