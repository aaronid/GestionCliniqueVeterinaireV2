using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Facture
    /// </summary>
    public class Facture
    {
        #region Attributs et propriétés
        public Guid NumFacture { get; set; }
        public DateTime DateFacture { get; set; }
        public Client CodeClient { get; set; }
        public double TotalFacture { get; set; }
        public int Archive { get; set; }
        /// <summary>
        /// 0 (facture à imprimer)
        /// 1 (facture imprimée)
        /// 2 (facture payée)
        /// </summary>
        public int Etat { get; set; }
        /// <summary>
        /// A la création de la facture, la date de rappel est initialisée à la date de création
        /// </summary>
        public DateTime RappelEnvoye { get; set; }
        #endregion

        #region Constructeurs

        public Facture()
        {
            this.NumFacture = new Guid();
        }

        public Facture(DateTime dateFacture, Client client, double totalFacture, int archive, int etat, DateTime rappelFacture = new DateTime()) : this()
        {
            this.DateFacture = dateFacture;
            this.CodeClient = client;
            this.TotalFacture = totalFacture;
            this.Archive = archive;
            this.Etat = etat;
            this.RappelEnvoye = rappelFacture;
        }

        #endregion

        #region Méthode redéfinies
        public override string ToString()
        {
            return String.Format("Client n°{0} , Facture n°{1} - Etablie le {2}, état : {3} - Montant total : {4} - Dernier rappel : {5}",
                                    this.CodeClient.CodeClient,
                                    this.NumFacture,
                                    this.DateFacture.ToString(),
                                    this.Etat,
                                    this.TotalFacture,
                                    this.RappelEnvoye);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        #endregion
    }
}
