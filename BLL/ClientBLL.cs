using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientBLL
    {
        public bool Create(string nom, string prenom, string adresse1, string adresse2, string cp, string ville, string tel, string assurance, string email, string remarque, int archive)
        {
            return new ClientDAL().Create(new Client(nom, prenom, adresse1, adresse2, cp, ville, tel, assurance, email, remarque, archive));
        }

        public Client GetById(Guid identifiant)
        {
            return new ClientDAL().GetById(identifiant);
        }

        public List<Client> GetList()
        {
            return new ClientDAL().GetList();
        }

        public bool Update(string nom, string prenom, string adresse1, string adresse2, string cp, string ville, string tel, string assurance, string email, string remarque, int archive)
        {
            return new ClientDAL().Update(new Client(nom, prenom, adresse1, adresse2, cp, ville, tel, assurance, email, remarque, archive));
        }
    }
}
