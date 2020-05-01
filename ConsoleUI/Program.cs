using BanqueLibrairie;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {          
            Banque banque1 = new Banque("Dejardin", "815");
            Succursale succursale1 = new Succursale("Caisse", "123 rue");
            Client client1 = new Client("Alexandre", "Trudelle", "123 rue", "819-123-123", "A1B2C3");
            Compte compte1 = new Compte("Cheque");
            Compte compte2 = new Compte("epargne");

            banque1.AjouterSuccursale(succursale1);
            succursale1.AjouterUnClient(client1);
            client1.AjouterUnCompte(compte1);
            client1.RechercherUnCompte("815-001-001-001");
            compte1.Deposer(500);
        }
    }
}
