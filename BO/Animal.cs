using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Définie un objet Animal
    /// </summary>
    public class Animal
    {
        #region Attributs et Propriétés
        public Guid CodeAnimal { get; set; }

        private string tatouage;
        public string Tatouage
        {
            get { return tatouage; }
            set
            {
                VerifierTatouage(value);
                tatouage = value;
            }
        }

        private string nomAnimal;
        public string NomAnimal
        {
            get { return nomAnimal; }
            set
            {
                VerifierNomAnimal(value);
                nomAnimal = value;
            }
        }

        private string sexe;
        public string Sexe
        {
            get { return sexe; }
            set
            {
                VerifierSexe(value);
                sexe = value;
            }
        }

        public string  Couleur { get; set; }

        public Race Race { get; set; }
        public string NomRace { get; set; }

        public Espece Espece { get; set; }
        public string NomEspece { get; set; }

        public Client Client { get; set; }
        public Guid CodeClient { get; set; }

        public string Antecedents { get; set; }

        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public Animal()
        {
            this.CodeAnimal = new Guid();
        }

        public Animal(string nom, string tatouage, string couleur, string antecedents, string sexe, Race race, string nomRace, Espece espece, string nomEspece, Client client, Guid codeClient, int archive) : this()
        {
            this.Couleur = couleur;
            this.Espece = espece;
            this.Race = race;
            this.NomAnimal = nom;
            this.Sexe = sexe;
            this.Tatouage = tatouage;
            this.Antecedents = antecedents;
            this.Archive = Archive;
            this.Client = client;
            this.NomRace = nomRace;
            this.NomEspece = nomEspece;
            this.CodeClient = codeClient;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return this.NomAnimal;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion

        #region Contraintes métier
        private void VerifierNomAnimal(string chaine)
        {
            if (string.IsNullOrEmpty(chaine))
            {
                throw new ApplicationException("Le nom de l'animal est obligatoire.");
            }
        }

        private void VerifierSexe(string chaine)
        {
            if (string.IsNullOrEmpty(chaine) || chaine.Length > 1)
            {
                throw new ApplicationException("Saisissez le sexe de l'animal : F (Femelle) - M (Mâle) - H (Hermaphrodite)");
            }
        }

        private void VerifierTatouage(string chaine)
        {
            if (chaine.Length > 10)
            {
                throw new ApplicationException("Le tatouage doit comporter 10 caractères");
            }
        }
        #endregion
    }
}
