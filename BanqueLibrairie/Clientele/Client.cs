using System.Collections.Generic;

namespace BanqueLibrairie.Clientele
{
    public abstract class Client
    {
        private string prenom;
        private string nom;
        private string adresse;
        private string codePostal;
        private string noTelephone;
        public string numeroClient;
        public static int compteurClient = 0;
        private List<Compte> listeDeCompte = new List<Compte>();

        /// <summary>
        /// Donne un numero de 3 chiffres au client
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
        /// Supprime un compte
        /// </summary>
        /// <param name="compte">compte a supprimer</param>
        public void SupprimerUnCompte(Compte compte)
        {
            listeDeCompte.Remove(compte);
        }

        /// <summary>
        /// Dépose un montant dans le compte
        /// </summary>
        /// <param name="numeroCompte">numéro de compte/param>
        /// <param name="montant">montant à déposée</param>
        /// <returns>retourne le solde du compte ou 0 s'il n'a pas trouvée de compte</returns>
        public long DeposerDans(string numeroCompte, long montant)
        {
            string[] numero = numeroCompte.Split('-');
            foreach (Compte compte in this.listeDeCompte)
            {
                if (numero[2] == compte.NoCompte)
                {
                    compte.Deposer(montant);
                }
            }
            return 0;
        }

        /// <summary>
        /// Retire le montant dans le compte 
        /// </summary>
        /// <param name="numeroCompte">numéro de compte</param>
        /// <param name="montant">montant a retirer</param>
        /// <returns>retourne le solde du compte ou 0 s'il n'a pas trouvée de compte</returns>
        public long RetirerDans(string numeroCompte, long montant)
        {
            string[] numero = numeroCompte.Split('-');
            foreach (Compte compte in this.listeDeCompte)
            {
                if (numero[2] == compte.NoCompte)
                {
                    compte.Retirer(montant);
                }
            }
            return 0;
        }

        /// <summary>
        /// Permet de voir le solde du compte
        /// </summary>
        /// <param name="numeroCompte">numéro de compte/param>
        /// <returns>retourne le montant du compte ou 0 si le compte n'a pas été trouvée</returns>
        public long VoireLeSoldeDuCompte(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');
            foreach (Compte item in this.listeDeCompte)
            {
                if (numero[2] == item.NoCompte)
                {
                    return item.MontantActuel;
                }
            }
            return 0;
        }

        /// <summary>
        /// Trouve un compte avec un numéro de compte
        /// </summary>
        /// <param name="numeroCompte">numero de compte</param>
        /// <returns>retourne un compte ou null si le compte n'a pas été trouvée</returns>
        public Compte TrouverUnCompte(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');
            if (numero[3] == this.numeroClient)
            {
                foreach (Compte compte in listeDeCompte)
                {
                    if (numero[2] == compte.NoCompte)
                    {
                        return compte;
                    }
                }
            }
            return null;
        }

        public abstract void PrendreUnRendezVous();
        
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
