using System;
using System.Windows.Forms;

namespace TDR
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
