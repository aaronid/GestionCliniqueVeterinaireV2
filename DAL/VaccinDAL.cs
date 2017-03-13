using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class VaccinDAL : ICRUD<Vaccin>
    {
        public bool Create(Vaccin item)
        {
            throw new NotImplementedException();
        }

        public Vaccin GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Vaccin> GetList()
        {
            throw new NotImplementedException();
        }

        public Vaccin ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Vaccin item)
        {
            throw new NotImplementedException();
        }
    }
}
