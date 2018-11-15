using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_WinForms_MVPExamples.Presenters;
using Demo_WinForms_MVPExamples.Views;

namespace Demo_WinForms_MVPExamples
{
    public partial class ShapesForm : Form, IRectangle
    {
        public ShapesForm()
        {
            InitializeComponent();
        }

        public string LengthText
        {
            get
            {
                return txt_Length.Text;
            }
            set
            {
                txt_Length.Text = value;
            }
        }
        public string WidthText
        {
            get
            {
                return txt_Width.Text;
            }
            set
            {
                txt_Width.Text = value;
            }
        }
        public string AreaText
        {
            get
            {
                return txt_Area.Text;
            }
            set
            {
                txt_Area.Text = value;
            }
        }

        private void btn_CalculateArea_Click(object sender, EventArgs e)
        {
            RectanglePresenter rectanglePresenter = new RectanglePresenter(this);
            rectanglePresenter.CalculateArea();
        }
    }
}
