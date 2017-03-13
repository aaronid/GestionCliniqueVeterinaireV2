using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class VeterinaireDAL : ICRUD<Veterinaire>
    {
        public bool Create(Veterinaire item)
        {
            throw new NotImplementedException();
        }

        public Veterinaire GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Veterinaire> GetList()
        {
            throw new NotImplementedException();
        }

        public Veterinaire ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Veterinaire item)
        {
            throw new NotImplementedException();
        }
    }
}
