using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyClicker
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void sendError(String warning)
        {
            label1.Text = warning;
        }
        public void setTitle(String title)
        {
            this.Text = title;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
