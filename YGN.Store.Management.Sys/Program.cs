using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Sys.MainForms;

namespace YGN.Store.Management.Sys
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


            Application.Run(new MainForm());

            //CreateDatabaseManager createDatabaseManager = new CreateDatabaseManager(new EfCreateDatabaseDal());

            //var dbConfig = createDatabaseManager.CreateDatabase();
            //if (dbConfig.Status)
            //{
            //    //MessageBox.Show(dbConfig.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Application.Run(new MainForm());
            //}
            //else
            //{
            //    //MessageBox.Show(dbConfig.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Run(new MainForm());
            //}

           // Application.Run(new MainForm());
        }
    }
}
