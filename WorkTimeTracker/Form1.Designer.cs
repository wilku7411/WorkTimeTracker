namespace WorkTimeTracker
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			progressBar1 = new ProgressBar();
			button1 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			label1 = new Label();
			progressBar2 = new ProgressBar();
			label2 = new Label();
			label3 = new Label();
			ffw = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// progressBar1
			// 
			progressBar1.Dock = DockStyle.Top;
			progressBar1.Location = new Point(0, 0);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(617, 34);
			progressBar1.Style = ProgressBarStyle.Continuous;
			progressBar1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button1.BackColor = Color.FromArgb(255, 128, 128);
			button1.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1.ForeColor = Color.Black;
			button1.Location = new Point(122, 40);
			button1.Name = "button1";
			button1.Size = new Size(376, 31);
			button1.TabIndex = 1;
			button1.Text = "P R A C U J";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			button1.MouseLeave += button1_MouseLeave;
			button1.MouseHover += button1_MouseHover;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(295, 9);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 2;
			label1.Text = "label1";
			// 
			// progressBar2
			// 
			progressBar2.Dock = DockStyle.Bottom;
			progressBar2.Location = new Point(0, 144);
			progressBar2.Name = "progressBar2";
			progressBar2.Size = new Size(617, 9);
			progressBar2.Style = ProgressBarStyle.Continuous;
			progressBar2.TabIndex = 3;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(295, 89);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 4;
			label2.Text = "label2";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(253, 74);
			label3.Name = "label3";
			label3.Size = new Size(119, 15);
			label3.TabIndex = 5;
			label3.Text = "N A D G O D Z I N K I ";
			label3.Visible = false;
			// 
			// ffw
			// 
			ffw.Anchor = AnchorStyles.Right;
			ffw.Enabled = false;
			ffw.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ffw.Location = new Point(504, 40);
			ffw.Name = "ffw";
			ffw.Size = new Size(54, 45);
			ffw.TabIndex = 6;
			ffw.Text = "FFW";
			ffw.UseVisualStyleBackColor = true;
			ffw.Visible = false;
			ffw.MouseDown += ffw_MouseDown;
			ffw.MouseUp += ffw_MouseUp;
			// 
			// button2
			// 
			button2.Location = new Point(12, 40);
			button2.Name = "button2";
			button2.Size = new Size(104, 23);
			button2.TabIndex = 7;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(617, 153);
			ControlBox = false;
			Controls.Add(button2);
			Controls.Add(ffw);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(progressBar2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(progressBar1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(363, 155);
			Name = "Form1";
			RightToLeft = RightToLeft.No;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "P R A C K A   T I M E";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ProgressBar progressBar1;
		private Button button1;
		private System.Windows.Forms.Timer timer1;
		private Label label1;
		private ProgressBar progressBar2;
		private Label label2;
		private Label label3;
		private Button ffw;
		private Button button2;
	}
}