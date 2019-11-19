namespace CapaPresentacion
{
    partial class Ventas
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
            this.id_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.apellidoCliente = new System.Windows.Forms.TextBox();
            this.buscarCliente = new System.Windows.Forms.Button();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.cantidadProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_Cliente
            // 
            this.id_Cliente.Location = new System.Drawing.Point(12, 33);
            this.id_Cliente.Name = "id_Cliente";
            this.id_Cliente.Size = new System.Drawing.Size(100, 20);
            this.id_Cliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(249, 33);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(100, 20);
            this.nombreCliente.TabIndex = 2;
            this.nombreCliente.Text = "Nombre";
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.Location = new System.Drawing.Point(395, 33);
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.apellidoCliente.TabIndex = 3;
            this.apellidoCliente.Text = "Apellido";
            // 
            // buscarCliente
            // 
            this.buscarCliente.Location = new System.Drawing.Point(127, 33);
            this.buscarCliente.Name = "buscarCliente";
            this.buscarCliente.Size = new System.Drawing.Size(75, 23);
            this.buscarCliente.TabIndex = 4;
            this.buscarCliente.Text = "Buscar";
            this.buscarCliente.UseVisualStyleBackColor = true;
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(12, 98);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(121, 21);
            this.comboProducto.TabIndex = 5;
            this.comboProducto.Text = "Producto";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.Location = new System.Drawing.Point(165, 99);
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Size = new System.Drawing.Size(24, 20);
            this.cantidadProducto.TabIndex = 6;
            this.cantidadProducto.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad";
            // 
            // agregarProducto
            // 
            this.agregarProducto.Location = new System.Drawing.Point(249, 99);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(75, 23);
            this.agregarProducto.TabIndex = 8;
            this.agregarProducto.Text = "Agregar";
            this.agregarProducto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 252);
            this.dataGridView1.TabIndex = 9;
            // 
            // facturar
            // 
            this.facturar.Location = new System.Drawing.Point(707, 410);
            this.facturar.Name = "facturar";
            this.facturar.Size = new System.Drawing.Size(75, 23);
            this.facturar.TabIndex = 10;
            this.facturar.Text = "Facturar";
            this.facturar.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.facturar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.agregarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidadProducto);
            this.Controls.Add(this.comboProducto);
            this.Controls.Add(this.buscarCliente);
            this.Controls.Add(this.apellidoCliente);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_Cliente);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.TextBox apellidoCliente;
        private System.Windows.Forms.Button buscarCliente;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.TextBox cantidadProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button facturar;
    }
}