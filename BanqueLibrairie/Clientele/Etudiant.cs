using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BanqueLibrairie
{
    public class Etudiant : Client
    {       
        public Etudiant(string prenom, string nom, string adresse, string noTelephone, string codePostal) : base(prenom, nom, adresse, noTelephone, codePostal)
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
        /// Fait un pret a la Banque
        /// </summary>
        /// <param name="numeroCompte">numero de compte de l'étudiant</param>
        /// <param name="montant">montant du pret</param>
        public virtual void FaireUnPretEtudiant(string numeroCompte, long montant)
        {
            base.DeposerDans(numeroCompte, montant);
        }
    }
}
