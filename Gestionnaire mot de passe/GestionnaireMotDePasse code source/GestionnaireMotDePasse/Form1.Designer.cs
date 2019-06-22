namespace GestionnaireMotDePasse
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.TopPanel = new System.Windows.Forms.Panel();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.userName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutpanel = new System.Windows.Forms.TableLayoutPanel();
			this.applicationsPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TopPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.TopPanel.Controls.Add(this.buttonQuit);
			this.TopPanel.Controls.Add(this.label1);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(825, 48);
			this.TopPanel.TabIndex = 0;
			this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
			this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
			this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
			// 
			// buttonQuit
			// 
			this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
			this.buttonQuit.BackgroundImage = global::GestionnaireMotDePasse.Properties.Resources.exit_icon;
			this.buttonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonQuit.FlatAppearance.BorderSize = 0;
			this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonQuit.ForeColor = System.Drawing.Color.Transparent;
			this.buttonQuit.Location = new System.Drawing.Point(782, 3);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(31, 33);
			this.buttonQuit.TabIndex = 1;
			this.buttonQuit.UseVisualStyleBackColor = false;
			this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(239, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Password Manager";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 48);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(825, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAPasswordToolStripMenuItem,
            this.findToolStripMenuItem,
            this.applicationsPasswordToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fichierToolStripMenuItem.Text = "File";
			// 
			// addAPasswordToolStripMenuItem
			// 
			this.addAPasswordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.resetToolStripMenuItem});
			this.addAPasswordToolStripMenuItem.Name = "addAPasswordToolStripMenuItem";
			this.addAPasswordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.addAPasswordToolStripMenuItem.Text = "Manage Password";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.findToolStripMenuItem.Text = "Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.7019F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.password, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.userName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 32);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(662, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "Copy password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(522, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 32);
			this.label2.TabIndex = 5;
			this.label2.Text = "Show Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Dock = System.Windows.Forms.DockStyle.Fill;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(356, 0);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(160, 32);
			this.password.TabIndex = 2;
			this.password.Text = "Password";
			this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// userName
			// 
			this.userName.AutoSize = true;
			this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userName.Location = new System.Drawing.Point(171, 0);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(179, 32);
			this.userName.TabIndex = 1;
			this.userName.Text = "User Name";
			this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Web Site";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutpanel
			// 
			this.tableLayoutpanel.AutoScroll = true;
			this.tableLayoutpanel.AutoScrollMinSize = new System.Drawing.Size(0, 382);
			this.tableLayoutpanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutpanel.ColumnCount = 2;
			this.tableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutpanel.Location = new System.Drawing.Point(0, 104);
			this.tableLayoutpanel.Name = "tableLayoutpanel";
			this.tableLayoutpanel.RowCount = 2;
			this.tableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutpanel.Size = new System.Drawing.Size(825, 382);
			this.tableLayoutpanel.TabIndex = 3;
			// 
			// applicationsPasswordToolStripMenuItem
			// 
			this.applicationsPasswordToolStripMenuItem.Name = "applicationsPasswordToolStripMenuItem";
			this.applicationsPasswordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.applicationsPasswordToolStripMenuItem.Text = "Application\'s password";
			this.applicationsPasswordToolStripMenuItem.Click += new System.EventHandler(this.applicationsPasswordToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(825, 486);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutpanel);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Opacity = 0.95D;
			this.Text = "Form1";
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAPasswordToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label userName;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutpanel;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem applicationsPasswordToolStripMenuItem;
	}
}

