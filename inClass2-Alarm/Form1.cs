using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass2_Alarm
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
        DateTime alarmDateTime;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            
            player.SoundLocation = @"C:\Users\Majid\Desktop\CONCEPT-II-PROG1815\InClass\inClass2-Alarm\alarm.wav";
            stopAlarmButton.BackColor = Color.Red;
            stopAlarmButton.ForeColor = Color.Yellow;
            player.Play();
        }
        private void alarmSetBox_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(alarmSetBox.Text, out alarmDateTime))
            {
                alarmCheck.Checked = true;
            }
            else
            {
                alarmCheck.Checked = false;
            }
        }
       
        private void stopAlarmButton_Click(object sender, EventArgs e)
        {
            alarmTimer.Enabled = false;
            stopAlarmButton.BackColor = Color.Gray;
            stopAlarmButton.ForeColor = Color.Black;
            player.Stop();
        }

        private void alarmOnCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (alarmCheck.Checked==false)
            {
                alarmTimer.Enabled = false;
            }
        }
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss tt");
            if (alarmCheck.Checked && currentTimeLabel.Text == alarmDateTime.ToString("HH:mm:ss tt"))
            {
                alarmTimer.Enabled = true;
                alarmTimer.Start();
            }
        }
    }
}
