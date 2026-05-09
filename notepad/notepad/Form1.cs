using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach(ToolStripMenuItem x in backgroundToolStripMenuItem.DropDownItems)
            {
                if (((ToolStripMenuItem)sender).Text == x.Text)
                {
                    x.Checked = true;
                }
                else
                {
                    x.Checked = false;
                }
            }
        }

        private void forecolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem x in forecolorToolStripMenuItem.DropDownItems)
            {
                if (((ToolStripMenuItem)sender).Text == x.Text)
                {
                    x.Checked = true;
                }
                else
                {
                    x.Checked = false;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x=MessageBox.Show("Do you really want to exit ? ","exit?",MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
