using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AnimalBLL
    {
        public bool Create(Animal item)
        {
            return new AnimalDAL().Create(item);
        }

        public Animal GetById(Guid identifiant)
        {
            return new AnimalDAL().GetById(identifiant);
        }

        public List<Animal> GetList()
        {
            return new AnimalDAL().GetList();
        }

        public bool Update(Animal item)
        {
            return new AnimalDAL().Update(item);
        }
    }
}
