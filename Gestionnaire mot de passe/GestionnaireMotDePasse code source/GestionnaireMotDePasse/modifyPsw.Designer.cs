namespace GestionnaireMotDePasse
{
	partial class modifyPsw
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.old = new System.Windows.Forms.TextBox();
			this.new1 = new System.Windows.Forms.TextBox();
			this.new2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Old password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "New password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirm new password";
			// 
			// old
			// 
			this.old.Location = new System.Drawing.Point(36, 26);
			this.old.Name = "old";
			this.old.Size = new System.Drawing.Size(100, 20);
			this.old.TabIndex = 3;
			// 
			// new1
			// 
			this.new1.Location = new System.Drawing.Point(36, 65);
			this.new1.Name = "new1";
			this.new1.Size = new System.Drawing.Size(100, 20);
			this.new1.TabIndex = 4;
			// 
			// new2
			// 
			this.new2.Location = new System.Drawing.Point(36, 104);
			this.new2.Name = "new2";
			this.new2.Size = new System.Drawing.Size(100, 20);
			this.new2.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 133);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Validate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// modifyPsw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(179, 168);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.new2);
			this.Controls.Add(this.new1);
			this.Controls.Add(this.old);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "modifyPsw";
			this.Text = "modifyPsw";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox old;
		private System.Windows.Forms.TextBox new1;
		private System.Windows.Forms.TextBox new2;
		private System.Windows.Forms.Button button1;
	}
}