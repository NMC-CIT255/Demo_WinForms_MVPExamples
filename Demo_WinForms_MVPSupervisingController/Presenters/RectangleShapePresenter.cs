using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_WinForms_MVPSupervisingController.Models;
using Demo_WinForms_MVPSupervisingController.Views;

namespace Demo_WinForms_MVPSupervisingController.Presenters
{
    public class RectangleShapePresenter
    {
        RectangleShapeForm _rectangleShapeView;
        RectangleShape _rectangleShape;

        public RectangleShapePresenter()
        {
            IntializeApp();
        }

        private void IntializeApp()
        {
            _rectangleShape = new RectangleShape();
            _rectangleShapeView = new RectangleShapeForm(_rectangleShape);

            _rectangleShapeView.CalculateAreaPressed += CalculateAreaPressed;

            _rectangleShapeView.ResetForm();
            _rectangleShapeView.ShowDialog();

        }

        private void CalculateAreaPressed(object sender, EventArgs e)
        {
            _rectangleShape = _rectangleShapeView.RectangleShape;
            _rectangleShape.CalculateArea();
            _rectangleShapeView.RectangleShape = _rectangleShape;
        }
    }
}
