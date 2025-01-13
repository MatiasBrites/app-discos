namespace App_ADO.net_Discos
{
    partial class FrmAltaDisco
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbcantidadcanciones = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.PbImagenTapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(275, 124);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(204, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(275, 162);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(204, 26);
            this.txtCantCanciones.TabIndex = 2;
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(77, 124);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(47, 20);
            this.lbtitulo.TabIndex = 3;
            this.lbtitulo.Text = "Titulo";
            // 
            // lbcantidadcanciones
            // 
            this.lbcantidadcanciones.AutoSize = true;
            this.lbcantidadcanciones.Location = new System.Drawing.Point(77, 162);
            this.lbcantidadcanciones.Name = "lbcantidadcanciones";
            this.lbcantidadcanciones.Size = new System.Drawing.Size(152, 20);
            this.lbcantidadcanciones.TabIndex = 4;
            this.lbcantidadcanciones.Text = "Cantidad Canciones";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(337, 348);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(88, 30);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(81, 348);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(84, 30);
            this.btnaceptar.TabIndex = 5;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(77, 201);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(95, 20);
            this.lblEdicion.TabIndex = 7;
            this.lblEdicion.Text = "Tipo Edicion";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(77, 240);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(48, 20);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "Estilo";
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(275, 198);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(204, 28);
            this.cboEdicion.TabIndex = 3;
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(275, 240);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(204, 28);
            this.cboEstilo.TabIndex = 4;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(77, 85);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(87, 20);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(275, 79);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(204, 26);
            this.txtUrlImagen.TabIndex = 0;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // PbImagenTapa
            // 
            this.PbImagenTapa.Location = new System.Drawing.Point(537, 79);
            this.PbImagenTapa.Name = "PbImagenTapa";
            this.PbImagenTapa.Size = new System.Drawing.Size(328, 299);
            this.PbImagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImagenTapa.TabIndex = 14;
            this.PbImagenTapa.TabStop = false;
            // 
            // FrmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.PbImagenTapa);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lbcantidadcanciones);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Name = "FrmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaDisco";
            this.Load += new System.EventHandler(this.FrmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbcantidadcanciones;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox PbImagenTapa;
    }
}