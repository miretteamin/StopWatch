using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte seconds = 0, minutes = 0, hours = 0;

        private void Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                Start.Text = "Start";
                Start.ForeColor = Color.Purple;
            }
            else if (timer1.Enabled == false)
            {
                timer1.Start();
                Start.Text = "Stop";
                Start.ForeColor = Color.BlueViolet;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            Secondslbl.Text = seconds.ToString();
            if (seconds==59)
            {
                seconds = 0;
                minutes++;
            }
            else if (minutes==59)
            {
                minutes = 0;
                hours++;
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = 0;
            minutes = 0;
            hours = 0;
            Secondslbl.Text = "00";
            Minuteslbl.Text = "00";
            Hourslbl.Text = "00";
            Start.Text = "Start";
            Start.ForeColor = Color.Purple;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
