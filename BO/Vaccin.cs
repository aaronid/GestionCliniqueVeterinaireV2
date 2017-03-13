using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Vaccin
    /// </summary>
    public class Vaccin
    {
        #region Attributs et Propriétés 
        public Guid CodeVaccin { get; set; }
        public string NomVaccin { get; set; }
        public int QuantiteStock { get; set; }
        public int PeriodeValidite { get; set; }
        public int Archive { get; set; }
        #endregion

        #region Constructeurs
        public Vaccin()
        {
            this.CodeVaccin = new Guid();
        }

        public Vaccin(string nom, int qte, int validite, int archive) : this()
        {
            this.NomVaccin = nom;
            this.PeriodeValidite = validite;
            this.QuantiteStock = qte;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes redéfinies
        public override string ToString()
        {
            return this.CodeVaccin + " " + this.NomVaccin;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion
    }
}
