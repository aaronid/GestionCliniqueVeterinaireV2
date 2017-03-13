using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RaceDAL : ICRUD<Race>
    {
        public bool Create(Race item)
        {
            throw new NotImplementedException();
        }

        public Race GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Race> GetList()
        {
            throw new NotImplementedException();
        }

        public Race ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Race item)
        {
            throw new NotImplementedException();
        }
    }
}
