using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Bareme
    /// </summary>
    public class Bareme
    {
        #region Attributs et Propriétés
        public string CodeGroupement { get; set; }
        public string DateVigueur { get; set; }
        private string typeActe;
        public string TypeActe { get; set; }
        public string Libelle { get; set; }
        public decimal TarifFixe { get; set; }
        public decimal TarifMini { get; set; }
        public decimal TarifMaxi { get; set; }
        public Vaccin Vaccin { get; set; }
        public Guid CodeVaccin { get; set; }
        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public Bareme() { }

        public Bareme(string codeRegroupement, string dateVigueur, string typeActe, string libelle, decimal tarifFixe, decimal tarifMini, decimal tarifMaxi, Vaccin vaccin, int archive)
        {
            this.CodeGroupement = codeRegroupement;
            this.DateVigueur = dateVigueur;
            this.TypeActe = typeActe;
            this.Libelle = libelle;
            this.TarifFixe = tarifFixe;
            this.TarifMini = tarifMini;
            this.TarifMaxi = tarifMaxi;
            this.Vaccin = vaccin;
            this.CodeVaccin = vaccin.CodeVaccin;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return this.CodeGroupement + " " + this.TypeActe;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion
    }
}
