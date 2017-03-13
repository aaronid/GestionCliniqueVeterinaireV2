using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class LigneFactureDAL : ICRUD<LigneFacture>
    {
        public bool Create(LigneFacture item)
        {
            throw new NotImplementedException();
        }

        public LigneFacture GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<LigneFacture> GetList()
        {
            throw new NotImplementedException();
        }

        public LigneFacture ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(LigneFacture item)
        {
            throw new NotImplementedException();
        }
    }
}
