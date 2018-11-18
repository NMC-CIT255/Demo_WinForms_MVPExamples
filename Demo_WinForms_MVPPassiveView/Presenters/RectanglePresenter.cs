using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_WinForms_MVPSupervisingController.Models;
using Demo_WinForms_MVPSupervisingController.Views;

namespace Demo_WinForms_MVPSupervisingController.Presenters
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
            Rectangle rectangle = new Rectangle();

            rectangle.Length = double.Parse(_rectangleView.LengthText);
            rectangle.Width = double.Parse(_rectangleView.WidthText);

            _rectangleView.AreaText = rectangle.Area().ToString();
        }
    }
}
