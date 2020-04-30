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
        /// Ajoute une succursale a la banque
        /// </summary>
        public void AjouterSuccursale(Succursale s)
        {
            listeDeSuccursale.Add(s);
        }

        /// <summary>
        /// Recherche une succursale de la banque
        /// </summary>
        /// <param name="numeroSuccursale">numero à 3 chiffres que contient la succursale</param>
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
