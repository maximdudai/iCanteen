using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public static bool IsValidEmail(string email)
        {
            MailAddress emailInput = new MailAddress(email);
            
            return emailInput.Address == email;          
        }

        public static bool IsValidClientNifSearch(string nif)
        {
            if (string.IsNullOrEmpty(nif))
            {
                Error.Err("ClientNif cannot be empty!");
                return false;
            }

            if (nif.Length != 9)
            {
                Error.Err("NIF must have 9 digits!");
                return false;
            }
            return true;
        }
    }
}
