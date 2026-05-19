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
    public partial class gotoform : Form
    {
        Form1 mainform = new Form1();
        public gotoform(Form1 frmain)
        {
            mainform = frmain;
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {

            int num_lines = mainform.Getlines();
            if ( num_lines < Convert.ToInt16( textBox1.Text)-1)
            {
                MessageBox.Show("this line does not exist");
            }
            else
            {
                mainform.Goto(Convert.ToInt16(textBox1.Text) - 1);
                this.Close();
            }
        }
    }
}
