using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Description d'un objet Espece
    /// </summary>
    public class Espece
    {
        public string NomEspece { get; set; }

        public Espece(string nomEspece)
        {
            this.NomEspece = nomEspece;
        }
    }
}
