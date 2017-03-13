using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Agenda
    {
        #region Attributs et Propriétés
        public Guid CodeRdv { get; set; }
        public Veterinaire Veterinaire { get; set; }
        public Animal Animal { get; set; }
        public string NomAnimal { get; set; }
        public string NomClient { get; set; }
        public string RaceAnimal { get; set; }
        public DateTime DateRDV { get; set; }
        #endregion

        #region Constructeurs
        public Agenda()
        {
            this.CodeRdv = new Guid();
        }

        public Agenda(Veterinaire veterinaire, Animal animal, DateTime dateRDV) : this()
        {
            this.Veterinaire = veterinaire;
            this.Animal = animal;
            this.DateRDV = dateRDV;
            this.NomClient = animal.Client.NomClient + " " + animal.Client.PrenomClient;
            this.NomAnimal = animal.NomAnimal;
            this.RaceAnimal = animal.Race.NomRace;
        }
        #endregion

        #region Méthodes redéfinies
        public override bool Equals(object obj)
        {
            return (obj != null && obj is Agenda);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",
                                this.DateRDV,
                                this.NomClient,
                                this.NomAnimal,
                                this.RaceAnimal);
        }
        #endregion
    }
}
