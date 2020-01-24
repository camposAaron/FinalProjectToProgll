using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.IDAO
{
    interface IDao<T> 
    {
        void Save(T t);
        int Update(T t);
        List<T> FindAll();
        bool Delete(string numberAccount);

    }
}
