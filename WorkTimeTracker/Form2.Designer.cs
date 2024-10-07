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
			TagsPanel = new FlowLayoutPanel();
			textBox1 = new TextBox();
			OptionalTaskAlias = new TextBox();
			EventTitle = new Label();
			EventDescription = new Label();
			WantToMentionOptionalTask = new CheckBox();
			Discard = new Button();
			AddTag = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(6, 136);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(334, 96);
			richTextBox1.TabIndex = 4;
			richTextBox1.Text = "";
			// 
			// SubmitEvent
			// 
			SubmitEvent.Location = new Point(6, 257);
			SubmitEvent.Name = "SubmitEvent";
			SubmitEvent.Size = new Size(100, 23);
			SubmitEvent.TabIndex = 5;
			SubmitEvent.Text = "Dodaj evencik";
			SubmitEvent.UseVisualStyleBackColor = true;
			SubmitEvent.Click += SubmitEvent_Click;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(6, 12);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(334, 23);
			dateTimePicker1.TabIndex = 0;
			// 
			// TagsPanel
			// 
			TagsPanel.Location = new Point(112, 257);
			TagsPanel.Name = "TagsPanel";
			TagsPanel.Size = new Size(228, 87);
			TagsPanel.TabIndex = 12;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 85);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(334, 23);
			textBox1.TabIndex = 3;
			// 
			// OptionalTaskAlias
			// 
			OptionalTaskAlias.Location = new Point(158, 41);
			OptionalTaskAlias.Name = "OptionalTaskAlias";
			OptionalTaskAlias.PlaceholderText = "Przerwana robota";
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
			WantToMentionOptionalTask.Size = new Size(120, 19);
			WantToMentionOptionalTask.TabIndex = 1;
			WantToMentionOptionalTask.Text = "Przerwało robote?";
			WantToMentionOptionalTask.UseVisualStyleBackColor = true;
			WantToMentionOptionalTask.CheckedChanged += WantToMentionOptionalTask_CheckedChanged;
			// 
			// Discard
			// 
			Discard.Location = new Point(6, 321);
			Discard.Name = "Discard";
			Discard.Size = new Size(100, 23);
			Discard.TabIndex = 13;
			Discard.Text = "Jednak jebać";
			Discard.UseVisualStyleBackColor = true;
			Discard.Click += Discard_Click;
			// 
			// AddTag
			// 
			AddTag.Location = new Point(112, 350);
			AddTag.Name = "AddTag";
			AddTag.PlaceholderText = "Dodaj taga";
			AddTag.Size = new Size(228, 23);
			AddTag.TabIndex = 14;
			AddTag.Click += AddTag_Click;
			AddTag.KeyPress += AddTag_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(112, 238);
			label1.Name = "label1";
			label1.Size = new Size(28, 15);
			label1.TabIndex = 15;
			label1.Text = "Tagi";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(348, 384);
			Controls.Add(label1);
			Controls.Add(AddTag);
			Controls.Add(Discard);
			Controls.Add(WantToMentionOptionalTask);
			Controls.Add(EventDescription);
			Controls.Add(EventTitle);
			Controls.Add(OptionalTaskAlias);
			Controls.Add(textBox1);
			Controls.Add(TagsPanel);
			Controls.Add(dateTimePicker1);
			Controls.Add(SubmitEvent);
			Controls.Add(richTextBox1);
			Name = "Form2";
			Text = "Form2";
			Load += Form2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox richTextBox1;
		private Button SubmitEvent;
		private DateTimePicker dateTimePicker1;
		private FlowLayoutPanel TagsPanel;
		private TextBox textBox1;
		private TextBox OptionalTaskAlias;
		private Label EventTitle;
		private Label EventDescription;
		private CheckBox WantToMentionOptionalTask;
		private Button Discard;
		private TextBox AddTag;
		private Label label1;
	}
}