using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Banque
    {
        private string nom;
        private string noInstitution;
        private List<Succursale> listeDeSuccursale = new List<Succursale>();
        Compte compte = new Compte();
        

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
            
            string[] numero = numeroCompte.Split('-');
            foreach (Compte item in c.ListDeCompte )
            {
                if (numero[2] == item.NoCompte)
                {
                    return true;
                }
            }
            return false;
        }
      
        public long Deposer(long montant)
        {
        
            long nouveauMontant = compte.MontantActuel + montant;
            nouveauMontant = compte.MontantActuel;
            return nouveauMontant;
        }
       
        public long Retirer(string numeroCompte, long montant)
        {
            return 0;
            
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
