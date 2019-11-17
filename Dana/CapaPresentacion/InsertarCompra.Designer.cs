namespace CapaPresentacion
{
    partial class InsertarCompra
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.consulProduct = new System.Windows.Forms.DataGridView();
            this.consulDetalle = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consulProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(170, 36);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(35, 86);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // consulProduct
            // 
            this.consulProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consulProduct.Location = new System.Drawing.Point(410, 20);
            this.consulProduct.Name = "consulProduct";
            this.consulProduct.Size = new System.Drawing.Size(316, 214);
            this.consulProduct.TabIndex = 4;
            // 
            // consulDetalle
            // 
            this.consulDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consulDetalle.Location = new System.Drawing.Point(25, 182);
            this.consulDetalle.Name = "consulDetalle";
            this.consulDetalle.Size = new System.Drawing.Size(305, 221);
            this.consulDetalle.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InsertarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consulDetalle);
            this.Controls.Add(this.consulProduct);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "InsertarCompra";
            this.Text = "InsertarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.consulProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView consulProduct;
        private System.Windows.Forms.DataGridView consulDetalle;
        private System.Windows.Forms.Button button1;
    }
}