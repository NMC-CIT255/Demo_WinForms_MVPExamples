using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_WinForms_MVPExamples.Models;
using Demo_WinForms_MVPExamples.Views;

namespace Demo_WinForms_MVPExamples.Presenters
{
    public class RectanglePresenter
    {
        IRectangle _rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            _rectangleView = view;
        } 

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Length = double.Parse(_rectangleView.LengthText);
            rectangle.Width = double.Parse(_rectangleView.WidthText);

            _rectangleView.AreaText = (rectangle.Length * rectangle.Width).ToString();
        }
    }
}
