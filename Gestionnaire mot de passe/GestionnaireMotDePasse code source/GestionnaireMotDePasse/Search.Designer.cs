namespace GestionnaireMotDePasse
{
	partial class Search
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
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.TableLayoutSearch = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(219, 26);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(130, 20);
			this.SearchBox.TabIndex = 0;
			this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			// 
			// TableLayoutSearch
			// 
			this.TableLayoutSearch.AutoScroll = true;
			this.TableLayoutSearch.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.TableLayoutSearch.ColumnCount = 1;
			this.TableLayoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutSearch.Location = new System.Drawing.Point(29, 67);
			this.TableLayoutSearch.Name = "TableLayoutSearch";
			this.TableLayoutSearch.RowCount = 1;
			this.TableLayoutSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutSearch.Size = new System.Drawing.Size(631, 201);
			this.TableLayoutSearch.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start typing to search";
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 305);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TableLayoutSearch);
			this.Controls.Add(this.SearchBox);
			this.Name = "Search";
			this.Text = "Search";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.TableLayoutPanel TableLayoutSearch;
		private System.Windows.Forms.Label label1;
	}
}