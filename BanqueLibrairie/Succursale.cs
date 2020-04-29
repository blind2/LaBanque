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
        
        public Succursale()
        {

        }

        /// <summary>
        /// indentifie une succursale avec un numero a 3 chiffre.
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
            List<Compte> listeCompte = new List<Compte>();
            foreach (var items in listeCompte)
            {
                listeCompte.Add(compte);
            }
        }
        
        public void RechercherCompte(string numeroCompte)
        {           
            string[] numero = numeroCompte.Split('-');
            if (numero[1]==this.NoSuccursale)
            {
                foreach (Client item in listeDeClient)
                {
                    
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
