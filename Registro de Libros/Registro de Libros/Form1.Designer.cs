namespace Registro_de_Libros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Editorial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Prestado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(382, 23);
            textBox3.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(85, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(379, 79);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(12, 164);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 3;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 234);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button2;
    }
}
