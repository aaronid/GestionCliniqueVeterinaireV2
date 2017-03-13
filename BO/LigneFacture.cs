using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LigneFacture
    {
        #region Attributs et Propriétés
        public Facture Facture { get; set; }
        public Guid NumFacture { get; set; }
        public int NumLigne { get; set; }
        public Bareme Bareme { get; set; }
        public string CodeGroupement { get; set; }
        public decimal Prix { get; set; }
        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public LigneFacture() { }

        public LigneFacture(Facture facture, int numligne, Bareme bareme, decimal prix, int archive)
        {
            this.Facture = facture;
            this.NumFacture = facture.NumFacture;
            this.NumLigne = numligne;
            this.Bareme = bareme;
            this.CodeGroupement = bareme.CodeGroupement; 
            this.Prix = prix;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return this.NumFacture + " " + this.NumLigne;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion
    }
}
