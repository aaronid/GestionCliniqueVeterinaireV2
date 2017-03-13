using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Veterinaire
    {
        #region Attributs et propriétés
        public Guid CodeVeto { get; set; }

        private string nomVeto;
        public string NomVeto
        {
            get { return nomVeto; }
            set
            {
                VerifierNom(value);
                nomVeto = value;
            }
        }

        private string motPasse;
        public string MotPasse
        {
            get { return motPasse; }
            set
            {
                VerifierMotPasse(value);
                motPasse = value;
            }
        }

        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public Veterinaire()
        {
            this.CodeVeto = Guid.NewGuid();

        }

        public Veterinaire(string nomVeto, string motPasse, int archive) : this()
        {
            this.NomVeto = nomVeto;
            this.MotPasse = motPasse;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return string.Format(this.NomVeto);
        }


        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion

        #region Contraintes Métier

        /// <summary>
        /// Vérifie si le mot de passe répond aux contraintes métier
        /// </summary>
        /// <param name="chaine"></param>
        public static void VerifierMotPasse(String chaine)
        {

            if (String.IsNullOrWhiteSpace(chaine))
            {
                throw new ApplicationException("Le mot de passe est obligatoire.");

            }
        }

        /// <summary>
        /// Vérifie si le nom répond aux contraintes métier
        /// </summary>
        /// <param name="chaine"></param>
        private void VerifierNom(string chaine)
        {
            if (string.IsNullOrEmpty(chaine))
            {
                throw new ApplicationException("Le nom est obligatoire.");
            }
            if (!Outils.OutilsString.IsLetter(chaine))
            {
                throw new ApplicationException("Le nom ne doit contenir que des lettres.");
            }
        }

        #endregion
    }
}
