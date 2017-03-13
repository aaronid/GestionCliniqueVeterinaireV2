using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SecretaireDAL : ICRUD<Secretaire>
    {
        public bool Create(Secretaire item)
        {
            throw new NotImplementedException();
        }

        public Secretaire GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Secretaire> GetList()
        {
            throw new NotImplementedException();
        }

        public Secretaire ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Secretaire item)
        {
            throw new NotImplementedException();
        }
    }
}
