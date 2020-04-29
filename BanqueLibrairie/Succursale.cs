using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueLibrairie
{
    public class Succursale
    {
        private string nom;
        private string adresse;
        private string noSuccursale;
        private static int compteurSuccursale = 0;
        List<Client> listeDeClient = new List<Client>();
        List<Compte> listeDeCompte = new List<Compte>();

        public Succursale()
        {

        }

        /// <summary>
        /// indentifie une succursale avec un numero a 3 chiffres.
        /// </summary>
        /// <returns>string de ce numero</returns>
        public static string GetNumeroSuccursale()
        {
            return (++compteurSuccursale).ToString("D3");
        }

        /// <summary>
        /// Information de base de la surccursale
        /// </summary>
        /// <param name="nom">nom de la surccursale</param>
        public Succursale(string nom, string adresse)
        {
            this.nom = nom;
            this.Adresse = adresse;
            this.noSuccursale = GetNumeroSuccursale();
        }

        /// <summary>
        /// Ajoute un client a la succursale
        /// </summary>
        /// <param name="client"></param>
        public void AjouterUnClient(Client client)
        {
            foreach (Client items in listeDeClient)
            {
                listeDeClient.Add(client);
            }
        }

        /// <summary>
        /// Ajoute un compte au client
        /// </summary>
        /// <param name="compte"></param>
        public void AjouterUnCompteAuClient(Compte compte)
        {
            
            foreach (var items in listeDeCompte)
            {
                listeDeCompte.Add(compte);
            }
        }
        
        public void RechercherUnCompte(string numeroCompte)
        {           
            string[] numero = numeroCompte.Split('-');
            if (numero[1]==this.NoSuccursale)
            {
                foreach (Compte item in listeDeCompte)
                {
                    if (numero[2] == item.NoCompte)
                    {
                        Console.WriteLine();
                    }
                }                              
            }
        }

        public string Nom
        {
            get { return nom; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string NoSuccursale
        {
            get { return noSuccursale; }
        }
    }
}
