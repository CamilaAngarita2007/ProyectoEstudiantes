namespace Proyecto_Estudiantes
{
    public partial class Form1 : Form
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 33);
            label1.TabIndex = 1;
            label1.Text = "SISTEMA DE ESTUDIANTES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Shrikhand", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 108);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 2;
            label2.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Shrikhand", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 69);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 67);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 106);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.Font = new Font("Wendy One", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(68, 167);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Wendy One", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(199, 167);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepPink;
            button3.Font = new Font("Wendy One", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(338, 167);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 8;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
