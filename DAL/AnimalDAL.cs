using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnimalDAL : ICRUD<Animal>
    {
        public bool Create(Animal item)
        {
            throw new NotImplementedException();
        }

        public Animal GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetList()
        {
            throw new NotImplementedException();
        }

        public Animal ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Animal item)
        {
            throw new NotImplementedException();
        }
    }
}
