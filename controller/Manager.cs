using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSI_DA_PL_B.views.Auth.Login;
using PSI_DA_PL_B.views.Menu;

namespace PSI_DA_PL_B.controller
{
    internal class Manager
    {
        // Method to login
        // Login(true = will show);
        // Login(false = will hide);
        public void Login(bool toggle)
        {
            Login login = new Login();

            if (toggle)
            {
                login.Show();
            }
            else
            {
                login.Close();
            }
        }
        
        // MainMenu mainMenu = new MainMenu(true = will show the form, maxim);
        // MainMenu mainMenu = new MainMenu(false);
        public void MainMenu(bool toggle, string username = "")
        {
            MainMenu mainMenu = new MainMenu(username);
            if (toggle)
            {
                mainMenu.Show();
            }
            else
            {
                mainMenu.Close();
            }
        }
    }
}
