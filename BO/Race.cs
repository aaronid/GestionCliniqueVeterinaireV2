using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Race
    /// </summary>
    public class Race
    {
        public string NomRace { get; set; }

        public Race(string nomRace)
        {
            this.NomRace = nomRace;
        }
    }
}
