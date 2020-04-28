using System;
using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Banque
    {
        private string nom;
        private string noInstitution;
        Compte compte = new Compte();
        
        public Banque()
        {

        }

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
        /// Ajoute une succursale a la banque
        /// </summary>
        public void AjouterSuccursale(Succursale s)
        {
            List<Succursale> listeDeSuccursale = new List<Succursale>();
            
            foreach (Succursale succursale in listeDeSuccursale)
            {
                listeDeSuccursale.Add(s);
            }      
        }

        /// <summary>
        /// Dépose de l'argent dans le compte du client
        /// </summary>
        /// <param name="c">le compte du client</param>
        /// <param name="montant"> le montant a ajouter au solde</param>
        public void DeposerArgent(Compte c, long montant)
        {
            compte = c;
            long nouveauMontant = c.MontantActuel + montant;
            c.MontantActuel = nouveauMontant;
           
        }

        /// <summary>
        /// Retire de l'argent du compte du client
        /// </summary>
        /// <param name="c">le compte du client</param>
        /// <param name="montant"> montant a soustraire du solde</param>
        public void RetirerArgent(Compte c, long montant)
        {
            compte = c;
            long nouveauMontant = c.MontantActuel - montant;
            c.MontantActuel = nouveauMontant;
        }

        /// <summary>
        /// Recherche un client grace a son numéro de compte 
        /// </summary>
        /// <param name="numeroCompte">numero de compte du client</param>
        public void RechercherCompte(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');
           
            if (numero[0]==NoInstitution && numero[2]==compte.NoCompte)
            {

            }
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
