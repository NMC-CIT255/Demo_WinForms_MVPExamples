using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_WinForms_MVPExamples.Models;
using Demo_WinForms_MVPExamples.Presenters;
using Demo_WinForms_MVPExamples.Views;
using Demo_WinForms_MVPExamples.Models;

namespace Demo_WinForms_MVPExamples
{
    public partial class RectangleForm : Form, IRectangleView
    {
        private Rectangle rectangle;

        public Rectangle Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }


        public RectangleForm()
        {
            InitializeComponent();
        }

        private void btn_CalculateArea_Click(object sender, EventArgs e)
        {
            RectanglePresenter rectanglePresenter = new RectanglePresenter(this);
            rectanglePresenter.CalculateArea();
        }
    }
}
