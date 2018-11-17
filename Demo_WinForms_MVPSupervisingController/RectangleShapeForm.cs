using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_WinForms_MVPSupervisingController.Models;
using Demo_WinForms_MVPSupervisingController.Presenters;
using Demo_WinForms_MVPSupervisingController.Views;

namespace Demo_WinForms_MVPSupervisingController
{
    public partial class RectangleShapeForm : Form, IRectangleShapeView
    {
        private RectangleShape _rectangleShape;

        public RectangleShapeForm()
        {
            InitializeComponent();
        }

        public RectangleShape RectangleShape
        {
            get
            {
                _rectangleShape.Length = double.Parse(txt_Length.Text);
                _rectangleShape.Width = double.Parse(txt_Width.Text);

                return _rectangleShape;
            }
            set
            {
                _rectangleShape = value;

                txt_Length.Text = value.Length.ToString();
                txt_Width.Text = value.Width.ToString();
                txt_Area.Text = value.Area.ToString();
            }
        }

        public event EventHandler CalculateAreaPressed;

        private void btn_CalculateArea_Click(object sender, EventArgs e)
        {
            if (CalculateAreaPressed != null)
            {
                CalculateAreaPressed(this, EventArgs.Empty);
            }
        }
    }
}
