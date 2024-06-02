namespace LlanteriaPED
{
    partial class FormVentas
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            label10 = new Label();
            button2 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 123);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Marca";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 199);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 6;
            label2.Text = "Rin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 275);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 8;
            label3.Text = "Perfil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 350);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 439);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 12;
            label5.Text = "Precio Unitario:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 123);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 14;
            label6.Text = "Cliente";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 484);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 15;
            label7.Text = "Total:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(47, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(47, 217);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(294, 23);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(47, 296);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(294, 23);
            comboBox3.TabIndex = 18;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(47, 368);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(294, 23);
            comboBox4.TabIndex = 19;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(436, 141);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(309, 23);
            comboBox5.TabIndex = 20;
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(115, 469);
            label9.MaximumSize = new Size(700, 100);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(226, 30);
            label9.TabIndex = 22;
            label9.Text = "$100.00";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(133, 424);
            label8.MaximumSize = new Size(700, 100);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(208, 30);
            label8.TabIndex = 23;
            label8.Text = "$100.00";
            label8.Click += label8_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(436, 526);
            button1.Name = "button1";
            button1.Size = new Size(309, 23);
            button1.TabIndex = 24;
            button1.Text = "Imprimir Recibo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(229, 34);
            label10.Name = "label10";
            label10.Size = new Size(311, 50);
            label10.TabIndex = 25;
            label10.Text = "Sistema de Venta";
            label10.Click += label10_Click;
            // 
            // button2
            // 
            button2.Location = new Point(47, 526);
            button2.Name = "button2";
            button2.Size = new Size(294, 23);
            button2.TabIndex = 26;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // listView1
            // 
            listView1.Location = new Point(436, 193);
            listView1.Name = "listView1";
            listView1.Size = new Size(309, 306);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label9;
        private Label label8;
        private Button button1;
        private Label label10;
        private Button button2;
        private ListView listView1;
    }
}
