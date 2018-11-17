using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WinForms_MVPSupervisingController.Views
{
    public interface IRectangleView
    {
        string LengthText { get; set; }
        string WidthText { get; set; }
        string AreaText { get; set; }
    }
}
