using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.helpers
{
    public class User
    {

        public string GetClientNameById(int id)
        {
            using (var db = new Cantina())
            {
                var client = db.User
                    .Where(c => c.Id == id)
                    .FirstOrDefault();

                return client.Name;
            }
        }

        public string GetClientNameByNif(int nif)
        {
            using (var db = new Cantina())
            {
                var client = db.User
                    .Where(c => c.Nif == nif)
                    .FirstOrDefault();

                return client.Name;
            }
        }

        //public string GetClientTypeByNif(int nif)
        
    }
}
