using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_WinForms_MVPExamples.Models;

namespace Demo_WinForms_MVPExamples.Views
{
    public interface IRectangleView
    {
        RectangleShape Rectangle { get; set; }
    }
}
