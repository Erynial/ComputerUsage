using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComputerUsage
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();

            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;

            lblCPU.Text = string.Format("{0:0.0}%", fcpu);
            lblRAM.Text = string.Format("{0:0.0}%", fram);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
