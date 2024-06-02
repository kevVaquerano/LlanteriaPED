namespace Login2
{
    partial class Dashboard
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
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            btnCerrarSesion = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblOrdenes = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lblUsuarios = new Label();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            lblProductos = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 130);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(173, 104);
            button6.Name = "button6";
            button6.Size = new Size(184, 23);
            button6.TabIndex = 5;
            button6.Text = "Modificar o Eliminar Llantas";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(17, 104);
            button5.Name = "button5";
            button5.Size = new Size(150, 23);
            button5.TabIndex = 4;
            button5.Text = "Agregar Llantas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(485, 63);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 1;
            button4.Text = "Base de datos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(329, 63);
            button3.Name = "button3";
            button3.Size = new Size(150, 23);
            button3.TabIndex = 3;
            button3.Text = "Ventas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 47);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // button2
            // 
            button2.Location = new Point(173, 63);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 2;
            button2.Text = "Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.HotTrack;
            btnCerrarSesion.BackgroundImage = Properties.Resources.systemusers_104569;
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = SystemColors.HotTrack;
            btnCerrarSesion.Location = new Point(736, 13);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(77, 69);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 63);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 1;
            button1.Text = "Llantas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblOrdenes);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(34, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 189);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.purchase_order_xxl;
            pictureBox1.Location = new Point(17, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblOrdenes
            // 
            lblOrdenes.AutoSize = true;
            lblOrdenes.Location = new Point(21, 156);
            lblOrdenes.Name = "lblOrdenes";
            lblOrdenes.Size = new Size(12, 15);
            lblOrdenes.TabIndex = 1;
            lblOrdenes.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 14);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Ordenes";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblUsuarios);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(285, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 189);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.user_icon;
            pictureBox2.Location = new Point(15, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(15, 156);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(12, 15);
            lblUsuarios.TabIndex = 1;
            lblUsuarios.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuarios";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lblProductos);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(549, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 189);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.clipart2979602;
            pictureBox3.Location = new Point(13, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(13, 156);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(12, 15);
            lblProductos.TabIndex = 1;
            lblProductos.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 16);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Productos";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 435);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCerrarSesion;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Label lblOrdenes;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label lblUsuarios;
        private Label lblProductos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button6;
        private Button button5;
    }
}