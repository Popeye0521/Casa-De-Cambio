namespace Casa_De_Cambio
{
    partial class frmCasadeCambio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.grpDatospersonales = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpConversión = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblValordelCanje = new System.Windows.Forms.Label();
            this.lblCantidadCambiar = new System.Windows.Forms.Label();
            this.txtValordelCanje = new System.Windows.Forms.TextBox();
            this.txtCantidadCambiar = new System.Windows.Forms.TextBox();
            this.grpTipodeMoneda = new System.Windows.Forms.GroupBox();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.rbdBTC = new System.Windows.Forms.RadioButton();
            this.rbdTransferencia = new System.Windows.Forms.RadioButton();
            this.rbdCheque = new System.Windows.Forms.RadioButton();
            this.rbdEfectivo = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRECIBO = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.grpDatospersonales.SuspendLayout();
            this.grpConversión.SuspendLayout();
            this.grpTipodeMoneda.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Items.AddRange(new object[] {
            ""});
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(244, 42);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(121, 24);
            this.cmbMonedaOrigen.TabIndex = 8;
            // 
            // grpDatospersonales
            // 
            this.grpDatospersonales.Controls.Add(this.cmbCiudad);
            this.grpDatospersonales.Controls.Add(this.lblApellido);
            this.grpDatospersonales.Controls.Add(this.lblTelefono);
            this.grpDatospersonales.Controls.Add(this.lblNombre);
            this.grpDatospersonales.Controls.Add(this.lblDirección);
            this.grpDatospersonales.Controls.Add(this.lblCiudad);
            this.grpDatospersonales.Controls.Add(this.txtTelefono);
            this.grpDatospersonales.Controls.Add(this.txtApellido);
            this.grpDatospersonales.Controls.Add(this.txtDirección);
            this.grpDatospersonales.Controls.Add(this.txtNombre);
            this.grpDatospersonales.Location = new System.Drawing.Point(88, 38);
            this.grpDatospersonales.Name = "grpDatospersonales";
            this.grpDatospersonales.Size = new System.Drawing.Size(846, 215);
            this.grpDatospersonales.TabIndex = 1;
            this.grpDatospersonales.TabStop = false;
            this.grpDatospersonales.Text = "Datos Personales";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(142, 141);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 24);
            this.cmbCiudad.TabIndex = 12;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(511, 38);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(511, 112);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.BackColor = System.Drawing.Color.Beige;
            this.lblDirección.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblDirección.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDirección.Location = new System.Drawing.Point(41, 89);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(64, 16);
            this.lblDirección.TabIndex = 8;
            this.lblDirección.Text = "Dirección";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(41, 144);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(50, 16);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(655, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(655, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(142, 89);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(100, 22);
            this.txtDirección.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // grpConversión
            // 
            this.grpConversión.Controls.Add(this.btnCambiar);
            this.grpConversión.Controls.Add(this.lblValordelCanje);
            this.grpConversión.Controls.Add(this.lblCantidadCambiar);
            this.grpConversión.Controls.Add(this.txtValordelCanje);
            this.grpConversión.Controls.Add(this.txtCantidadCambiar);
            this.grpConversión.Location = new System.Drawing.Point(629, 270);
            this.grpConversión.Name = "grpConversión";
            this.grpConversión.Size = new System.Drawing.Size(414, 227);
            this.grpConversión.TabIndex = 2;
            this.grpConversión.TabStop = false;
            this.grpConversión.Text = "conversión";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(216, 167);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(107, 40);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblValordelCanje
            // 
            this.lblValordelCanje.AutoSize = true;
            this.lblValordelCanje.Location = new System.Drawing.Point(35, 114);
            this.lblValordelCanje.Name = "lblValordelCanje";
            this.lblValordelCanje.Size = new System.Drawing.Size(99, 16);
            this.lblValordelCanje.TabIndex = 8;
            this.lblValordelCanje.Text = "Valor del Canje";
            // 
            // lblCantidadCambiar
            // 
            this.lblCantidadCambiar.AutoSize = true;
            this.lblCantidadCambiar.Location = new System.Drawing.Point(22, 59);
            this.lblCantidadCambiar.Name = "lblCantidadCambiar";
            this.lblCantidadCambiar.Size = new System.Drawing.Size(161, 16);
            this.lblCantidadCambiar.TabIndex = 7;
            this.lblCantidadCambiar.Text = "Cantidad Valor a Cambiar";
            // 
            // txtValordelCanje
            // 
            this.txtValordelCanje.Location = new System.Drawing.Point(223, 111);
            this.txtValordelCanje.Name = "txtValordelCanje";
            this.txtValordelCanje.Size = new System.Drawing.Size(100, 22);
            this.txtValordelCanje.TabIndex = 2;
            // 
            // txtCantidadCambiar
            // 
            this.txtCantidadCambiar.Location = new System.Drawing.Point(223, 59);
            this.txtCantidadCambiar.Name = "txtCantidadCambiar";
            this.txtCantidadCambiar.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadCambiar.TabIndex = 1;
            // 
            // grpTipodeMoneda
            // 
            this.grpTipodeMoneda.Controls.Add(this.lblMonedaDestino);
            this.grpTipodeMoneda.Controls.Add(this.lblMonedaOrigen);
            this.grpTipodeMoneda.Controls.Add(this.cmbMonedaDestino);
            this.grpTipodeMoneda.Controls.Add(this.rbdBTC);
            this.grpTipodeMoneda.Controls.Add(this.rbdTransferencia);
            this.grpTipodeMoneda.Controls.Add(this.rbdCheque);
            this.grpTipodeMoneda.Controls.Add(this.rbdEfectivo);
            this.grpTipodeMoneda.Controls.Add(this.cmbMonedaOrigen);
            this.grpTipodeMoneda.Location = new System.Drawing.Point(88, 270);
            this.grpTipodeMoneda.Name = "grpTipodeMoneda";
            this.grpTipodeMoneda.Size = new System.Drawing.Size(444, 227);
            this.grpTipodeMoneda.TabIndex = 2;
            this.grpTipodeMoneda.TabStop = false;
            this.grpTipodeMoneda.Text = "Tipo de Moneda";
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Location = new System.Drawing.Point(83, 98);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(109, 16);
            this.lblMonedaDestino.TabIndex = 7;
            this.lblMonedaDestino.Text = "Moneda Destino ";
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.Location = new System.Drawing.Point(83, 45);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(100, 16);
            this.lblMonedaOrigen.TabIndex = 6;
            this.lblMonedaOrigen.Text = "Moneda Origen";
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Location = new System.Drawing.Point(244, 90);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(121, 24);
            this.cmbMonedaDestino.TabIndex = 5;
            // 
            // rbdBTC
            // 
            this.rbdBTC.AutoSize = true;
            this.rbdBTC.Location = new System.Drawing.Point(244, 187);
            this.rbdBTC.Name = "rbdBTC";
            this.rbdBTC.Size = new System.Drawing.Size(55, 20);
            this.rbdBTC.TabIndex = 4;
            this.rbdBTC.TabStop = true;
            this.rbdBTC.Text = "BTC";
            this.rbdBTC.UseVisualStyleBackColor = true;
            // 
            // rbdTransferencia
            // 
            this.rbdTransferencia.AutoSize = true;
            this.rbdTransferencia.Location = new System.Drawing.Point(244, 146);
            this.rbdTransferencia.Name = "rbdTransferencia";
            this.rbdTransferencia.Size = new System.Drawing.Size(111, 20);
            this.rbdTransferencia.TabIndex = 3;
            this.rbdTransferencia.TabStop = true;
            this.rbdTransferencia.Text = "Transferencia";
            this.rbdTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbdCheque
            // 
            this.rbdCheque.AutoSize = true;
            this.rbdCheque.Location = new System.Drawing.Point(86, 187);
            this.rbdCheque.Name = "rbdCheque";
            this.rbdCheque.Size = new System.Drawing.Size(75, 20);
            this.rbdCheque.TabIndex = 2;
            this.rbdCheque.TabStop = true;
            this.rbdCheque.Text = "Cheque";
            this.rbdCheque.UseVisualStyleBackColor = true;
            // 
            // rbdEfectivo
            // 
            this.rbdEfectivo.AutoSize = true;
            this.rbdEfectivo.Location = new System.Drawing.Point(86, 146);
            this.rbdEfectivo.Name = "rbdEfectivo";
            this.rbdEfectivo.Size = new System.Drawing.Size(76, 20);
            this.rbdEfectivo.TabIndex = 1;
            this.rbdEfectivo.TabStop = true;
            this.rbdEfectivo.Text = "Efectivo";
            this.rbdEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(654, 545);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 45);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnRECIBO
            // 
            this.btnRECIBO.Location = new System.Drawing.Point(902, 536);
            this.btnRECIBO.Name = "btnRECIBO";
            this.btnRECIBO.Size = new System.Drawing.Size(118, 43);
            this.btnRECIBO.TabIndex = 4;
            this.btnRECIBO.Text = "RECIBO";
            this.btnRECIBO.UseVisualStyleBackColor = true;
            this.btnRECIBO.Click += new System.EventHandler(this.btnRECIBO_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(378, 545);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(113, 45);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.Text = "RESTAURAR";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // frmCasadeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnRECIBO);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpConversión);
            this.Controls.Add(this.grpTipodeMoneda);
            this.Controls.Add(this.grpDatospersonales);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "frmCasadeCambio";
            this.Text = "Casa De Cambio";
            this.grpDatospersonales.ResumeLayout(false);
            this.grpDatospersonales.PerformLayout();
            this.grpConversión.ResumeLayout(false);
            this.grpConversión.PerformLayout();
            this.grpTipodeMoneda.ResumeLayout(false);
            this.grpTipodeMoneda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.GroupBox grpDatospersonales;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpConversión;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblValordelCanje;
        private System.Windows.Forms.Label lblCantidadCambiar;
        private System.Windows.Forms.TextBox txtValordelCanje;
        private System.Windows.Forms.TextBox txtCantidadCambiar;
        private System.Windows.Forms.GroupBox grpTipodeMoneda;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.RadioButton rbdBTC;
        private System.Windows.Forms.RadioButton rbdTransferencia;
        private System.Windows.Forms.RadioButton rbdCheque;
        private System.Windows.Forms.RadioButton rbdEfectivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRECIBO;
        private System.Windows.Forms.Button btnRestaurar;
    }
}

