using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FactureDAL : ICRUD<Facture>
    {
        public bool Create(Facture item)
        {
            throw new NotImplementedException();
        }

        public Facture GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Facture> GetList()
        {
            throw new NotImplementedException();
        }

        public Facture ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Facture item)
        {
            throw new NotImplementedException();
        }
    }
}
