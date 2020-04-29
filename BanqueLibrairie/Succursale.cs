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
        Client client = new Client();


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
        /// Ajoute un client a une surccursale
        /// </summary>
        /// <param name="cl"></param>
        public void AjouteUnClient(Client cl)
        {
            foreach (Client client in listeDeClient)
            {

                listeDeClient.Add(cl);
            }
        }
        public void AjouteUnCompteAuClient(Compte c)
        {
            List<Compte> listeCompte = new List<Compte>();
            foreach (var item in listeCompte)
            {
                listeCompte.Add(c);
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
