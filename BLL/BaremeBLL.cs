using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaremeBLL
    {
        public bool Create(Bareme item)
        {
            return new BaremeDAL().Create(item);
        }

        public Bareme GetById(Guid identifiant)
        {
            return new BaremeDAL().GetById(identifiant);
        }

        public List<Bareme> GetList()
        {
            return new BaremeDAL().GetList();
        }

        public bool Update(Bareme item)
        {
            return new BaremeDAL().Update(item);
        }
    }
}
