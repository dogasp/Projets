namespace GestionnaireMotDePasse
{
	partial class RemoveForm
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
			this.tableLayoutRemove = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(85, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(299, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select a password to delete";
			// 
			// tableLayoutRemove
			// 
			this.tableLayoutRemove.AutoScroll = true;
			this.tableLayoutRemove.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutRemove.ColumnCount = 1;
			this.tableLayoutRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutRemove.Location = new System.Drawing.Point(132, 85);
			this.tableLayoutRemove.Name = "tableLayoutRemove";
			this.tableLayoutRemove.RowCount = 2;
			this.tableLayoutRemove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutRemove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutRemove.Size = new System.Drawing.Size(179, 149);
			this.tableLayoutRemove.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(368, 262);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Confirm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// RemoveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 316);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tableLayoutRemove);
			this.Controls.Add(this.label1);
			this.Name = "RemoveForm";
			this.Text = "RemoveForm";
			this.Load += new System.EventHandler(this.RemoveForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutRemove;
		private System.Windows.Forms.Button button1;
	}
}