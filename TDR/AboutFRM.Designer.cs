namespace TDR
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.CompanyTB = new System.Windows.Forms.TextBox();
            this.HelpTextTB = new System.Windows.Forms.TextBox();
            this.OKBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPB
            // 
            this.LogoPB.AccessibleDescription = "Brew for you Coffee cup logo";
            this.LogoPB.Image = global::TDR.Properties.Resources.BFYLogo;
            this.LogoPB.Location = new System.Drawing.Point(12, 18);
            this.LogoPB.Margin = new System.Windows.Forms.Padding(2);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(221, 222);
            this.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPB.TabIndex = 0;
            this.LogoPB.TabStop = false;
            // 
            // CompanyTB
            // 
            this.CompanyTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.CompanyTB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.CompanyTB.ForeColor = System.Drawing.Color.White;
            this.CompanyTB.Location = new System.Drawing.Point(249, 18);
            this.CompanyTB.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyTB.Multiline = true;
            this.CompanyTB.Name = "CompanyTB";
            this.CompanyTB.ReadOnly = true;
            this.CompanyTB.Size = new System.Drawing.Size(273, 222);
            this.CompanyTB.TabIndex = 1;
            this.CompanyTB.Text = "Brew for You\r\nTemp Recorder\r\n\r\nV6.1, 9/27/2025";
            // 
            // HelpTextTB
            // 
            this.HelpTextTB.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.HelpTextTB.Location = new System.Drawing.Point(12, 277);
            this.HelpTextTB.Multiline = true;
            this.HelpTextTB.Name = "HelpTextTB";
            this.HelpTextTB.ReadOnly = true;
            this.HelpTextTB.Size = new System.Drawing.Size(510, 259);
            this.HelpTextTB.TabIndex = 2;
            this.HelpTextTB.Text = resources.GetString("HelpTextTB.Text");
            // 
            // OKBTN
            // 
            this.OKBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBTN.Location = new System.Drawing.Point(391, 542);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKBTN.Size = new System.Drawing.Size(131, 63);
            this.OKBTN.TabIndex = 3;
            this.OKBTN.Text = "&OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.OKBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(528, 614);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.HelpTextTB);
            this.Controls.Add(this.CompanyTB);
            this.Controls.Add(this.LogoPB);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(32, 28, 32, 28);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Temperature Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.TextBox CompanyTB;
        private System.Windows.Forms.TextBox HelpTextTB;
        private System.Windows.Forms.Button OKBTN;
    }
}
