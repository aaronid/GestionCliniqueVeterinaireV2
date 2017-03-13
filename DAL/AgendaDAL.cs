using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgendaDAL : ICRUD<Agenda>
    {
        public bool Create(Agenda item)
        {
            throw new NotImplementedException();
        }

        public Agenda GetById(Guid identifiant)
        {
            throw new NotImplementedException();
        }

        public List<Agenda> GetList()
        {
            List<Agenda> listeRdv = new List<Agenda>();

            Veterinaire veto = new Veterinaire("DE CAJOU Benoît", "FLEUR", 0);
            Client client = new Client("FERRE", "Gwenaelle", "1 rue des marroniers", "1ère allée à gauche", "35131", "Pont-Péan", "07.50.20.33.13", "MAIF", "gwenaelleferre@yahoo.fr", "A 4 chats", 0);
            Animal animal = new Animal("Lilly", "FRTGHUIOP", "Blanche", "S'est coupé la queue", "F", new Race("de gouttière"),"de gouttière", new Espece("Chat"), "Chat", client, client.CodeClient,0);
            listeRdv.Add(new Agenda(veto, animal, new DateTime(2017,01,12)));

            return listeRdv;
        }

        public Agenda ItemBuilder(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public bool Update(Agenda item)
        {
            throw new NotImplementedException();
        }
    }
}
