using System;
using System.Collections.Generic;
using System.Text;

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
        /// <param name="compte">compte du client</param>
        public void AjouterUncompte(Compte compte)
        {
            List<Compte> listeDeCompte = new List<Compte>();
            listeDeCompte.Add(compte);
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
            set { codePostal= value; }
        }

        public string NumeroClient
        {
            get { return numeroClient; }            
        }
    }
}
