namespace AlwaysOnTop
{
	partial class Config
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.topMost_ON_textBox = new System.Windows.Forms.TextBox();
			this.topMost_ON_button = new System.Windows.Forms.Button();
			this.topMost_ON_label = new System.Windows.Forms.Label();
			this.topMost_OFF_label = new System.Windows.Forms.Label();
			this.topMost_OFF_button = new System.Windows.Forms.Button();
			this.topMost_OFF_textBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.topMost_OFF_label);
			this.groupBox1.Controls.Add(this.topMost_OFF_button);
			this.groupBox1.Controls.Add(this.topMost_OFF_textBox);
			this.groupBox1.Controls.Add(this.topMost_ON_label);
			this.groupBox1.Controls.Add(this.topMost_ON_button);
			this.groupBox1.Controls.Add(this.topMost_ON_textBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 94);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TopMost Settings";
			// 
			// topMost_ON_textBox
			// 
			this.topMost_ON_textBox.Location = new System.Drawing.Point(35, 29);
			this.topMost_ON_textBox.Name = "topMost_ON_textBox";
			this.topMost_ON_textBox.ReadOnly = true;
			this.topMost_ON_textBox.Size = new System.Drawing.Size(167, 21);
			this.topMost_ON_textBox.TabIndex = 0;
			// 
			// topMost_ON_button
			// 
			this.topMost_ON_button.Location = new System.Drawing.Point(208, 29);
			this.topMost_ON_button.Name = "topMost_ON_button";
			this.topMost_ON_button.Size = new System.Drawing.Size(75, 23);
			this.topMost_ON_button.TabIndex = 1;
			this.topMost_ON_button.Text = "설정";
			this.topMost_ON_button.UseVisualStyleBackColor = true;
			// 
			// topMost_ON_label
			// 
			this.topMost_ON_label.AutoSize = true;
			this.topMost_ON_label.Location = new System.Drawing.Point(6, 32);
			this.topMost_ON_label.Name = "topMost_ON_label";
			this.topMost_ON_label.Size = new System.Drawing.Size(23, 12);
			this.topMost_ON_label.TabIndex = 2;
			this.topMost_ON_label.Text = "ON";
			// 
			// topMost_OFF_label
			// 
			this.topMost_OFF_label.AutoSize = true;
			this.topMost_OFF_label.Location = new System.Drawing.Point(1, 58);
			this.topMost_OFF_label.Name = "topMost_OFF_label";
			this.topMost_OFF_label.Size = new System.Drawing.Size(28, 12);
			this.topMost_OFF_label.TabIndex = 5;
			this.topMost_OFF_label.Text = "OFF";
			// 
			// topMost_OFF_button
			// 
			this.topMost_OFF_button.Location = new System.Drawing.Point(208, 53);
			this.topMost_OFF_button.Name = "topMost_OFF_button";
			this.topMost_OFF_button.Size = new System.Drawing.Size(75, 23);
			this.topMost_OFF_button.TabIndex = 4;
			this.topMost_OFF_button.Text = "설정";
			this.topMost_OFF_button.UseVisualStyleBackColor = true;
			// 
			// topMost_OFF_textBox
			// 
			this.topMost_OFF_textBox.Location = new System.Drawing.Point(35, 53);
			this.topMost_OFF_textBox.Name = "topMost_OFF_textBox";
			this.topMost_OFF_textBox.ReadOnly = true;
			this.topMost_OFF_textBox.Size = new System.Drawing.Size(167, 21);
			this.topMost_OFF_textBox.TabIndex = 3;
			// 
			// Config
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 118);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Config";
			this.Text = "Config";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label topMost_OFF_label;
		private System.Windows.Forms.Button topMost_OFF_button;
		private System.Windows.Forms.TextBox topMost_OFF_textBox;
		private System.Windows.Forms.Label topMost_ON_label;
		private System.Windows.Forms.Button topMost_ON_button;
		private System.Windows.Forms.TextBox topMost_ON_textBox;
	}
}