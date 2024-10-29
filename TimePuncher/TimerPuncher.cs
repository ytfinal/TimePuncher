using System.Text;

namespace TimePuncher
{
    public partial class TimerPuncherForm : Form
    {
        private const double offSetStartHours = 7.5;
        private const int defaultWorkHours = 8;
        private const double defaultHoursToLunch = 4.25;
        private const double defaultLunchHours = 0.5;
        private const string dateFormat = "hh:mm tt";

        public TimerPuncherForm()
        {
            InitializeComponent();
        }

        private void TimerPuncherForm_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddHours(offSetStartHours);
            DateTime lunchStartTime = startTime.AddHours(defaultHoursToLunch);
            DateTime lunchEndTime = lunchStartTime.AddHours(defaultLunchHours);
            DateTime endTime = startTime.AddHours(defaultWorkHours).AddHours(defaultLunchHours);
            startTimePicker.Value = startTime;
            lunchStartTimePicker.Value = lunchStartTime;
            lunchEndTimePicker.Value = lunchEndTime;
            endTimePicker.Value = endTime;
        }

        private void hoursWorkedLabel_Click(object sender, EventArgs e)
        {

        }

        private void handleChanges(DateTime startTime, DateTime lunchStartTime, DateTime lunchEndTime, DateTime endTime)
        {
            TimeSpan firstHalfWorkSpan = lunchStartTime - startTime;
            TimeSpan lunchTimeSpan = lunchEndTime - lunchStartTime;
            TimeSpan secondHalfWorkSpan = endTime - lunchEndTime;
            double totalWorkMinutes = firstHalfWorkSpan.TotalMinutes + secondHalfWorkSpan.TotalMinutes;
            double totalLunchMinutes = lunchTimeSpan.TotalMinutes;
            string summary = $"Hours: {(totalWorkMinutes / 60).ToString("0.00")}";
            hoursWorkedLabel.Text = summary;
            string lunchHours = $"Lunch: {(totalLunchMinutes / 60).ToString("0.00")}";
            lunchMinutesLabel.Text = lunchHours;

            StringBuilder reportTextBuilder = new StringBuilder();
            reportTextBuilder.AppendLine($"Start Time: {startTime.ToString(dateFormat)}");
            reportTextBuilder.AppendLine($"Lunch Start Time: {lunchStartTime.ToString(dateFormat)}");
            reportTextBuilder.AppendLine($"Lunch End Time: {lunchEndTime.ToString(dateFormat)}");
            reportTextBuilder.AppendLine($"End Time: {endTime.ToString(dateFormat)}");
            reportTextBuilder.AppendLine(summary);
            reportTextBuilder.AppendLine(lunchHours);

            reportTextBox.Text = reportTextBuilder.ToString();
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            handleChanges(startTimePicker.Value, lunchStartTimePicker.Value, lunchEndTimePicker.Value, endTimePicker.Value);
        }

        private void lunchStartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            handleChanges(startTimePicker.Value, lunchStartTimePicker.Value, lunchEndTimePicker.Value, endTimePicker.Value);
        }

        private void lunchEndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            handleChanges(startTimePicker.Value, lunchStartTimePicker.Value, lunchEndTimePicker.Value, endTimePicker.Value);
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            handleChanges(startTimePicker.Value, lunchStartTimePicker.Value, lunchEndTimePicker.Value, endTimePicker.Value);
        }
    }
}