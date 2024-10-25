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
            DateTime startTime;
            DateTime endTime;

            startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddHours(offSetStartHours);
            endTime = startTime.AddHours(defaultWorkHours);

            DateTime lunchStartTime = startTime.AddHours(defaultHoursToLunch);

            InitializeComponent();
            startTimePicker.Value = startTime;
            lunchStartTimePicker.Value = lunchStartTime;
            lunchEndTimePicker.Value = lunchStartTime.AddHours(defaultLunchHours);
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