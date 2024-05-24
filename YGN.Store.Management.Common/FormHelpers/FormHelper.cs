using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace YGN.Store.Management.Common.FormHelpers
{
    public class FormHelper
    {
        public static void ShowForm<T>() where T : Form, new()
        {
            bool formIsOpen = Application.OpenForms.OfType<T>().Any();

            if (!formIsOpen)
            {
                T form = new T();
                form.Show();
            }
        }
        public static void ShowParametricForm<T>(params object[] args) where T : Form
        {
            bool formIsOpen = Application.OpenForms.OfType<T>().Any();

            if (!formIsOpen)
            {
                T form;
                if (args != null && args.Length > 0)
                {
                    form = (T)Activator.CreateInstance(typeof(T), args);
                }
                else
                {
                    throw new ArgumentException("Parametreli form açmak için geçerli parametreler sağlanmalıdır.");
                }

                form.Show();
            }
        }
    }
}
