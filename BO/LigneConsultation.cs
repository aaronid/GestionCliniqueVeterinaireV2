using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet LigneConsultation
    /// </summary>
    public class LigneConsultation
    {
        #region Attributs et propriétés
        public Consultation Consultation { get; set; }
        public Guid NumLigne { get; set; }
        public Bareme Bareme { get; set; }
        public Guid CodeConsultation { get; set; }
        public string CodeGroupement { get; set; }
        public string DateVigueur { get; set; }
        public decimal Prix { get; set; }
        public int Rappel { get; set; }
        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public LigneConsultation()
        {
            this.NumLigne = new Guid();
        }          

        public LigneConsultation(Consultation consultation, Bareme bareme, string dateVigueur, decimal prix, int rappelEnvoye, int archive) : this()
        {
            this.Consultation = consultation;
            this.CodeConsultation = consultation.CodeConsultation;
            this.CodeGroupement = bareme.CodeGroupement;
            this.Bareme = bareme;
            this.DateVigueur = dateVigueur;
            this.Prix = prix;
            this.Rappel = rappelEnvoye;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return this.CodeConsultation + " " + this.NumLigne;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion
    }
}
