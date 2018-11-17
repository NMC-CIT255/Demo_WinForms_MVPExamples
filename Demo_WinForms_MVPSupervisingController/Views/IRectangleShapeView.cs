using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_WinForms_MVPSupervisingController.Models;

namespace Demo_WinForms_MVPSupervisingController.Views
{
    public interface IRectangleShapeView
    {
        RectangleShape RectangleShape { get; set; }

        event EventHandler CalculateAreaPressed;
    }
}
