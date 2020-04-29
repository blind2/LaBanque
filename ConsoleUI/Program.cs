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
            Banque banque1 = new Banque("Desjardins","815");
            Succursale succursale1 = new Succursale("Caisse Desjardin", "300, boulevard des Bois-Francs Sud");
            Client client1 = new Client("Alexandre", "Trudelle", "52 rue fournier", "819-740-7201", "G6S2K9");
            Compte compte1 = new Compte("Cheque");
            Compte compte2 = new Compte("Cheque");

            //Met les obejets les un dans les autres
            banque1.AjouterSuccursale(succursale1);
            succursale1.AjouterUnClient(client1);
            succursale1.AjouterUnCompteAuClient(compte1);
            succursale1.AjouterUnCompteAuClient(compte2);
            banque1.DeposerDans("815-001-001");
            succursale1.RechercherUnCompte("815-001-001");
            
            compte1.VoirSolde();
            compte1.CompareTo(compte2);
            

        }
    }
}
