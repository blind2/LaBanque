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
        /// <param adresse="adresse">adresse de la surccursale</param>
        public Succursale(string nom, string adresse)
        {
            this.nom = nom;
            this.Adresse = adresse;
            this.noSuccursale = GetNumeroSuccursale();
        }

        /// <summary>
        /// Ajoute un client a la succursale
        /// </summary>
        /// <param name="client">le client à ajouter</param>
        public void AjouterUnClient(Client client)
        {
            listeDeClient.Add(client);         
        }  
        
        /// <summary>
        /// Recherche un client avec son numero de client
        /// </summary>
        /// <param name="numeroClient">numero du client de 3 chiffres</param>
        public void RechercherUnClient(string numeroClient)
        {
            string[] numero = numeroClient.Split('-');
            foreach (Client client in listeDeClient)
            {
                if (numero[3]== client.numeroClient)
                {
                    _ = client;
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
