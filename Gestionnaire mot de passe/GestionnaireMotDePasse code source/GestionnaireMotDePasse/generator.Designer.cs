namespace GestionnaireMotDePasse
{
	partial class generator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		/// <Slider Name="mySlider" Margin="10"
		/// Minimum="1" Maximum="100"
        /// AutoToolTipPlacement="BottomRight"/>
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.min = new System.Windows.Forms.CheckBox();
			this.maj = new System.Windows.Forms.CheckBox();
			this.num = new System.Windows.Forms.CheckBox();
			this.sym = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.button1 = new System.Windows.Forms.Button();
			this.len = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.TextBox();
			this.use = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select the generation options";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "lowercase";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(67, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "uppercase";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(77, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "numbers";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(79, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "symbols";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(96, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "length";
			// 
			// min
			// 
			this.min.AutoSize = true;
			this.min.Checked = true;
			this.min.CheckState = System.Windows.Forms.CheckState.Checked;
			this.min.Location = new System.Drawing.Point(179, 80);
			this.min.Name = "min";
			this.min.Size = new System.Drawing.Size(15, 14);
			this.min.TabIndex = 6;
			this.min.UseVisualStyleBackColor = true;
			// 
			// maj
			// 
			this.maj.AutoSize = true;
			this.maj.Location = new System.Drawing.Point(179, 107);
			this.maj.Name = "maj";
			this.maj.Size = new System.Drawing.Size(15, 14);
			this.maj.TabIndex = 7;
			this.maj.UseVisualStyleBackColor = true;
			// 
			// num
			// 
			this.num.AutoSize = true;
			this.num.Location = new System.Drawing.Point(179, 138);
			this.num.Name = "num";
			this.num.Size = new System.Drawing.Size(15, 14);
			this.num.TabIndex = 8;
			this.num.UseVisualStyleBackColor = true;
			// 
			// sym
			// 
			this.sym.AutoSize = true;
			this.sym.Location = new System.Drawing.Point(179, 172);
			this.sym.Name = "sym";
			this.sym.Size = new System.Drawing.Size(15, 14);
			this.sym.TabIndex = 9;
			this.sym.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(169, 204);
			this.trackBar1.Maximum = 20;
			this.trackBar1.Minimum = 2;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(159, 45);
			this.trackBar1.TabIndex = 10;
			this.trackBar1.Value = 4;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(378, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// len
			// 
			this.len.Location = new System.Drawing.Point(334, 205);
			this.len.Name = "len";
			this.len.Size = new System.Drawing.Size(34, 20);
			this.len.TabIndex = 12;
			this.len.Text = "4";
			this.len.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.len_KeyPress);
			this.len.Leave += new System.EventHandler(this.len_Leave);
			// 
			// result
			// 
			this.result.Location = new System.Drawing.Point(378, 108);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(167, 20);
			this.result.TabIndex = 13;
			// 
			// use
			// 
			this.use.Location = new System.Drawing.Point(440, 150);
			this.use.Name = "use";
			this.use.Size = new System.Drawing.Size(120, 27);
			this.use.TabIndex = 14;
			this.use.Text = "Use this password";
			this.use.UseVisualStyleBackColor = true;
			this.use.Visible = false;
			this.use.Click += new System.EventHandler(this.button2_Click);
			// 
			// generator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 286);
			this.Controls.Add(this.use);
			this.Controls.Add(this.result);
			this.Controls.Add(this.len);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.sym);
			this.Controls.Add(this.num);
			this.Controls.Add(this.maj);
			this.Controls.Add(this.min);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "generator";
			this.Text = "generator";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox min;
		private System.Windows.Forms.CheckBox maj;
		private System.Windows.Forms.CheckBox num;
		private System.Windows.Forms.CheckBox sym;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox len;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Button use;
	}
}