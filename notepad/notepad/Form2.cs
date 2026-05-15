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
    public partial class Form2 : Form
    {
        Form1 mainform = new Form1();
        public Form2(Form1 fr)
        {
            mainform = fr;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            StringComparison matchcase = new StringComparison( );
            if (checkbox1.Checked)
                matchcase = StringComparison.CurrentCulture;
            else
                matchcase = StringComparison.CurrentCultureIgnoreCase;

            Boolean righttoleft = false;
            if (upbutton.Checked)
                righttoleft = true;
            mainform.findfunc(textBox1.Text, matchcase , righttoleft);
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
