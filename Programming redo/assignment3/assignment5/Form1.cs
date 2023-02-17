namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int distance = 0;
            int seconds = int.Parse(SecondstextBox.Text);
            int minutes = int.Parse(MinutestextBox.Text);
            int hours = int.Parse(HoursTextBox.Text);

            int hoursToseconds = hours*3600;
            int minutestoseconds = minutes*60;

            int totalSeconds = seconds + hoursToseconds + minutestoseconds;
            double totalTimeInHours = (double)totalSeconds / 3600;

            

            if (fivekmradioButton.Checked)
            {
                distance = 5;
            }
            if (TenKmradioButton.Checked)
            {
                distance = 10;
            }
            if (TwentyOneKmRadioButton.Checked)
            {
                distance = 21;
            }

            double speed = (double)(distance)/(totalTimeInHours);

            outPutLabel.Text = speed.ToString("0.000");
        }
    }
}