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
    public partial class Form1 : Form
    {
        Reader reader;
        DialogBox dialog;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            richTextBox1.Enabled = false;
            button2.Enabled = false;
            dialog = new DialogBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Scripts (*.kcs) | *.KCS";
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader.start();
            richTextBox1.Enabled = true;
            for (int i = 0; i < reader.getLine(); i++ )
            {
                richTextBox1.Text += reader.getOut();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reader.stop();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            button2.Enabled = true;
            reader = new Reader(openFileDialog1.FileName);
        }

        //unimplemented
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void textBox2_TextChanged(object sender, EventArgs e)
        { }
    }
}
