namespace Login2
{
    partial class TLlantas
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBoxMarca = new TextBox();
            buttonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 335);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 26);
            label1.Name = "label1";
            label1.Size = new Size(254, 30);
            label1.TabIndex = 1;
            label1.Text = "Información de Llantas ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 203);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el nombre por marca: ";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(51, 230);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(179, 23);
            textBoxMarca.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(66, 315);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(141, 23);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar por marca";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // TLlantas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 503);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxMarca);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "TLlantas";
            Text = "TLlantas";
            Load += TLlantas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBoxMarca;
        private Button buttonBuscar;
    }
}