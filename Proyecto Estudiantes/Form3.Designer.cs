namespace Proyecto_Estudiantes
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
            label1 = new Label();
            button4 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO DE CAMILA";
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.DeepPink;
            button4.Font = new Font("Sigmar One", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(161, 37);
            button4.Name = "button4";
            button4.Size = new Size(102, 31);
            button4.TabIndex = 11;
            button4.Text = "SIGUIENTE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Sigmar One", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 37);
            button2.Name = "button2";
            button2.Size = new Size(73, 31);
            button2.TabIndex = 13;
            button2.Text = "ATRAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button2;
    }
}