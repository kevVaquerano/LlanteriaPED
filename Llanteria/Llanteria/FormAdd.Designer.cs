

namespace Login2
{
    partial class FormAdd
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
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label12 = new Label();
            btnEnviar = new Button();
            txtMarca = new TextBox();
            txtRin = new TextBox();
            txtPerfil = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
           //SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(281, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 42);
            label1.TabIndex = 7;
            label1.Text = "Agregar Producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 42);
            label2.TabIndex = 8;
            label2.Text = "←";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(124, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 29);
            label3.TabIndex = 12;
            label3.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(124, 181);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 29);
            label6.TabIndex = 14;
            label6.Text = "Rin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(120, 246);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 29);
            label4.TabIndex = 17;
            label4.Text = "Perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(120, 313);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 29);
            label5.TabIndex = 19;
            label5.Text = "Precio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(92, 363);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(117, 29);
            label12.TabIndex = 21;
            label12.Text = "Cantidad";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.MintCream;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Location = new Point(764, 463);
            btnEnviar.Margin = new Padding(4, 3, 4, 3);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(155, 43);
            btnEnviar.TabIndex = 22;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(311, 117);
            txtMarca.Margin = new Padding(4, 3, 4, 3);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(293, 23);
            txtMarca.TabIndex = 23;
            // 
            // txtRin
            // 
            txtRin.Location = new Point(311, 181);
            txtRin.Margin = new Padding(4, 3, 4, 3);
            txtRin.Name = "txtRin";
            txtRin.Size = new Size(293, 23);
            txtRin.TabIndex = 24;
            // 
            // txtPerfil
            // 
            txtPerfil.Location = new Point(311, 246);
            txtPerfil.Margin = new Padding(4, 3, 4, 3);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(293, 23);
            txtPerfil.TabIndex = 25;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(311, 313);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(293, 23);
            txtPrecio.TabIndex = 26;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(311, 369);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(293, 23);
            txtCantidad.TabIndex = 27;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(933, 519);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtPerfil);
            Controls.Add(txtRin);
            Controls.Add(txtMarca);
            Controls.Add(btnEnviar);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAdd";
            Text = "Agregar Producto";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtRin;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}