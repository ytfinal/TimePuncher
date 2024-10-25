namespace TimePuncher
{
    public partial class TimerPuncherForm : Form
    {
        private const double offSetStartHours = 7.5;
        private const int defaultWorkHours = 8;
        private const double defaultHoursToLunch = 4.25;
        private const double defaultLunchHours = 0.5;

        public TimerPuncherForm()
        {
            DateTime currentTime = DateTime.Now;
            DateTime startTime= new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddHours(offSetStartHours);
            DateTime lunchStartTime = startTime.AddHours(defaultHoursToLunch);
            DateTime lunchEndTime = lunchStartTime.AddHours(defaultLunchHours);
            DateTime endTime= startTime.AddHours(defaultWorkHours).AddHours(defaultLunchHours);
            
            InitializeComponent();

            startTimePicker.Value = startTime;
            lunchStartTimePicker.Value = lunchStartTime;
            lunchEndTimePicker.Value = lunchEndTime;
            endTimePicker.Value = endTime;
        }

        private void TimerPuncherForm_Load(object sender, EventArgs e)
        {

        }

        private void hoursWorkedLabel_Click(object sender, EventArgs e)
        {

        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lunchStartTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lunchEndTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}