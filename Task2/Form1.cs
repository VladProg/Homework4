using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Shape s = null;
                switch (comboBoxShape.SelectedIndex)
                {
                    case 0:
                        s = new Triangle(double.Parse(flowLayoutPanelParameters.Controls[1].Text),
                                         double.Parse(flowLayoutPanelParameters.Controls[2].Text),
                                         double.Parse(flowLayoutPanelParameters.Controls[3].Text));
                        break;
                    case 1:
                        s = new Disk(double.Parse(flowLayoutPanelParameters.Controls[1].Text));
                        break;
                    case 2:
                        s = new Rectangle(double.Parse(flowLayoutPanelParameters.Controls[1].Text),
                                          double.Parse(flowLayoutPanelParameters.Controls[2].Text));
                        break;
                    case 3:
                        s = new Square(double.Parse(flowLayoutPanelParameters.Controls[1].Text));
                        break;
                    case 4:
                        s = new Rhombus(double.Parse(flowLayoutPanelParameters.Controls[1].Text),
                                        double.Parse(flowLayoutPanelParameters.Controls[2].Text));
                        break;
                }
                labelInfo.Text = $"S={s.Area():F2},    P={s.Perimeter():F2}";
            }
            catch (Exception ex)
            {
                labelInfo.Text = "⚠ " + ex.GetType().Name + ": " + ex.Message;
            }
        }

        TextBox Create()
        {
            TextBox res = new();
            res.TextChanged += textBox_TextChanged;
            return res;
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            while(flowLayoutPanelParameters.Controls.Count>1)
            {
                var control = flowLayoutPanelParameters.Controls[1];
                flowLayoutPanelParameters.Controls.RemoveAt(1);
                control.Dispose();
            }
            switch (comboBoxShape.SelectedIndex)
            {
                case 0:
                    labelParameters.Text = "sides:";
                    flowLayoutPanelParameters.Controls.Add(Create());
                    flowLayoutPanelParameters.Controls.Add(Create());
                    flowLayoutPanelParameters.Controls.Add(Create());
                    break;
                case 1:
                    labelParameters.Text = "radius:";
                    flowLayoutPanelParameters.Controls.Add(Create());
                    break;
                case 2:
                    labelParameters.Text = "sides:";
                    flowLayoutPanelParameters.Controls.Add(Create());
                    flowLayoutPanelParameters.Controls.Add(Create());
                    break;
                case 3:
                    labelParameters.Text = "side:";
                    flowLayoutPanelParameters.Controls.Add(Create());
                    break;
                case 4:
                    labelParameters.Text = "diagonals:";
                    flowLayoutPanelParameters.Controls.Add(Create());
                    flowLayoutPanelParameters.Controls.Add(Create());
                    break;
            }
            labelInfo.Text = "";
        }
    }
}
