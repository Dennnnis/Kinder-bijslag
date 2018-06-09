using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinderbijslag
{
    public partial class De_Form : Form
    {
        public De_Form()
        {
            InitializeComponent();
        }

        private void Bereken()
        {
            label5.Text = "€ " + Math.Round((((trackBar2.Value * 150.0m) + ((trackBar1.Value - trackBar2.Value) * 235.0m)) * ((((trackBar1.Value < 3) ? 0.0m : (trackBar1.Value < 5) ? 2.0m : (trackBar1.Value < 6) ? 3.0m : 3.5m) / 100) + 1)) * trackBar3.Value, 2);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            trackBar2.Maximum = trackBar1.Value;
            trackBar2.TickFrequency = trackBar1.Value;
            trackBar2_Scroll(sender, e);
            Bereken();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar2.Value.ToString();
            Bereken();
        }

        private void De_Form_Load(object sender, EventArgs e)
        {
            label2.Text = "Kinderen geboren na " + DateTime.Today.AddYears(-12).ToLongDateString();
            Bereken();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar3.Value.ToString();
            Bereken();
        }
    }
}
