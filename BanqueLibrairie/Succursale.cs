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
        /// Depose dans le compte du client
        /// </summary>
        /// <param name="numeroCompte">numero de compte du client</param>
        /// <param name="montant">montant à déposer</param>
        /// <returns>retourne le solde du compte ou 0 s'il n'a pas trouvée de compte/returns>
        public long DeposerDans(string numeroCompte, long montant)
        {
            string[] numero = numeroCompte.Split('-');
            if (numero[1] == this.noSuccursale)
            {
                foreach (Client client in listeDeClient)
                {
                    if (numero[3] == client.numeroClient)
                    {
                        client.DeposerDans(numeroCompte, montant);
                    }
                }
            }
            return 0;
        }
  
        /// <summary>
        /// Retire dans un compte
        /// </summary>
        /// <param name="numeroCompte">numero de compte</param>
        /// <param name="montant">montant d'argent à retirer</param>
        /// <returns>retourne le solde du compte ou 0 s'il n'a pas trouvée de compte </returns>
        public long RetirerDans(string numeroCompte, long montant)
        {
            string[] numero = numeroCompte.Split('-');
            if (numero[1] == this.noSuccursale)
            {
                foreach (Client client in listeDeClient)
                {
                    if (numero[3] == client.numeroClient)
                    {
                        client.RetirerDans(numeroCompte, montant);
                    }
                }
            }
            return 0;
        }

       /// <summary>
       /// Trouve un compte avec un numéro de compte
       /// </summary>
       /// <param name="numeroCompte">numéro de compte</param>
       /// <returns>retourne un compte ou null s'il ne trouve pas de compte</returns>
        public Client TrouverUnClient(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');
            if (numero[1]==this.noSuccursale)
            {
                foreach (Client client in listeDeClient)
                {
                    if (numero[3] == client.numeroClient)
                    {
                        client.TrouverUnCompte(numeroCompte);
                    }
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
