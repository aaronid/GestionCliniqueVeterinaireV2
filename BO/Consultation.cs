using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Consultation
    /// </summary>
    public class Consultation
    {
        #region Attributs et propriétés
        public Guid CodeConsultation { get; set; }
        public DateTime DateConsultation { get; set; }
        public Veterinaire Veterinaire { get; set; }
        public Guid CodeVeto { get; set; }
        public Animal Animal { get; set; }
        public Guid CodeAnimal { get; set; }
        public string Commentaire { get; set; }
        public int Etat { get; set; }
        public Facture Facture { get; set; }
        public Guid NumFacture { get; set; }
        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public Consultation()
        {
            this.CodeConsultation = Guid.NewGuid();
        }
        public Consultation(DateTime dateConsultation, Veterinaire veto, Animal animal, string commentaire, int etat, Facture facture, int archive) : this()
        {
            this.DateConsultation = dateConsultation;
            this.Veterinaire = veto;
            this.CodeVeto = veto.CodeVeto;
            this.Animal = animal;
            this.CodeAnimal = animal.CodeAnimal;
            this.Commentaire = commentaire;
            this.Etat = etat;
            this.Facture = facture;
            this.NumFacture = facture.NumFacture;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return this.CodeConsultation.ToString(); 
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion
    }
}
