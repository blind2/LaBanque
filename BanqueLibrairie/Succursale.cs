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

        public void AjouterUnClient(Client client)
        {
            listeDeClient.Add(client);
            foreach (Client items in listeDeClient)
            {

            }
        }      
        
        public void RechercherUnCompte(string numeroCompte)
        {           
           
                      
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
