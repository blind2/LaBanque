using BanqueLibrairie;

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
            Client client1 = new Client("Alexandre", "Trudelle", "123 rue", "819-123-123", "A1B2C3");
            Compte compte1 = new Compte("Cheque");
            Compte compte2 = new Compte("epargne");

            banque1.AjouterUneSuccursale(succursale1);
            succursale1.AjouterUnClient(client1);
            client1.AjouterUnCompte(compte1);
            banque1.TrouverUnCompte(client1, "815-001-001-001");
            banque1.Deposer(500);
            banque1.Retirer(100);
            client1.DeposerDans("815-001-001-001", 100);


        }
    }
}
