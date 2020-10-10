namespace AgenciaDeViajes
{
    partial class rbtnMediaPension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rbtnMediaPension));
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.chlbActividadesExtras.Location = new System.Drawing.Point(770, 22);
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
            this.label1.Location = new System.Drawing.Point(437, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elige un destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actividades Extras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(761, 177);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(759, 253);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown2.TabIndex = 0;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 329);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(355, 118);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(154, 235);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Media Pensión";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtnMediaPension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(931, 502);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rbtnPensionCompleta);
            this.Controls.Add(this.rbtnSoloDormir);
            this.Controls.Add(this.mncCalendarioFecha);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chlbActividadesExtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rbtnMediaPension";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Viajes IFP VdG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFormularioPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

