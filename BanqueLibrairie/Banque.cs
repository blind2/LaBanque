using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Banque
    {
        private string nom;
        private string noInstitution;
        List<Succursale> listeDeSuccursale = new List<Succursale>();
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
        /// Ajoute une succursale a la banque
        /// </summary>
        public void AjouterSuccursale(Succursale s)
        {
            listeDeSuccursale.Add(s);
        }

        public void RechercherUneSuccursale(string numeroSuccursale)
        {
            string[] numero = numeroSuccursale.Split('-');

            if (numero[0] == this.NoInstitution)
            {
                foreach (Succursale succursale in listeDeSuccursale)
                {
                    if (numero[1] == succursale.NoSuccursale)
                    {
                        _ = succursale;
                    }
                }
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

       
        public void DeposerDans(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');

            if (numero[0] == this.NoInstitution)
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
