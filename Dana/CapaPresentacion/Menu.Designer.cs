namespace CapaPresentacion
{
    partial class Menu
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
            this.btnMenuVentas = new System.Windows.Forms.Button();
            this.btnMenuInventario = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnMenuProductos = new System.Windows.Forms.Button();
            this.btnMenuCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuVentas
            // 
            this.btnMenuVentas.Location = new System.Drawing.Point(78, 54);
            this.btnMenuVentas.Name = "btnMenuVentas";
            this.btnMenuVentas.Size = new System.Drawing.Size(106, 39);
            this.btnMenuVentas.TabIndex = 0;
            this.btnMenuVentas.Text = "ventas";
            this.btnMenuVentas.UseVisualStyleBackColor = true;
            this.btnMenuVentas.Click += new System.EventHandler(this.btnMenuVentas_Click);
            // 
            // btnMenuInventario
            // 
            this.btnMenuInventario.Location = new System.Drawing.Point(615, 54);
            this.btnMenuInventario.Name = "btnMenuInventario";
            this.btnMenuInventario.Size = new System.Drawing.Size(106, 39);
            this.btnMenuInventario.TabIndex = 1;
            this.btnMenuInventario.Text = "inventario";
            this.btnMenuInventario.UseVisualStyleBackColor = true;
            this.btnMenuInventario.Click += new System.EventHandler(this.btnMenuInventario_Click);
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.Location = new System.Drawing.Point(349, 214);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Size = new System.Drawing.Size(106, 39);
            this.btnMenuClientes.TabIndex = 2;
            this.btnMenuClientes.Text = "clientes";
            this.btnMenuClientes.UseVisualStyleBackColor = true;
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // btnMenuProductos
            // 
            this.btnMenuProductos.Location = new System.Drawing.Point(349, 54);
            this.btnMenuProductos.Name = "btnMenuProductos";
            this.btnMenuProductos.Size = new System.Drawing.Size(106, 39);
            this.btnMenuProductos.TabIndex = 3;
            this.btnMenuProductos.Text = "productos";
            this.btnMenuProductos.UseVisualStyleBackColor = true;
            this.btnMenuProductos.Click += new System.EventHandler(this.btnMenuProductos_Click);
            // 
            // btnMenuCompras
            // 
            this.btnMenuCompras.Location = new System.Drawing.Point(78, 214);
            this.btnMenuCompras.Name = "btnMenuCompras";
            this.btnMenuCompras.Size = new System.Drawing.Size(106, 39);
            this.btnMenuCompras.TabIndex = 4;
            this.btnMenuCompras.Text = "compras";
            this.btnMenuCompras.UseVisualStyleBackColor = true;
            this.btnMenuCompras.Click += new System.EventHandler(this.btnMenuCompras_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuCompras);
            this.Controls.Add(this.btnMenuProductos);
            this.Controls.Add(this.btnMenuClientes);
            this.Controls.Add(this.btnMenuInventario);
            this.Controls.Add(this.btnMenuVentas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuVentas;
        private System.Windows.Forms.Button btnMenuInventario;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnMenuProductos;
        private System.Windows.Forms.Button btnMenuCompras;
    }
}