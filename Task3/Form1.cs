using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        private void textBoxRight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Triangle t = new RightTriangle(double.Parse(textBoxRightA.Text),
                                               double.Parse(textBoxRightB.Text));
                labelRightInfo.Text = $"S={t.Area():F2},    P={t.Perimeter():F2}";
            }
            catch (Exception ex)
            {
                labelRightInfo.Text = "⚠ " + ex.GetType().Name + ": " + ex.Message;
            }
        }

        private void textBoxIsosceles_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Triangle t = new IsoscelesTriangle(double.Parse(textBoxIsoscelesA.Text),
                                                   double.Parse(textBoxIsoscelesGamma.Text));
                labelIsoscelesInfo.Text = $"S={t.Area():F2},    P={t.Perimeter():F2}";
            }
            catch (Exception ex)
            {
                labelIsoscelesInfo.Text = "⚠ " + ex.GetType().Name + ": " + ex.Message;
            }
        }
    }
}
