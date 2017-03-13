using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClientDAL : ICRUD<Client>
    {
        public bool Create(Client item)
        {
            throw new NotImplementedException();
        }

        public Client GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetList()
        {
            throw new NotImplementedException();
        }

        public Client ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Client item)
        {
            throw new NotImplementedException();
        }
    }
}
