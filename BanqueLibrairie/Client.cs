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

        public Client()
        {

        }

        /// <summary>
        /// Information de base pour rejoindre le client
        /// </summary>
        /// <param name="prenom">prenom du client</param>
        /// <param name="nom">nom de famille du client</param>
        /// <param name="adresse">adresse du client</param>
        /// <param name="noTelephone">numéro de téléphone du client</param>
        /// <param name="codePostal">Le code postal doit etre de 6 caracteres</param>
        public Client(string prenom, string nom, string adresse, string noTelephone, string codePostal)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.Adresse = adresse;
            this.NoTelephone = noTelephone;
            this.CodePostal = codePostal;           
        }

        /// <summary>
        /// Ajoute un compte au client
        /// </summary>
        /// <param name="c">nom du compte</param>
        public void AjouterCompte(Compte c)
        {           
            List<Compte> listeCompte = new List<Compte>();
            foreach (Compte compte in listeCompte)
            {
                listeCompte.Add(c);
                
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
            set { codePostal= value; }
        }
    }
}
