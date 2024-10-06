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

		private Form1 WorkEventOwner;

		public Form2(Form Owner, TimeSpan T)
		{
			InitializeComponent();
			WorkEventOwner = (Form1)Owner;
			SubmitEvent.Text = T.ToString();
			OptionalTaskAlias.Enabled = false;

		}

		private void SubmitEvent_Click(object sender, EventArgs e)
		{

		}

		private void WantToMentionOptionalTask_CheckedChanged(object sender, EventArgs e)
		{
			OptionalTaskAlias.Enabled = WantToMentionOptionalTask.Checked;
		}
	}
}
