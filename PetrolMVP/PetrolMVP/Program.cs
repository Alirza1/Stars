using PetrolMVP.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolMVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var view = new MainView();
            var presenter = new MainPresenter(view);
            Application.Run(new MainView());
        }
    }
}
