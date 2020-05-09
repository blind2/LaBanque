using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueLibrairie.Clientele
{
    public class PersonneAgee : Client
    {
        private int age;

        public PersonneAgee(string prenom, string nom, string adresse, string noTelephone, string codePostal) : base(prenom, nom, adresse, noTelephone, codePostal)
        {

        }

        public override void PrendreUnRendezVous()
        {
            throw new NotImplementedException();
        }
        public virtual void DemandeRenteDeRetraite()
        {

        }
    }
}
