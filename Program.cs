using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B;
using PSI_DA_PL_B.Migrations;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Login;
using PSI_DA_PL_B.views.Clients.Both;

namespace PSI_DA_PL_B
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListClients());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Cantina, Configuration>());

            using (var context = new Cantina())
            {
                // This will automatically apply any pending migrations
                context.Database.Initialize(force: true);
            }
        }
    }
}
