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
        IRectangleView _rectangleView;

        public RectanglePresenter(IRectangleView view)
        {
            _rectangleView = view;
        } 

        public void CalculateArea()
        {
            RectangleShape rectangle = new RectangleShape();

            rectangle.Length = double.Parse(_rectangleView.LengthText);
            rectangle.Width = double.Parse(_rectangleView.WidthText);

            _rectangleView.AreaText = (rectangle.Length * rectangle.Width).ToString();
        }
    }
}
