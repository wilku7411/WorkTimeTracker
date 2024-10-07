using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeTracker
{
	public partial class Form2 : Form
	{
		private DayEvents TotalEvents;
		private Form1 WorkEventOwner;
		private Random Rnd = new Random();
		private TimeSpan CachedTimeStamp;

		public Form2(Form Owner, TimeSpan T)
		{
			InitializeComponent();
			WorkEventOwner = (Form1)Owner;
			CachedTimeStamp = T;
			SubmitEvent.Text = T.ToString();
			OptionalTaskAlias.Enabled = false;
			TotalEvents = new DayEvents();
			DayEvents.Deserialize(ref TotalEvents);
		}

		private void FillTagsPanel()
		{
			foreach (string Tag in TotalEvents.GetAllCachedTags())
			{
				Button TagRepresentation = new Button();
				Color RandomColor = Color.FromArgb(Rnd.Next(256), Rnd.Next(256), Rnd.Next(256));
				TagRepresentation.BackColor = RandomColor;
				TagRepresentation.Text = Tag;
				TagRepresentation.AutoSize = true;
				TagRepresentation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
				TagsPanel.Controls.Add(TagRepresentation);
			}
		}

		private void SubmitEvent_Click(object sender, EventArgs e)
		{
			WorkTrackerEvent NewEvent = new WorkTrackerEvent(
				EventTitle.Text,
				EventDescription.Text,
				OptionalTaskAlias.Text,
				GetTags(),
				CachedTimeStamp);

			TotalEvents.AddEvent(NewEvent);
			DayEvents.Serialize(ref TotalEvents);
			Close();
		}
		private void Discard_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void WantToMentionOptionalTask_CheckedChanged(object sender, EventArgs e)
		{
			OptionalTaskAlias.Enabled = WantToMentionOptionalTask.Checked;
		}

		private void AddTag_Click(object sender, EventArgs e)
		{
			AddTag.Clear();
		}

		private void AddTag_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ((char)Keys.Enter))
			{

				Button TagRepresentation = new Button();
				Color RandomColor = Color.FromArgb(Rnd.Next(256), Rnd.Next(256), Rnd.Next(256));
				TagRepresentation.BackColor = RandomColor;
				TagRepresentation.Text = AddTag.Text;
				TagRepresentation.AutoSize = true;
				TagRepresentation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
				AddTag.Text = "";

				TagsPanel.Controls.Add(TagRepresentation);

			}
		}
		private List<string> GetTags()
		{
			List<string> Tags = new List<string>();
			foreach (Button Tag in TagsPanel.Controls)
			{
				Tags.Add(Tag.Text);
			}
			return Tags;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			FillTagsPanel();
		}
	}
}
