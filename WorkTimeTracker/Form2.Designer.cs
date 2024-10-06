namespace WorkTimeTracker
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			richTextBox1 = new RichTextBox();
			SubmitEvent = new Button();
			dateTimePicker1 = new DateTimePicker();
			flowLayoutPanel1 = new FlowLayoutPanel();
			textBox1 = new TextBox();
			OptionalTaskAlias = new TextBox();
			EventTitle = new Label();
			EventDescription = new Label();
			WantToMentionOptionalTask = new CheckBox();
			SuspendLayout();
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(6, 136);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(340, 96);
			richTextBox1.TabIndex = 4;
			richTextBox1.Text = "";
			// 
			// SubmitEvent
			// 
			SubmitEvent.Location = new Point(6, 238);
			SubmitEvent.Name = "SubmitEvent";
			SubmitEvent.Size = new Size(100, 23);
			SubmitEvent.TabIndex = 5;
			SubmitEvent.Text = "Dodaj evencik";
			SubmitEvent.UseVisualStyleBackColor = true;
			SubmitEvent.Click += SubmitEvent_Click;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 12);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(334, 23);
			dateTimePicker1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(112, 238);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(234, 96);
			flowLayoutPanel1.TabIndex = 12;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 85);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(340, 23);
			textBox1.TabIndex = 3;
			// 
			// OptionalTaskAlias
			// 
			OptionalTaskAlias.Location = new Point(164, 41);
			OptionalTaskAlias.Name = "OptionalTaskAlias";
			OptionalTaskAlias.Size = new Size(182, 23);
			OptionalTaskAlias.TabIndex = 2;
			// 
			// EventTitle
			// 
			EventTitle.AutoSize = true;
			EventTitle.Location = new Point(6, 67);
			EventTitle.Name = "EventTitle";
			EventTitle.Size = new Size(32, 15);
			EventTitle.TabIndex = 10;
			EventTitle.Text = "Tytuł";
			// 
			// EventDescription
			// 
			EventDescription.AutoSize = true;
			EventDescription.Location = new Point(6, 118);
			EventDescription.Name = "EventDescription";
			EventDescription.Size = new Size(31, 15);
			EventDescription.TabIndex = 11;
			EventDescription.Text = "Opis";
			// 
			// WantToMentionOptionalTask
			// 
			WantToMentionOptionalTask.AutoSize = true;
			WantToMentionOptionalTask.Location = new Point(12, 41);
			WantToMentionOptionalTask.Name = "WantToMentionOptionalTask";
			WantToMentionOptionalTask.Size = new Size(83, 19);
			WantToMentionOptionalTask.TabIndex = 1;
			WantToMentionOptionalTask.Text = "checkBox1";
			WantToMentionOptionalTask.UseVisualStyleBackColor = true;
			WantToMentionOptionalTask.CheckedChanged += WantToMentionOptionalTask_CheckedChanged;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(358, 384);
			Controls.Add(WantToMentionOptionalTask);
			Controls.Add(EventDescription);
			Controls.Add(EventTitle);
			Controls.Add(OptionalTaskAlias);
			Controls.Add(textBox1);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(dateTimePicker1);
			Controls.Add(SubmitEvent);
			Controls.Add(richTextBox1);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox richTextBox1;
		private Button SubmitEvent;
		private DateTimePicker dateTimePicker1;
		private FlowLayoutPanel flowLayoutPanel1;
		private TextBox textBox1;
		private TextBox OptionalTaskAlias;
		private Label EventTitle;
		private Label EventDescription;
		private CheckBox WantToMentionOptionalTask;
	}
}