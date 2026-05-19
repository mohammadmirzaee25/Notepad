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
            if (((ToolStripMenuItem)sender).Text != "Custom")
            {
                textBox1.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
                foreach (ToolStripMenuItem x in backgroundToolStripMenuItem.DropDownItems)
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
            else
            {
                foreach (ToolStripMenuItem x in backgroundToolStripMenuItem.DropDownItems)
                {
                    x.Checked = false;
                }
                customToolStripMenuItem.Checked = true;
                colorDialog1.FullOpen = true;
                colorDialog1.ShowDialog();
                textBox1.BackColor = colorDialog1.Color;

            }
        }

        private void forecolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Text != "Custom")
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
            else
            {
                foreach (ToolStripMenuItem x in forecolorToolStripMenuItem.DropDownItems)
                {
                    x.Checked = false;
                }
                customToolStripMenuItem1.Checked = true;
                colorDialog1.FullOpen = true;
                colorDialog1.ShowDialog();
                textBox1.ForeColor = colorDialog1.Color;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Do you really want to exit ? ", "exit?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void showStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showStatusToolStripMenuItem.Checked = !showStatusToolStripMenuItem.Checked;
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.IO.File.WriteAllText("configs.txt", textBox1.BackColor.Name);
            string[] x = new string[5];
            x[0] = textBox1.BackColor.Name;

            x[1] = textBox1.Font.Name;

            x[2] = textBox1.Font.Size.ToString();

            x[3] = this.Height.ToString();

            x[4] = this.Width.ToString();

            System.IO.File.WriteAllLines("myfileconfig.txt", x);
            newToolStripMenuItem_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string c;
            //  c=System.IO.File.ReadAllText("configs.txt");
            // textBox1.BackColor = Color.FromName(c);
            string[] x = new string[5];

            if (System.IO.File.Exists("myfileconfig.txt")){

                x = System.IO.File.ReadAllLines("myfileconfig.txt");
                textBox1.BackColor = Color.FromName(x[0]);
                textBox1.Font = new Font(x[1], Convert.ToInt16(x[2]);

                this.Height = Convert.ToInt16(x[3]);
                this.Width = Convert.ToInt16(x[4]);
            }
            saved = true;
            notepadundo.SetText(textBox1.Text);

        }
        public string filename = null;
        public bool saved = false;

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == null)
            {
                DialogResult r = new DialogResult();
                saveFileDialog1.Filter = "text file|*.txt|document file |*.doc |allfile |*.*";
                saveFileDialog1.DefaultExt = "txt";
                r = saveFileDialog1.ShowDialog();
                if (DialogResult.Cancel == r)
                    return;
                filename = saveFileDialog1.FileName;

            }
            System.IO.File.WriteAllText(filename, textBox1.Text);
            saved = true;
            this.Text = filename;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            set_col_row();

            if (!internalChange)
            {
                notepadundo.SetText(textBox1.Text);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                DialogResult r;
                r = MessageBox.Show("do you want to save", "Save file?", MessageBoxButtons.YesNoCancel);
                if (r == DialogResult.Cancel)
                    return;
                if (r == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            saved = true;
            filename = null;
            textBox1.Text = "";
            this.Text = "form 1";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (saved == false)
                newToolStripMenuItem_Click(null, null);

            DialogResult r = new DialogResult();
            openFileDialog1.Filter = "text file|*.txt|document file |*.doc |allfile |*.*";
            r = openFileDialog1.ShowDialog();
            if (r == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            this.Text = filename;
            textBox1.Text = System.IO.File.ReadAllText(filename);
            saved = true;


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filename = null;
            saveToolStripMenuItem_Click(null, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.SelectedText))
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText = "";
            }
        }


        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                textBox1.SelectedText = Clipboard.GetText();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(this);
            form2.Show(this);
        }
        public bool findfunc(string s, StringComparison matchcase, bool righttoleft)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                MessageBox.Show("Enter text to search.");
                return false;
            }

            int startIndex;
            int start = -1;

            if (!righttoleft) // Forward search
            {
                startIndex = textBox1.SelectionStart + textBox1.SelectionLength;

                if (startIndex >= textBox1.Text.Length)
                    startIndex = 0;

                start = textBox1.Text.IndexOf(s, startIndex, matchcase);
            }
            else // Backward search
            {
                startIndex = textBox1.SelectionStart - 1;

                if (startIndex < 0)
                    startIndex = textBox1.Text.Length - 1;

                start = textBox1.Text.LastIndexOf(s, startIndex, matchcase);
            }

            if (start == -1)
            {
                MessageBox.Show("Not found");
                return false;
            }

            textBox1.SelectionStart = start;
            textBox1.SelectionLength = s.Length;
            textBox1.Focus();
            return true;
        }
        MyUndo notepadundo = new MyUndo();
        private bool internalChange = false; // Flag to prevent loops

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentSelectionStart = textBox1.SelectionStart;
            int currentSelectionLength = textBox1.SelectionLength;

            string undoneText = notepadundo.Undo();

            if (undoneText != null)
            {
                internalChange = true;
                textBox1.Text = undoneText;
                int newSelectionStart = Math.Min(currentSelectionStart, textBox1.Text.Length);
                textBox1.Select(newSelectionStart, currentSelectionLength);
                internalChange = false;
            }
        }

        public class MyUndo
        {
            private string[] temp = new string[100];
            private int index;
            private int currentPosition;

            public MyUndo()
            {
                index = 0;
                currentPosition = 0;
            }

            public void SetText(string s)
            {
                index = currentPosition + 1;

                if (index >= 100)
                {
                    return;
                }

                temp[index] = s;
                currentPosition = index;
                index++;
            }

            public string Undo()
            {
                if (currentPosition > 0)
                {
                    return temp[--currentPosition];
                }
                return null;
            }

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show(this);
        }

        public void Myreplace(string s)
        {

            if (textBox1.SelectedText.Length > 0)
            {
                textBox1.SelectedText = s;
            }
        }
        public void Myreplaceall(string s, string str2, StringComparison cmptype, Boolean lefttoright)
        {
            while (findfunc(s, cmptype, lefttoright))
            {
                Myreplace(str2);
            }
        }

        public int Getlines()
        {
            return textBox1.Lines.Length;
        }
        public void Goto(int line)
        {
            textBox1.SelectionStart = textBox1.GetFirstCharIndexFromLine(line);
          
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoform f3 = new gotoform(this);
            f3.ShowDialog();
        }
        public void set_col_row()
        {
            int cursorPos = textBox1.SelectionStart;
            int line = textBox1.GetLineFromCharIndex(cursorPos) ;
            int column = cursorPos - textBox1.GetFirstCharIndexFromLine(line);

            toolStripStatusLabel1.Text = $"Line: {line + 1}, Column: {column + 1}";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            set_col_row();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            set_col_row();
        }

        public void setitemmenues_enabled()
        {
            copyToolStripMenuItem.Enabled = Convert.ToBoolean(textBox1.SelectionLength);
            cutToolStripMenuItem.Enabled = (textBox1.SelectionLength > 0);


            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();


            findToolStripMenuItem.Enabled = textBox1.Text.Length > 0;
            gotoToolStripMenuItem.Enabled = textBox1.Text.Length > 0;

            saveAsToolStripMenuItem.Enabled = !saved;
        }
        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            setitemmenues_enabled();
        }


    }
}
