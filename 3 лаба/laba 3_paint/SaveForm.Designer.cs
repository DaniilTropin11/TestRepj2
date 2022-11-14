namespace laba_3_paint
{
    partial class SaveForm
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
            this.NameFile = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.OK_button1 = new System.Windows.Forms.Button();
            this.Cancel_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Location = new System.Drawing.Point(224, 100);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(89, 20);
            this.NameFile.TabIndex = 0;
            this.NameFile.Text = "Имя файла:";
            this.NameFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(224, 152);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(71, 20);
            this.W.TabIndex = 1;
            this.W.Text = "Ширина ";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(224, 217);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(57, 20);
            this.H.TabIndex = 2;
            this.H.Text = "Длина ";
            this.H.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(329, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 27);
            this.textBox3.TabIndex = 5;
            // 
            // OK_button1
            // 
            this.OK_button1.Location = new System.Drawing.Point(201, 274);
            this.OK_button1.Name = "OK_button1";
            this.OK_button1.Size = new System.Drawing.Size(94, 29);
            this.OK_button1.TabIndex = 6;
            this.OK_button1.Text = "OK";
            this.OK_button1.UseVisualStyleBackColor = true;
            this.OK_button1.Click += new System.EventHandler(this.OK_button1_Click);
            // 
            // Cancel_button2
            // 
            this.Cancel_button2.Location = new System.Drawing.Point(358, 274);
            this.Cancel_button2.Name = "Cancel_button2";
            this.Cancel_button2.Size = new System.Drawing.Size(94, 29);
            this.Cancel_button2.TabIndex = 7;
            this.Cancel_button2.Text = "CANCEL";
            this.Cancel_button2.UseVisualStyleBackColor = true;
            this.Cancel_button2.Click += new System.EventHandler(this.Cancel_button2_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel_button2);
            this.Controls.Add(this.OK_button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.H);
            this.Controls.Add(this.W);
            this.Controls.Add(this.NameFile);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameFile;
        private Label W;
        private Label H;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button OK_button1;
        private Button Cancel_button2;
    }
}