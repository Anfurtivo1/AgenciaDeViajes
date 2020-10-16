namespace AgenciaDeViajes
{
    partial class frmFormularioPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioPrincipal));
            this.lstiListaimagenesDestino = new System.Windows.Forms.ImageList(this.components);
            this.chlbActividadesExtras = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mncCalendarioFecha = new System.Windows.Forms.MonthCalendar();
            this.rbtnSoloDormir = new System.Windows.Forms.RadioButton();
            this.rbtnPensionCompleta = new System.Windows.Forms.RadioButton();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numudPersonas = new System.Windows.Forms.NumericUpDown();
            this.numudEstrellas = new System.Windows.Forms.NumericUpDown();
            this.txbCalculos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtnMediaPension = new System.Windows.Forms.RadioButton();
            this.strBarraAbajo = new System.Windows.Forms.StatusStrip();
            this.stlImagen = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlCorreo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsprbBarraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.stlFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBarraArriba = new System.Windows.Forms.ToolStrip();
            this.btnAcuerdoEmpresa = new System.Windows.Forms.ToolStripButton();
            this.btnPrecios = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numudPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudEstrellas)).BeginInit();
            this.strBarraAbajo.SuspendLayout();
            this.tsBarraArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstiListaimagenesDestino
            // 
            this.lstiListaimagenesDestino.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstiListaimagenesDestino.ImageStream")));
            this.lstiListaimagenesDestino.TransparentColor = System.Drawing.Color.Transparent;
            this.lstiListaimagenesDestino.Images.SetKeyName(0, "ImagenCiudad.jpg");
            this.lstiListaimagenesDestino.Images.SetKeyName(1, "ImagenMontaña.jpg");
            this.lstiListaimagenesDestino.Images.SetKeyName(2, "ImagenPlaya.jpg");
            this.lstiListaimagenesDestino.Images.SetKeyName(3, "ImagenTour.jpg");
            // 
            // chlbActividadesExtras
            // 
            this.chlbActividadesExtras.FormattingEnabled = true;
            this.chlbActividadesExtras.Items.AddRange(new object[] {
            "Cena y Espectáculo",
            "Excursiones",
            "Lavandería",
            "NaturAventura",
            "Spa"});
            this.chlbActividadesExtras.Location = new System.Drawing.Point(770, 57);
            this.chlbActividadesExtras.Name = "chlbActividadesExtras";
            this.chlbActividadesExtras.Size = new System.Drawing.Size(120, 79);
            this.chlbActividadesExtras.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkGreen;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(130, 177);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(154, 144);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mncCalendarioFecha
            // 
            this.mncCalendarioFecha.Location = new System.Drawing.Point(454, 155);
            this.mncCalendarioFecha.Name = "mncCalendarioFecha";
            this.mncCalendarioFecha.TabIndex = 2;
            // 
            // rbtnSoloDormir
            // 
            this.rbtnSoloDormir.AutoSize = true;
            this.rbtnSoloDormir.Location = new System.Drawing.Point(154, 194);
            this.rbtnSoloDormir.Name = "rbtnSoloDormir";
            this.rbtnSoloDormir.Size = new System.Drawing.Size(79, 17);
            this.rbtnSoloDormir.TabIndex = 3;
            this.rbtnSoloDormir.TabStop = true;
            this.rbtnSoloDormir.Text = "Solo Dormir";
            this.rbtnSoloDormir.UseVisualStyleBackColor = true;
            // 
            // rbtnPensionCompleta
            // 
            this.rbtnPensionCompleta.AutoSize = true;
            this.rbtnPensionCompleta.Location = new System.Drawing.Point(154, 273);
            this.rbtnPensionCompleta.Name = "rbtnPensionCompleta";
            this.rbtnPensionCompleta.Size = new System.Drawing.Size(109, 17);
            this.rbtnPensionCompleta.TabIndex = 5;
            this.rbtnPensionCompleta.TabStop = true;
            this.rbtnPensionCompleta.Text = "Pensión completa";
            this.rbtnPensionCompleta.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(651, 453);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 23);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(437, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elige un destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(777, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actividades Extras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(451, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(801, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(801, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Extrellas del hotel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de Estancia";
            // 
            // numudPersonas
            // 
            this.numudPersonas.Location = new System.Drawing.Point(761, 177);
            this.numudPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudPersonas.Name = "numudPersonas";
            this.numudPersonas.ReadOnly = true;
            this.numudPersonas.Size = new System.Drawing.Size(34, 20);
            this.numudPersonas.TabIndex = 14;
            this.numudPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numudEstrellas
            // 
            this.numudEstrellas.Location = new System.Drawing.Point(759, 253);
            this.numudEstrellas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numudEstrellas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudEstrellas.Name = "numudEstrellas";
            this.numudEstrellas.Size = new System.Drawing.Size(36, 20);
            this.numudEstrellas.TabIndex = 0;
            this.numudEstrellas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txbCalculos
            // 
            this.txbCalculos.Location = new System.Drawing.Point(396, 329);
            this.txbCalculos.Multiline = true;
            this.txbCalculos.Name = "txbCalculos";
            this.txbCalculos.ReadOnly = true;
            this.txbCalculos.Size = new System.Drawing.Size(355, 118);
            this.txbCalculos.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(117, 346);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(187, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtnMediaPension
            // 
            this.rbtnMediaPension.AutoSize = true;
            this.rbtnMediaPension.Location = new System.Drawing.Point(154, 235);
            this.rbtnMediaPension.Name = "rbtnMediaPension";
            this.rbtnMediaPension.Size = new System.Drawing.Size(95, 17);
            this.rbtnMediaPension.TabIndex = 4;
            this.rbtnMediaPension.TabStop = true;
            this.rbtnMediaPension.Text = "Media Pensión";
            this.rbtnMediaPension.UseVisualStyleBackColor = true;
            // 
            // strBarraAbajo
            // 
            this.strBarraAbajo.BackColor = System.Drawing.Color.FloralWhite;
            this.strBarraAbajo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlImagen,
            this.stlCorreo,
            this.tsprbBarraProgreso,
            this.stlFechaHora});
            this.strBarraAbajo.Location = new System.Drawing.Point(0, 480);
            this.strBarraAbajo.Name = "strBarraAbajo";
            this.strBarraAbajo.Size = new System.Drawing.Size(931, 22);
            this.strBarraAbajo.TabIndex = 16;
            this.strBarraAbajo.Text = "strBarraAbajo";
            // 
            // stlImagen
            // 
            this.stlImagen.BackColor = System.Drawing.Color.FloralWhite;
            this.stlImagen.Image = ((System.Drawing.Image)(resources.GetObject("stlImagen.Image")));
            this.stlImagen.Name = "stlImagen";
            this.stlImagen.Size = new System.Drawing.Size(16, 17);
            // 
            // stlCorreo
            // 
            this.stlCorreo.BackColor = System.Drawing.Color.FloralWhite;
            this.stlCorreo.IsLink = true;
            this.stlCorreo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.stlCorreo.Name = "stlCorreo";
            this.stlCorreo.Size = new System.Drawing.Size(179, 17);
            this.stlCorreo.Text = "viajeconnosotros@gmail.com";
            // 
            // tsprbBarraProgreso
            // 
            this.tsprbBarraProgreso.Name = "tsprbBarraProgreso";
            this.tsprbBarraProgreso.Size = new System.Drawing.Size(200, 16);
            // 
            // stlFechaHora
            // 
            this.stlFechaHora.BackColor = System.Drawing.Color.FloralWhite;
            this.stlFechaHora.Name = "stlFechaHora";
            this.stlFechaHora.Size = new System.Drawing.Size(70, 17);
            this.stlFechaHora.Text = "FechaHora";
            // 
            // tsBarraArriba
            // 
            this.tsBarraArriba.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAcuerdoEmpresa,
            this.btnPrecios,
            this.btnSalir});
            this.tsBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.tsBarraArriba.Name = "tsBarraArriba";
            this.tsBarraArriba.Size = new System.Drawing.Size(931, 25);
            this.tsBarraArriba.TabIndex = 17;
            this.tsBarraArriba.Text = "toolStrip1";
            // 
            // btnAcuerdoEmpresa
            // 
            this.btnAcuerdoEmpresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAcuerdoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnAcuerdoEmpresa.Image")));
            this.btnAcuerdoEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcuerdoEmpresa.Name = "btnAcuerdoEmpresa";
            this.btnAcuerdoEmpresa.Size = new System.Drawing.Size(23, 22);
            this.btnAcuerdoEmpresa.Click += new System.EventHandler(this.btnAcuerdoEmpresa_Click);
            // 
            // btnPrecios
            // 
            this.btnPrecios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrecios.Image = ((System.Drawing.Image)(resources.GetObject("btnPrecios.Image")));
            this.btnPrecios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Size = new System.Drawing.Size(23, 22);
            this.btnPrecios.Click += new System.EventHandler(this.btnPrecios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aquamarine;
            this.label7.Location = new System.Drawing.Point(767, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Actividades Extras";
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(931, 502);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tsBarraArriba);
            this.Controls.Add(this.strBarraAbajo);
            this.Controls.Add(this.txbCalculos);
            this.Controls.Add(this.numudEstrellas);
            this.Controls.Add(this.numudPersonas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbtnMediaPension);
            this.Controls.Add(this.rbtnPensionCompleta);
            this.Controls.Add(this.rbtnSoloDormir);
            this.Controls.Add(this.mncCalendarioFecha);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chlbActividadesExtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Viajes IFP VdG";
            this.Activated += new System.EventHandler(this.frmFormularioPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFormularioPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numudPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudEstrellas)).EndInit();
            this.strBarraAbajo.ResumeLayout(false);
            this.strBarraAbajo.PerformLayout();
            this.tsBarraArriba.ResumeLayout(false);
            this.tsBarraArriba.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList lstiListaimagenesDestino;
        private System.Windows.Forms.CheckedListBox chlbActividadesExtras;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MonthCalendar mncCalendarioFecha;
        private System.Windows.Forms.RadioButton rbtnSoloDormir;
        private System.Windows.Forms.RadioButton rbtnPensionCompleta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numudPersonas;
        private System.Windows.Forms.NumericUpDown numudEstrellas;
        private System.Windows.Forms.TextBox txbCalculos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbtnMediaPension;
        private System.Windows.Forms.StatusStrip strBarraAbajo;
        private System.Windows.Forms.ToolStripStatusLabel stlFechaHora;
        private System.Windows.Forms.ToolStripStatusLabel stlCorreo;
        private System.Windows.Forms.ToolStripStatusLabel stlImagen;
        private System.Windows.Forms.ToolStrip tsBarraArriba;
        private System.Windows.Forms.ToolStripButton btnAcuerdoEmpresa;
        private System.Windows.Forms.ToolStripButton btnPrecios;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripProgressBar tsprbBarraProgreso;
        private System.Windows.Forms.Label label7;
    }
}

