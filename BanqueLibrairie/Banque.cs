using System.Collections.Generic;

namespace BanqueLibrairie
{
    public class Banque 
    {
        private string nom;
        private string noInstitution;
        private List<Succursale> listeDeSuccursale = new List<Succursale>();

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
        /// Trouve un compte avec un numéro de compte
        /// </summary>
        /// <param name="numeroCompte">numero de compte</param>
        /// <returns>retourne un compte ou null s'il ne trouve pas de compte</returns>
        public Compte TrouverUnCompte(string numeroCompte)
        {
            string[] numero = numeroCompte.Split('-');

            if (numero[0] == this.noInstitution)
            {
                foreach (Succursale succursale in listeDeSuccursale)
                {
                    if (numero[1] == succursale.NoSuccursale)
                    {
                        succursale.TrouverUnClient(numeroCompte);
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Dépose un montant dans un compte
        /// </summary>
        /// <param name="numeroCompte">numéro de compte</param>
        /// <param name="montant">montant à déposer</param>
        /// <returns>retourne le solde du compte ou 0 s'il ne trouve pas de compte</returns>
        public long DeposerDans(string numeroCompte, long montant)
        {
            string[] numero = numeroCompte.Split('-');
            if (numero[0] == noInstitution)
            {
                foreach (Succursale succursale in listeDeSuccursale)
                {
                    if (numero[1] == succursale.NoSuccursale)
                    {
                        succursale.DeposerDans(numeroCompte, montant);
                    }
                }
            }
            return 0;
        }

        /// <summary>
        /// Retire un montant dans un compte
        /// </summary>
        /// <param name="numeroCompte">numéro de compte</param>
        /// <param name="montant">montant à retirer</param>
        /// <returns>retourne le solde ou 0 s'il ne trouve pas de compte</returns>
        public long RetirerDans(string numeroCompte, long montant)
        {
            string[] numero = numeroCompte.Split('-');
            if (numero[0] == noInstitution)
            {
                foreach (Succursale succursale in listeDeSuccursale)
                {
                    if (numero[1] == succursale.NoSuccursale)
                    {
                        succursale.RetirerDans(numeroCompte, montant);
                    }
                }
            }
            return 0;
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
