using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConsultationDAL : ICRUD<Consultation>
    {
        public bool Create(Consultation item)
        {
            throw new NotImplementedException();
        }

        public Consultation GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> GetList()
        {
            throw new NotImplementedException();
        }

        public Consultation ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Consultation item)
        {
            throw new NotImplementedException();
        }
    }
}
