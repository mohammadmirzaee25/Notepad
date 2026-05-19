
namespace notepad
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downbutton = new System.Windows.Forms.RadioButton();
            this.upbutton = new System.Windows.Forms.RadioButton();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "find what";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 23);
            this.textBox1.TabIndex = 1;
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(372, 29);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(80, 26);
            this.findbutton.TabIndex = 2;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(372, 61);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(80, 26);
            this.cancelbutton.TabIndex = 3;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downbutton);
            this.groupBox1.Controls.Add(this.upbutton);
            this.groupBox1.Location = new System.Drawing.Point(206, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "direction";
            // 
            // downbutton
            // 
            this.downbutton.AutoSize = true;
            this.downbutton.Location = new System.Drawing.Point(58, 19);
            this.downbutton.Name = "downbutton";
            this.downbutton.Size = new System.Drawing.Size(55, 19);
            this.downbutton.TabIndex = 1;
            this.downbutton.Text = "down";
            this.downbutton.UseVisualStyleBackColor = true;
            // 
            // upbutton
            // 
            this.upbutton.AutoSize = true;
            this.upbutton.Checked = true;
            this.upbutton.Location = new System.Drawing.Point(16, 19);
            this.upbutton.Name = "upbutton";
            this.upbutton.Size = new System.Drawing.Size(40, 19);
            this.upbutton.TabIndex = 0;
            this.upbutton.TabStop = true;
            this.upbutton.Text = "Up";
            this.upbutton.UseVisualStyleBackColor = true;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(12, 105);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(86, 19);
            this.checkbox1.TabIndex = 5;
            this.checkbox1.Text = "match case";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 178);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Button findbutton;
        protected System.Windows.Forms.Button cancelbutton;
        protected System.Windows.Forms.RadioButton downbutton;
        protected System.Windows.Forms.RadioButton upbutton;
        protected System.Windows.Forms.CheckBox checkbox1;
    }
}