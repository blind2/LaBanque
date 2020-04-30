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

       
        public void DeposerDans(long montant)
        {
           
        }
        public void RetirerDans()
        {

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
