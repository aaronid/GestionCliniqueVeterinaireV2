using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Client
    /// </summary>
    public class Client
    {
        #region Attributs et Propriétés
        public Guid CodeClient { get; set; }

        private string nomClient;
        public string NomClient

        {
            get { return nomClient; }
            set
            {
                VerifierChaineNull(value);
                VerifierChaineIsLetter(value);
                nomClient = value;
            }
        }

        private string prenomClient;
        public string PrenomClient
        {
            get { return prenomClient; }
            set
            {
                VerifierChaineNull(value);
                VerifierChaineIsLetter(value);
                prenomClient = value;
            }
        }

        private string adresse1;
        public string Adresse1
        {
            get { return adresse1; }
            set
            {
                VerifierChaineNull(value);
                adresse1 = value;
            }
        }

        public string Adresse2 { get; set; }

        private string codePostal;
        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                VerifierChaineNull(value);
                VerifierCodePostal(value);
                codePostal = value;
            }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set
            {
                VerifierChaineNull(value);
                VerifierChaineIsLetter(value);
                ville = value;
            }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set
            {
                VerifierChaineNull(value);
                VerifierTelephone(value);
                telephone = value;
            }
        }

        public string Assurance { get; set; }

        private string email;
        public string Email

        {
            get { return email; }
            set { email = value; }
        }

        public string Remarque { get; set; }

        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public Client()
        {
            this.CodeClient = new Guid();
        }

        public Client(string nom, string prenom, string adresse1, string adresse2, string cp, string ville, string tel, string assurance, string email, string remarque, int archive) :this()
        {
            this.NomClient = nomClient;
            this.PrenomClient = prenomClient;
            this.Adresse1 = adresse1;
            this.Adresse2 = adresse2;
            this.CodePostal = cp;
            this.Ville = ville;
            this.Telephone = tel;
            this.Assurance = assurance;
            this.Email = email;
            this.Remarque = remarque;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }

        public override string ToString()
        {
            return NomClient + " " + PrenomClient;
        }
        #endregion

        #region Contraintes métiers
        /// <summary>
        /// Vérifie si le téléphone répond aux contraintes métiers
        /// doit contenir 14 caractères
        /// </summary>
        /// <param name="tel"></param>
        public void VerifierTelephone(string tel)
        {
            if(tel.Length > 14 || tel.Length < 14)
            {
                throw new ApplicationException("Numéro de téléphone non valide. \n Format attendu : ##.##.##.##.##");
            }
        }

        /// <summary>
        /// Vérifie si le nom, le prénom et la ville répondent aux contraintes métiers
        /// doivent être composés uniquement de lettres
        /// </summary>
        /// <param name="chaine"></param>
        public void VerifierChaineIsLetter(string chaine)
        {
            if (!Outils.OutilsString.IsLetter(chaine))
            {
                throw new ApplicationException("Le nom et le prénom ne doivent pas comporter de caractères spéciaux ou de chiffres.");
            }
        }

        /// <summary>
        /// Vérifie si le code postal répond aux contraintes métiers
        /// doit contenir 5 caractères
        /// doit être composé uniquement de chiffres
        /// </summary>
        /// <param name="chaine"></param>
        public void VerifierCodePostal(string chaine)
        {
            if (!Outils.OutilsString.isDigit(chaine))
            {
                throw new ApplicationException("Le code postal ne doit comporter que des chiffres.");
            }

            if (chaine.Length > 5 || chaine.Length < 5)
            {
                throw new ApplicationException("Le code postal ne doit contenir que 5 chiffres.");
            }
        }

        /// <summary>
        /// Vérifie si une chaîne de caractère est null ou vide
        /// </summary>
        /// <param name="chaine"></param>
        public void VerifierChaineNull(string chaine)
        {
            if (Outils.OutilsString.VerifierChaineNull(chaine))
            {
                throw new ApplicationException(" doit être renseigné.");
            }
        }

        /// <summary>
        /// Vérifie la validité du format d'une adresse mail
        /// </summary>
        /// <param name="chaine"></param>
        public void VerifierValiditeEmail(string chaine)
        {
            if (!Outils.OutilsString.IsValidEmail(chaine))
            {
                throw new ApplicationException("L'adresse mail saisie n'est pas valide.");
            }
        }
        #endregion
    }
}
