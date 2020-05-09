using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueLibrairie.Clientele
{
    public class PersonneAgee : Client
    {        
        public PersonneAgee(string prenom, string nom, string adresse, string noTelephone, string codePostal) : base(prenom, nom, adresse, noTelephone, codePostal)
        {
            
        }

        /// <summary>
        /// Prend un Rendez-Vous avec la Banque
        /// </summary>
        public override void PrendreUnRendezVous()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verifie si la personne agée est admissible d'avoir sa rente de retraite
        /// </summary>
        /// <param name="age">age de la personne</param>
        /// <returns>retourne vrai si admisible et faux si pas admissible</returns>
        public virtual bool DemandeRenteDeRetraite(int age)
        {
            if (age >= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
