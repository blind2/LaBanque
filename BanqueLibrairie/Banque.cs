using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Banque
    {
        private string nom;
        private string noInstitution;
        private List<Succursale> listeDeSuccursale = new List<Succursale>();
        string numeroCompteVerifier;
        Compte compte = new Compte();
        Client client = new Client();
        

        /// <summary>
        /// Information de base de la banque
        /// </summary>
        /// <param name="nom">nom de la banque</param>
        public Banque(string nom, string noInstitution)
        {
            this.nom = nom;
            this.noInstitution = noInstitution;
        }

        /// <summary>
        /// Supprime une succursale de la banque
        /// </summary>
        /// <param name="s">succursale a supprimer</param>
        public void SupprimerUneSuccursale(Succursale s)
        {
            listeDeSuccursale.Remove(s);
        }

        /// <summary>
        /// Ajoute une succursale a la banque
        /// </summary>
        public void AjouterUneSuccursale(Succursale s)
        {
            listeDeSuccursale.Add(s);
        }

        /// <summary>
        /// Rechercher un compte avec un numéro de compte
        /// </summary>
        /// <param name="numeroCompte">numero a 9 chiffres</param>
        /// <param name="c">le client</param>
        /// <returns>retourne vrai ou faux s'il a trouvée un compte</returns>
        public bool TrouverUnCompte(Client c, string numeroCompte)
        {
            client = c;
            numeroCompteVerifier = numeroCompte;
            string[] numero = numeroCompte.Split('-');
            foreach (Compte item in c.ListDeCompte )
            {
                if (numero[2] == item.NoCompte)
                {
                    compte = item;
                    return true;
                    
                }
            }
            return false;
        }

        /// <summary>
        /// Dépose de l'argent dans un compte
        /// </summary>
        /// <param name="montant">montant a déposer</param>
        /// <returns>le solde du compte</returns>
        public long Deposer(long montant)
        {
            if (TrouverUnCompte(client,numeroCompteVerifier)==true)
            {
                compte.MontantActuel += montant;
                return compte.MontantActuel;               
            }
            return compte.MontantActuel;            
        }

        /// <summary>
        /// Retire de l'argent dans un compte
        /// </summary>
        /// <param name="montant">montant à retirer</param>
        /// <returns>le solde du compte</returns>
        public long Retirer(long montant)
        {
            if (TrouverUnCompte(client, numeroCompteVerifier) == true)
            {
                compte.MontantActuel -= montant;
                return compte.MontantActuel;
            }
            return compte.MontantActuel;
        }

        /// <summary>
        /// Recherche une succursale de la banque
        /// </summary>
        /// <param name="numeroSuccursale">numero à 3 chiffres que contient la succursale</param>
        public Succursale RechercherUneSuccursale(string numeroSuccursale)
        {
            string[] numero = numeroSuccursale.Split('-');

            if (numero[0] == this.NoInstitution)
            {
                foreach (Succursale succursale in listeDeSuccursale)
                {
                    if (numero[1] == succursale.NoSuccursale)
                    {
                        return succursale;
                    }
                }
            }
            return null;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string NoInstitution
        {
            get { return noInstitution; }
        }
    }
}
