using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class EspeceDAL : ICRUD<Espece>
    {
        public bool Create(Espece item)
        {
            throw new NotImplementedException();
        }

        public Espece GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Espece> GetList()
        {
            throw new NotImplementedException();
        }

        public Espece ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Espece item)
        {
            throw new NotImplementedException();
        }
    }
}
