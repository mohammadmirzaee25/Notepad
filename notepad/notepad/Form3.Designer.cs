
namespace notepad
{
    partial class Form3
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
            this.replacebutton = new System.Windows.Forms.Button();
            this.replaceallbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replacebutton
            // 
            this.replacebutton.Location = new System.Drawing.Point(372, 93);
            this.replacebutton.Name = "replacebutton";
            this.replacebutton.Size = new System.Drawing.Size(80, 26);
            this.replacebutton.TabIndex = 6;
            this.replacebutton.Text = "replace";
            this.replacebutton.UseVisualStyleBackColor = true;
            this.replacebutton.Click += new System.EventHandler(this.replacebutton_Click);
            // 
            // replaceallbutton
            // 
            this.replaceallbutton.Location = new System.Drawing.Point(372, 125);
            this.replaceallbutton.Name = "replaceallbutton";
            this.replaceallbutton.Size = new System.Drawing.Size(80, 26);
            this.replaceallbutton.TabIndex = 7;
            this.replaceallbutton.Text = "replaceall";
            this.replaceallbutton.UseVisualStyleBackColor = true;
            this.replaceallbutton.Click += new System.EventHandler(this.replaceallbutton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "replace with";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.replaceallbutton);
            this.Controls.Add(this.replacebutton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.findbutton, 0);
            this.Controls.SetChildIndex(this.cancelbutton, 0);
            this.Controls.SetChildIndex(this.checkbox1, 0);
            this.Controls.SetChildIndex(this.replacebutton, 0);
            this.Controls.SetChildIndex(this.replaceallbutton, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button replacebutton;
        private System.Windows.Forms.Button replaceallbutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}