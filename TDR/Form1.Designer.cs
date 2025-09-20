namespace TDR
{
    partial class DataInput
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
            this.MorningLBL = new System.Windows.Forms.Label();
            this.AfternoonLBL = new System.Windows.Forms.Label();
            this.MorningNUD = new System.Windows.Forms.NumericUpDown();
            this.AfternoonNUD = new System.Windows.Forms.NumericUpDown();
            this.MainMenuMST = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MorningNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfternoonNUD)).BeginInit();
            this.MainMenuMST.SuspendLayout();
            this.SuspendLayout();
            // 
            // MorningLBL
            // 
            this.MorningLBL.AutoSize = true;
            this.MorningLBL.Location = new System.Drawing.Point(53, 66);
            this.MorningLBL.Name = "MorningLBL";
            this.MorningLBL.Size = new System.Drawing.Size(187, 48);
            this.MorningLBL.TabIndex = 1;
            this.MorningLBL.Text = "&Morning";
            // 
            // AfternoonLBL
            // 
            this.AfternoonLBL.AutoSize = true;
            this.AfternoonLBL.Location = new System.Drawing.Point(18, 183);
            this.AfternoonLBL.Name = "AfternoonLBL";
            this.AfternoonLBL.Size = new System.Drawing.Size(222, 48);
            this.AfternoonLBL.TabIndex = 3;
            this.AfternoonLBL.Text = "&Afternoon";
            // 
            // MorningNUD
            // 
            this.MorningNUD.AccessibleDescription = " ";
            this.MorningNUD.Location = new System.Drawing.Point(283, 61);
            this.MorningNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MorningNUD.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MorningNUD.Name = "MorningNUD";
            this.MorningNUD.Size = new System.Drawing.Size(138, 56);
            this.MorningNUD.TabIndex = 2;
            this.MorningNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MorningNUD.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // AfternoonNUD
            // 
            this.AfternoonNUD.Location = new System.Drawing.Point(283, 175);
            this.AfternoonNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.AfternoonNUD.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AfternoonNUD.Name = "AfternoonNUD";
            this.AfternoonNUD.Size = new System.Drawing.Size(138, 56);
            this.AfternoonNUD.TabIndex = 4;
            this.AfternoonNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AfternoonNUD.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // MainMenuMST
            // 
            this.MainMenuMST.AccessibleName = "Menu Bar";
            this.MainMenuMST.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MainMenuMST.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MainMenuMST.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuMST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuMST.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenuMST.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMST.Name = "MainMenuMST";
            this.MainMenuMST.Size = new System.Drawing.Size(457, 32);
            this.MainMenuMST.Stretch = false;
            this.MainMenuMST.TabIndex = 0;
            this.MainMenuMST.Text = "Main Menu";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.viewReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.readToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.readToolStripMenuItem.Text = "&Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.viewReportToolStripMenuItem.Text = "&View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(457, 257);
            this.Controls.Add(this.AfternoonNUD);
            this.Controls.Add(this.MorningNUD);
            this.Controls.Add(this.AfternoonLBL);
            this.Controls.Add(this.MorningLBL);
            this.Controls.Add(this.MainMenuMST);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.MainMenuMST;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MaximizeBox = false;
            this.Name = "DataInput";
            this.Text = "Brew for You - Temperature Data Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.MorningNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfternoonNUD)).EndInit();
            this.MainMenuMST.ResumeLayout(false);
            this.MainMenuMST.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MorningLBL;
        private System.Windows.Forms.Label AfternoonLBL;
        private System.Windows.Forms.NumericUpDown MorningNUD;
        private System.Windows.Forms.NumericUpDown AfternoonNUD;
        private System.Windows.Forms.MenuStrip MainMenuMST;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

