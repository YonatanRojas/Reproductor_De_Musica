namespace Gestor_De_Musica
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Fuchsia;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(992, 370);
            button1.Name = "button1";
            button1.Size = new Size(86, 35);
            button1.TabIndex = 0;
            button1.Text = "Anterior";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAnterior_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Fuchsia;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(1229, 370);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 1;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSiguiente_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(1131, 22);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "Musica";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkGoldenrod;
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(842, 585);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.Fuchsia;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(1131, 370);
            button3.Name = "button3";
            button3.Size = new Size(54, 35);
            button3.TabIndex = 5;
            button3.Text = "Play";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_PlayPause;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 255);
            button4.Location = new Point(1069, 420);
            button4.Name = "button4";
            button4.Size = new Size(173, 60);
            button4.TabIndex = 6;
            button4.Text = "Seleccionar Carpeta";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnSeleccionarCarpeta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1422, 585);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}
