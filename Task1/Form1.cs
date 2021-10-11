using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }
        Triangle _triangle;
        private void CalculateTriangle(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxTriangleA.Text);
                double b = double.Parse(textBoxTriangleB.Text);
                double c = double.Parse(textBoxTriangleC.Text);
                if (_triangle == null)
                    _triangle = new(a, b, c);
                else
                {
                    _triangle.A = a;
                    _triangle.B = b;
                    _triangle.C = c;
                }
                labelTriangleInfo.Text = $"α={_triangle.Alpha():F2}°,    " +
                                         $"β={_triangle.Beta():F2}°,    " +
                                         $"γ={_triangle.Gamma():F2}°,    " +
                                         $"P={_triangle.Perimeter():F2}";
            }
            catch (Exception ex)
            {
                labelTriangleInfo.Text = "⚠ " + ex.GetType().Name + ": " + ex.Message;
            }
        }
        RegularTriangle _regularTriangle;
        private void CalculateRegularTriangle(object sender, Action<double> action)
        {
            if (!((TextBox)sender).Modified)
                return;
            try
            {
                action(double.Parse(((TextBox)sender).Text.ToString()));
                labelRegularTriangleInfo.Text = $"α={_regularTriangle.Alpha():F2}°,    " +
                                                $"β={_regularTriangle.Beta():F2}°,    " +
                                                $"γ={_regularTriangle.Gamma():F2}°,    " +
                                                $"P={_regularTriangle.Perimeter():F2}";
                if (textBoxRegularTriangleA != sender)
                    textBoxRegularTriangleA.Text = _regularTriangle.A.ToString();
                if (textBoxRegularTriangleB != sender)
                    textBoxRegularTriangleB.Text = _regularTriangle.B.ToString();
                if (textBoxRegularTriangleC != sender)
                    textBoxRegularTriangleC.Text = _regularTriangle.C.ToString();
                if (textBoxRegularTriangleArea != sender)
                    textBoxRegularTriangleArea.Text = _regularTriangle.Area.ToString();
            }
            catch (Exception ex)
            {
                labelRegularTriangleInfo.Text = "⚠ " + ex.GetType().Name + ": " + ex.Message;
            }
        }

        private void textBoxRegularTriangleA_TextChanged(object sender, EventArgs e)
        {
            CalculateRegularTriangle(sender, a =>
            {
                if (_regularTriangle == null)
                    _regularTriangle = RegularTriangle.FromSide(a);
                else
                    _regularTriangle.A = a;
            });
        }

        private void textBoxRegularTriangleB_TextChanged(object sender, EventArgs e)
        {
            CalculateRegularTriangle(sender, b =>
            {
                if (_regularTriangle == null)
                    _regularTriangle = RegularTriangle.FromSide(b);
                else
                    _regularTriangle.B = b;
            });
        }

        private void textBoxRegularTriangleC_TextChanged(object sender, EventArgs e)
        {
            CalculateRegularTriangle(sender, c =>
            {
                if (_regularTriangle == null)
                    _regularTriangle = RegularTriangle.FromSide(c);
                else
                    _regularTriangle.C = c;
            });
        }

        private void textBoxRegularTriangleArea_TextChanged(object sender, EventArgs e)
        {
            CalculateRegularTriangle(sender, area =>
            {
                if (_regularTriangle == null)
                    _regularTriangle = RegularTriangle.FromArea(area);
                else
                    _regularTriangle.Area = area;
            });
        }
    }
}
