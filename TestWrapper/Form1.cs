using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircleControl;
using Lfo = LFO.LFO;

namespace TestWrapper
{
    public partial class Form1 : Form
    {
        Timer tmr = new Timer() { Interval = 10 };
        Lfo _lfo = Lfo.CreateSaw();

        public Form1()
        {
            InitializeComponent();
            tmr.Tick += Tmr_Tick;
            circleProgressControl1.MaxValue = 15f;
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            //circleProgressControl1.Value = (float)_lfo.Value;
            //circleProgressControl1.ForeColor = Properties.Resources.Spectre.GetPixel((int)(circleProgressControl1.Value / circleProgressControl1.MaxValue * 360 % 360), 0);

            circleProgressControl1.Value = DateTime.Now.Second + DateTime.Now.Millisecond / 1000f;
        }
    }
}
