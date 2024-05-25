using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.helpers
{
    public static class Validator
    {
        public static bool IsUsernameValid(string username)
        {
            string regEx = @"^[a-zA-Z0-9_]{3,64}$";
            return System.Text.RegularExpressions.Regex.IsMatch(username, regEx);
        }
    }
}
