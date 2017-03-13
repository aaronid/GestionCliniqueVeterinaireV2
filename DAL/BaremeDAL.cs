using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class BaremeDAL : ICRUD<Bareme>
    {
        public bool Create(Bareme item)
        {
            throw new NotImplementedException();
        }

        public Bareme GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Bareme> GetList()
        {
            throw new NotImplementedException();
        }

        public Bareme ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Bareme item)
        {
            throw new NotImplementedException();
        }
    }
}
