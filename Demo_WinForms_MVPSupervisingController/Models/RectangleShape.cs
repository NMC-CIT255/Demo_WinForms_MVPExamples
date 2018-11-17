using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WinForms_MVPSupervisingController.Models
{
    public class RectangleShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }

        public void CalculateArea()
        {
            Area = Length * Width;
        }
    }
}
