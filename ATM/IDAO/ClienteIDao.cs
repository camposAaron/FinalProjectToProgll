using ATM.POJO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.IDAO
{
    interface ClienteIDao : IDao<Cliente>
    {
        List<Cliente> FindById(String id);
    }
}
