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

    public partial class Form3 : Form2
    {

        // reuse constructor from Form2
        Form1 mainform2 = new Form1();
        public Form3(Form1 fr) : base(fr)
        {
            mainform2 = fr;
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void replacebutton_Click(object sender, EventArgs e)
        {
            mainform2.Myreplace(textBox2.Text);
        }

        private void replaceallbutton_Click(object sender, EventArgs e)
        {
            StringComparison c = StringComparison.OrdinalIgnoreCase;
            if (checkbox1.Checked)
                c = StringComparison.Ordinal;

            mainform2.Myreplaceall(textBox1.Text, textBox2.Text, c, upbutton.Checked);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
