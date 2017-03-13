using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LigneConsultationDAL : ICRUD<LigneConsultation>
    {
        public bool Create(LigneConsultation item)
        {
            throw new NotImplementedException();
        }

        public LigneConsultation GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<LigneConsultation> GetList()
        {
            throw new NotImplementedException();
        }

        public LigneConsultation ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(LigneConsultation item)
        {
            throw new NotImplementedException();
        }
    }
}
