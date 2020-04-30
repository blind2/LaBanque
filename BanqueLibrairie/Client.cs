using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Client
    {
        private string prenom;
        private string nom;
        private string adresse;
        private string codePostal;
        private string noTelephone;
        public string numeroClient;
        public static int compteurClient = 0;
        public List<Compte> listeDeCompte = new List<Compte>();


        public Client()
        {

        }

        /// <summary>
        /// Donne un numero de 4 chiffres au client
        /// </summary>
        /// <returns>string du numero</returns>
        public static string GetNumeroDuClient()
        {
            return (++compteurClient).ToString("D3");
        }

        /// <summary>
        /// Information de base pour identifier le client
        /// </summary>
        /// <param name="prenom">prenom du client</param>
        /// <param name="nom">nom du client</param>
        /// <param name="adresse">adresse du client</param>
        /// <param name="noTelephone">numero de téléphone du client</param>
        /// <param name="codePostal">code postal du client</param>
        public Client(string prenom, string nom, string adresse, string noTelephone, string codePostal)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.Adresse = adresse;
            this.NoTelephone = noTelephone;
            this.CodePostal = codePostal;
            this.numeroClient = GetNumeroDuClient();
        }

        /// <summary>
        /// Ajoute un compte au client
        /// </summary>
        /// <param name="compte"></param>
        public void AjouterUnCompte(Compte compte)
        {
            listeDeCompte.Add(compte);
        }

        /// <summary>
        /// Reecherche un compte avec le numero de compte du client
        /// </summary>
        /// <param name="numeroCompte">numero de compte du client à 3 chiffres</param>
        public void RechercherUnCompte(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');

            foreach (Compte compte in listeDeCompte)
            {
                if (numero[2] == compte.NoCompte)
                {
                    _ = compte;
                }
            }
        }

        public string Prenom
        {
            get { return prenom; }
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

        public string NoTelephone
        {
            get { return noTelephone; }
            set { noTelephone = value; }
        }

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        public string NumeroClient
        {
            get { return numeroClient; }
        }
    }
}
