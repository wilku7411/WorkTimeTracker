namespace WorkTimeTracker
{
	public partial class Form1 : Form
	{
		private double DefaultOpacity = 0.7;

		private const int WorkDayCompletedInMs = 8 * 60 * 60 * 1000;
		private const int TestValue = 4;
		private TimeSpan CollectedTime;

		private bool bOvertime = false;
		private TimeSpan OverTime;

		public Form1()
		{
			InitializeComponent();
			Opacity = DefaultOpacity;

			progressBar1.Maximum = WorkDayCompletedInMs;
			progressBar1.Step = 1000;
			progressBar1.Value = 0;
			progressBar1.MarqueeAnimationSpeed = 1;

			progressBar2.Visible = false;
			progressBar2.Value = 0;
			progressBar2.MarqueeAnimationSpeed = 1;
			progressBar2.Style = ProgressBarStyle.Marquee;

			timer1.Interval = 1000;

			CollectedTime = TimeSpan.FromMilliseconds(0);
			OverTime = TimeSpan.FromMilliseconds(0);

			label1.Text = CollectedTime.ToString();
			label2.Visible = false;

			DisplayPending();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value < progressBar1.Maximum)
			{
				progressBar1.PerformStep();
				CollectedTime += TimeSpan.FromSeconds(1);
				label1.Text = CollectedTime.ToString();
			}

			if (progressBar1.Value == progressBar1.Maximum)
			{
				progressBar2.Visible = true;

				OverTime += TimeSpan.FromSeconds(1);
				label2.Text = OverTime.ToString();
				label2.Visible = true;
				if (!bOvertime)
				{
					bOvertime = true;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (timer1.Enabled)
			{
				timer1.Stop();
				DisplayPending();
			}
			else
			{
				timer1.Start();
				DisplayWorking();
			}
			OnTimerStateChanged(timer1.Enabled);
		}

		private void OnTimerStateChanged(bool NewState)
		{
			progressBar1.ForeColor = NewState == true ? Color.Green : Color.Red;
		}

		private void DisplayPending()
		{
			button1.Text = "P R A C U J";
			button1.BackColor = Color.FromArgb(128, 255, 128);
			if (!bOvertime)
			{
				progressBar1.Style = ProgressBarStyle.Marquee;
			}
		}

		private void DisplayWorking()
		{
			button1.Text = "P R Z E R W K A";
			button1.BackColor = Color.FromArgb(255, 128, 128);
			if (!bOvertime)
			{
				progressBar1.Style = ProgressBarStyle.Continuous;
			}
		}

		private void OnMouseHover()
		{
			Opacity = 1.0f;
		}

		private void OnMouseLeave()
		{
			Opacity = DefaultOpacity;
		}

		private void ffw_MouseDown(object sender, MouseEventArgs e)
		{
			timer1.Interval = 1000 / 100;
		}

		private void ffw_MouseUp(object sender, MouseEventArgs e)
		{
			timer1.Interval = 1000;
		}

		private void button1_MouseHover(object sender, EventArgs e)
		{
			OnMouseHover();
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			OnMouseLeave();
		}
	}
}