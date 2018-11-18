using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_WinForms_MVPSupervisingController.Models;
using Demo_WinForms_MVPSupervisingController.Presenters;


namespace Demo_WinForms_MVPSupervisingController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RectangleShapePresenter rectangleShapePresenter = new RectangleShapePresenter();
        }
    }
}
