using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICRUD<T> where T : class
    {

        T GetItem(int id);

        List<T> GetItems();

        List<T> GetAll();

        int AddNew(T item);

        int Delete(int id);

        int Update(T item);

        

    }
}
