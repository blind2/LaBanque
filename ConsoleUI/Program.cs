﻿using BanqueLibrairie;
using BanqueLibrairie.Clientele;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Information sur le numero de compte
            // noInstitution-noSuccursale-noCompte-noClient ***

            Banque banque1 = new Banque("Dejardin", "815");
            Succursale succursale1 = new Succursale("Caisse", "123 rue");
            Etudiant etudiant1 = new Etudiant("Alexandre", "Trudelle", "123 rue", "819-123-123", "A1B2C3");           
            Compte compte1 = new Compte("Cheque"); 
            Compte compte2 = new Compte("epargne");

            banque1.AjouterUneSuccursale(succursale1);
            succursale1.AjouterUnClient(etudiant1);
            etudiant1.AjouterUnCompte(compte1);

            banque1.TrouverUnCompte("815-001-001-001");
            banque1.DeposerDans("815-001-001-001", 500);
            banque1.RetirerDans("815-001-001-001", 100);           
            etudiant1.FaireUnPretEtudiant("815-001-001-001", 5000);
            etudiant1.VoireLeSoldeDuCompte("815-001-001-001");
        }
    }
}
