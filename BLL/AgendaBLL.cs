using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgendaBLL
    {
        public bool Create(Agenda item)
        {
            return new AgendaDAL().Create(item);
        }

        public Agenda GetById(Guid identifiant)
        {
            return new AgendaDAL().GetById(identifiant);
        }

        public List<Agenda> GetList()
        {
            return new AgendaDAL().GetList();
        }

        public bool Update(Agenda item)
        {
            return new AgendaDAL().Update(item);
        }
    }
}
