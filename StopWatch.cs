using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIParent_MenuStrip_CSharp
{
    public partial class StopWatch : Form
    {
        private int seconds;
        private int minutes;
        private int hours;
        private bool displaySetTimePanel = true;

        public StopWatch()
        {
            InitializeComponent();
            seconds = minutes = hours = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this method will call in every second
            seconds++;

            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }

            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }

            ChangeLabels();
        }

        private void ChangeLabels()
        {
            lblHours.Text = change(hours);
            lblMinutes.Text = change(minutes);
            lblSeconds.Text = change(seconds);
        }

        private string change(int value)
        {
            if (value < 10)
            {
                return "0" + value;
            }
            else
            {
                return value.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            resetWatch();
            timer1.Stop();
        }

        private void resetWatch()
        {
            hours = minutes = seconds = 0;
            ChangeLabels();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            timer1.Stop();
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            if (displaySetTimePanel)
            {
                setTimePanel.Visible = true;
                displaySetTimePanel = false;
            }
            else
            {
                setTimePanel.Visible = false;
                displaySetTimePanel = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtSetHours.Text == "")
            {
                MessageBox.Show("Please, Fill Hours");
            }
            else if (txtSetMinutes.Text == "")
            {
                MessageBox.Show("Please, Fill Minutes");
            }
            else if (txtSetSeconds.Text == "")
            {
                MessageBox.Show("Please, Fill Seconds");
            }
            else
            {
                hours = Convert.ToInt32(txtSetHours.Text);
                minutes = Convert.ToInt32(txtSetMinutes.Text);
                seconds = Convert.ToInt32(txtSetSeconds.Text);

                lblHours.Text = change(hours);
                lblMinutes.Text = change(minutes);
                lblSeconds.Text = change(seconds);
            }
        }
    }
}
