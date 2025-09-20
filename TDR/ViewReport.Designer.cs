namespace TDR
{
    partial class ViewReport
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
            this.ReportRTB = new System.Windows.Forms.RichTextBox();
            this.OKBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportRTB
            // 
            this.ReportRTB.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportRTB.Location = new System.Drawing.Point(18, 22);
            this.ReportRTB.Name = "ReportRTB";
            this.ReportRTB.ReadOnly = true;
            this.ReportRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ReportRTB.Size = new System.Drawing.Size(483, 456);
            this.ReportRTB.TabIndex = 0;
            this.ReportRTB.Text = "";
            this.ReportRTB.WordWrap = false;
            // 
            // OKBTN
            // 
            this.OKBTN.ForeColor = System.Drawing.Color.Black;
            this.OKBTN.Location = new System.Drawing.Point(375, 484);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(126, 57);
            this.OKBTN.TabIndex = 1;
            this.OKBTN.Text = "&OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // ViewReport
            // 
            this.AcceptButton = this.OKBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(518, 553);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.ReportRTB);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "ViewReport";
            this.Text = "Temperature Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReportRTB;
        private System.Windows.Forms.Button OKBTN;
    }
}