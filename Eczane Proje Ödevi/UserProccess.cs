using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal class UserProccess : PharmacyCrud<User>
    {
        public bool Add(User obj)
        {
            try
            {
                DbContext.UserList.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Detail(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            throw new NotImplementedException();
        }
    }
}
