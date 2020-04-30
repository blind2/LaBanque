using System;

namespace BanqueLibrairie
{
    public class Compte : IComparable<Compte>
    {
        private string noCompte;
        private long montantActuel;
        private string typeCompte;
        private static int compteurCompte = 0;

        /// <summary>
        /// Donne un numero de compte a 3 chiffres
        /// </summary>
        /// <returns>le string du compteur</returns>
        public static string GetNumeroCompte()
        {
            return (++compteurCompte).ToString("D3");
        }

        public Compte()
        {

        }

        /// <summary>
        /// Information de base sur le compte
        /// </summary>
        /// <param name="typeCompte">Cheque ou epargne</param>
        public Compte(string typeCompte)
        {
            this.noCompte = GetNumeroCompte();
            //met le montant du compte à 0$ apres sa création
            this.MontantActuel = 0;
            this.TypeCompte = typeCompte;
        }

        /// <summary>
        /// Permet de voire le solde du compte
        /// </summary>
        /// <returns>le montant actuel du compte</returns>
        public long VoireLeSoldeDuCompte()
        {
            return montantActuel;
        }

        /// <summary>
        /// Permet de comparer le montant total de 2 compte different
        /// </summary>
        /// <param name="other">compte a comparer</param>
        /// <returns> retourne un int</returns>
        public int CompareTo(Compte other)
        {
            return montantActuel.CompareTo(other.montantActuel);
        }

        public string NoCompte
        {
            get { return noCompte; }
        }

        public long MontantActuel
        {
            get { return montantActuel; }
            set { montantActuel = value; }
        }

        /// <summary>
        /// Créer un compte banquaire de type cheque ou epargne. Par default il est de type cheque
        /// </summary>
        public string TypeCompte
        {
            get { return typeCompte; }
            set
            {
                if (value == "cheque" || value == "epargne")
                {
                    typeCompte = value;
                }
                else
                {
                    typeCompte = "Cheque";
                }
            }
        }
    }
}
