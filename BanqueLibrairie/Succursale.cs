using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Succursale
    {
        private string nom;
        private string adresse;
        private string noSuccursale;
        private static int compteurSuccursale = 0;
        private List<Client> listeDeClient = new List<Client>();

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
        /// Supprime un client de la succursale
        /// </summary>
        /// <param name="client">le client à supprimer</param>
        public void SupprimerUnclient(Client client)
        {
            listeDeClient.Remove(client);
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
        public Client RechercherUnClient(string numeroClient)
        {
            string[] numero = numeroClient.Split('-');
            foreach (Client client in listeDeClient)
            {
                if (numero[3] == client.numeroClient)
                {
                    return client;
                }
            }
            return null;
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
