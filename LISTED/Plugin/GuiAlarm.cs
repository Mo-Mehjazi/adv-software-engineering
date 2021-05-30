using System;
using System.Media;
using System.Timers;
using System.Windows.Forms;

namespace LISTED.Plugin
{
    public partial class GuiAlarm : Form
    {
        System.Timers.Timer timer;
        public GuiAlarm()
        {
            InitializeComponent();
        }

        private void GuiAlarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        //Keep the lbl Updated (Control lbl)
        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePickerAlarm.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLabel;
                    if (lblStatus.InvokeRequired)
                        Invoke(upd, lblStatus, "Stop");

                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStartAlarm_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Running...";
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Stop!";
            //TODO: Stop Player when btnStop clicked
        }

    }
}