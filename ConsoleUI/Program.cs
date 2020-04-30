using BanqueLibrairie;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Créations des objets
            Banque banque1 = new Banque("815");
            Succursale succursale1 = new Succursale("Caisse Desjardin", "300, boulevard des Bois-Francs Sud");
            Client client1 = new Client("Alexandre", "Trudelle", "123 rue", "819-123-123", "G6S2K9");
            Compte compte1 = new Compte("Cheque");
            Compte compte2 = new Compte("epargne");
           
            banque1.AjouterSuccursale(succursale1);
            succursale1.AjouterUnClient(client1);
            client1.AjouterUnCompte(compte1);
            compte1.Deposer(500);
            
            //Moyen de Recherche
            client1.RechercherUnCompte("815-001-001-001");           
            succursale1.RechercherUnClient("815-001-001-001");
            banque1.RechercherUneSuccursale("815-001-001-001");
            


            compte1.VoireLeSoldeDuCompte("815-001-001-001");
            


        }
    }
}
