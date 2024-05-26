using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.DataAccess.DbInit;
using YGN.Store.Management.UI.Forms;

namespace YGN.Store.Management.UI
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

            //Database.SetInitializer(new YGNDbInitializer());

            //using (var context = new YGNContext())
            //{
            //    context.Database.Initialize(force: true);
            //}

            Application.Run(new LoginForm());

        }
    }
}
