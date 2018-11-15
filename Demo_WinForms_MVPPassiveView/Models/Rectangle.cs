using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WinForms_MVPExamples.Models
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Length * Width;
        }
    }
}
