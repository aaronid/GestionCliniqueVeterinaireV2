using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICRUD<T>
    {
        bool Create(T item);
        bool Update(T item);
        T GetById(Guid identifiant);
        List<T> GetList();
        T ItemBuilder(SqlDataReader dr);
    }
}
