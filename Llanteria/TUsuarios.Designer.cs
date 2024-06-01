namespace Login2
{
    partial class TUsuarios
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            buttonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 33);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 0;
            label1.Text = "Listado de Usuarios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(263, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 369);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 168);
            label2.Name = "label2";
            label2.Size = new Size(219, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el nombre de usuario por buscar";
            label2.Click += label2_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(52, 219);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(154, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(40, 289);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(179, 23);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar por nombre";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // TUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 555);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "TUsuarios";
            Text = "TUsuarios";
            Load += TUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBoxUsuario;
        private Button buttonBuscar;
    }
}