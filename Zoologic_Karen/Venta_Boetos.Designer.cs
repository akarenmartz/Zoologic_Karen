namespace Zoologic_Karen
{
    partial class Venta_Boetos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFolioVenta = new System.Windows.Forms.Label();
            this.lblBoleto = new System.Windows.Forms.Label();
            this.PanelBoletos = new System.Windows.Forms.FlowLayoutPanel();
            this.plusInf = new System.Windows.Forms.NumericUpDown();
            this.plusMayores = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.plusGeneral = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPG = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtToPG = new System.Windows.Forms.TextBox();
            this.txtToPI = new System.Windows.Forms.TextBox();
            this.txtToPM = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelPM = new System.Windows.Forms.Button();
            this.btnCancelPI = new System.Windows.Forms.Button();
            this.btnAceptPM = new System.Windows.Forms.Button();
            this.btnAceptPI = new System.Windows.Forms.Button();
            this.btnCancelPG = new System.Windows.Forms.Button();
            this.btnAceptPG = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plusInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusMayores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(198, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "B O L E T O S";
            this.lblTitulo.UseWaitCursor = true;
            // 
            // Panel
            // 
            this.Panel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Panel.Location = new System.Drawing.Point(12, 73);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(135, 325);
            this.Panel.TabIndex = 1;
            this.Panel.UseWaitCursor = true;
            // 
            // lblFolioVenta
            // 
            this.lblFolioVenta.AutoSize = true;
            this.lblFolioVenta.Location = new System.Drawing.Point(531, 25);
            this.lblFolioVenta.Name = "lblFolioVenta";
            this.lblFolioVenta.Size = new System.Drawing.Size(35, 13);
            this.lblFolioVenta.TabIndex = 2;
            this.lblFolioVenta.Text = "label1";
            this.lblFolioVenta.UseWaitCursor = true;
            this.lblFolioVenta.Visible = false;
            // 
            // lblBoleto
            // 
            this.lblBoleto.AutoSize = true;
            this.lblBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoleto.Location = new System.Drawing.Point(232, 61);
            this.lblBoleto.Name = "lblBoleto";
            this.lblBoleto.Size = new System.Drawing.Size(118, 18);
            this.lblBoleto.TabIndex = 4;
            this.lblBoleto.Text = "Tipo de Boleto";
            this.lblBoleto.UseWaitCursor = true;
            this.lblBoleto.Visible = false;
            // 
            // PanelBoletos
            // 
            this.PanelBoletos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PanelBoletos.Location = new System.Drawing.Point(164, 94);
            this.PanelBoletos.Name = "PanelBoletos";
            this.PanelBoletos.Size = new System.Drawing.Size(247, 304);
            this.PanelBoletos.TabIndex = 2;
            this.PanelBoletos.UseWaitCursor = true;
            // 
            // plusInf
            // 
            this.plusInf.Location = new System.Drawing.Point(440, 203);
            this.plusInf.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plusInf.Name = "plusInf";
            this.plusInf.Size = new System.Drawing.Size(83, 20);
            this.plusInf.TabIndex = 6;
            this.plusInf.UseWaitCursor = true;
            this.plusInf.Visible = false;
            // 
            // plusMayores
            // 
            this.plusMayores.Location = new System.Drawing.Point(440, 283);
            this.plusMayores.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plusMayores.Name = "plusMayores";
            this.plusMayores.Size = new System.Drawing.Size(83, 20);
            this.plusMayores.TabIndex = 7;
            this.plusMayores.UseWaitCursor = true;
            this.plusMayores.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(437, 61);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.UseWaitCursor = true;
            this.lblCantidad.Visible = false;
            // 
            // plusGeneral
            // 
            this.plusGeneral.Location = new System.Drawing.Point(440, 123);
            this.plusGeneral.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.plusGeneral.Name = "plusGeneral";
            this.plusGeneral.Size = new System.Drawing.Size(83, 20);
            this.plusGeneral.TabIndex = 16;
            this.plusGeneral.UseWaitCursor = true;
            this.plusGeneral.Visible = false;
            // 
            // txtTotalPG
            // 
            this.txtTotalPG.AutoSize = true;
            this.txtTotalPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPG.Location = new System.Drawing.Point(674, 125);
            this.txtTotalPG.Name = "txtTotalPG";
            this.txtTotalPG.Size = new System.Drawing.Size(0, 18);
            this.txtTotalPG.TabIndex = 17;
            this.txtTotalPG.UseWaitCursor = true;
            this.txtTotalPG.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(649, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 18);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Totales";
            this.lblTotal.UseWaitCursor = true;
            this.lblTotal.Visible = false;
            // 
            // txtToPG
            // 
            this.txtToPG.Location = new System.Drawing.Point(647, 122);
            this.txtToPG.Name = "txtToPG";
            this.txtToPG.Size = new System.Drawing.Size(75, 20);
            this.txtToPG.TabIndex = 19;
            this.txtToPG.UseWaitCursor = true;
            this.txtToPG.Visible = false;
            this.txtToPG.WordWrap = false;
            // 
            // txtToPI
            // 
            this.txtToPI.Location = new System.Drawing.Point(647, 202);
            this.txtToPI.Name = "txtToPI";
            this.txtToPI.Size = new System.Drawing.Size(75, 20);
            this.txtToPI.TabIndex = 20;
            this.txtToPI.UseWaitCursor = true;
            this.txtToPI.Visible = false;
            this.txtToPI.WordWrap = false;
            // 
            // txtToPM
            // 
            this.txtToPM.Location = new System.Drawing.Point(647, 282);
            this.txtToPM.Name = "txtToPM";
            this.txtToPM.Size = new System.Drawing.Size(75, 20);
            this.txtToPM.TabIndex = 21;
            this.txtToPM.UseWaitCursor = true;
            this.txtToPM.Visible = false;
            this.txtToPM.WordWrap = false;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(647, 358);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(75, 20);
            this.txtMontoTotal.TabIndex = 22;
            this.txtMontoTotal.UseWaitCursor = true;
            this.txtMontoTotal.Visible = false;
            this.txtMontoTotal.WordWrap = false;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(647, 25);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(75, 20);
            this.txtFolio.TabIndex = 23;
            this.txtFolio.UseWaitCursor = true;
            this.txtFolio.Visible = false;
            this.txtFolio.WordWrap = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = global::Zoologic_Karen.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(665, 406);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 45);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelPM
            // 
            this.btnCancelPM.Image = global::Zoologic_Karen.Properties.Resources.Cancel;
            this.btnCancelPM.Location = new System.Drawing.Point(597, 274);
            this.btnCancelPM.Name = "btnCancelPM";
            this.btnCancelPM.Size = new System.Drawing.Size(35, 35);
            this.btnCancelPM.TabIndex = 14;
            this.btnCancelPM.UseVisualStyleBackColor = true;
            this.btnCancelPM.UseWaitCursor = true;
            this.btnCancelPM.Visible = false;
            this.btnCancelPM.Click += new System.EventHandler(this.btnCancelPM_Click);
            // 
            // btnCancelPI
            // 
            this.btnCancelPI.Image = global::Zoologic_Karen.Properties.Resources.Cancel;
            this.btnCancelPI.Location = new System.Drawing.Point(597, 194);
            this.btnCancelPI.Name = "btnCancelPI";
            this.btnCancelPI.Size = new System.Drawing.Size(35, 35);
            this.btnCancelPI.TabIndex = 13;
            this.btnCancelPI.UseVisualStyleBackColor = true;
            this.btnCancelPI.UseWaitCursor = true;
            this.btnCancelPI.Visible = false;
            this.btnCancelPI.Click += new System.EventHandler(this.btnCancelPI_Click);
            // 
            // btnAceptPM
            // 
            this.btnAceptPM.Image = global::Zoologic_Karen.Properties.Resources.Acept;
            this.btnAceptPM.Location = new System.Drawing.Point(556, 274);
            this.btnAceptPM.Name = "btnAceptPM";
            this.btnAceptPM.Size = new System.Drawing.Size(35, 35);
            this.btnAceptPM.TabIndex = 12;
            this.btnAceptPM.UseVisualStyleBackColor = true;
            this.btnAceptPM.UseWaitCursor = true;
            this.btnAceptPM.Visible = false;
            this.btnAceptPM.Click += new System.EventHandler(this.btnAceptPM_Click);
            // 
            // btnAceptPI
            // 
            this.btnAceptPI.Image = global::Zoologic_Karen.Properties.Resources.Acept;
            this.btnAceptPI.Location = new System.Drawing.Point(556, 194);
            this.btnAceptPI.Name = "btnAceptPI";
            this.btnAceptPI.Size = new System.Drawing.Size(35, 35);
            this.btnAceptPI.TabIndex = 11;
            this.btnAceptPI.UseVisualStyleBackColor = true;
            this.btnAceptPI.UseWaitCursor = true;
            this.btnAceptPI.Visible = false;
            this.btnAceptPI.Click += new System.EventHandler(this.btnAceptPI_Click);
            // 
            // btnCancelPG
            // 
            this.btnCancelPG.Image = global::Zoologic_Karen.Properties.Resources.Cancel;
            this.btnCancelPG.Location = new System.Drawing.Point(597, 114);
            this.btnCancelPG.Name = "btnCancelPG";
            this.btnCancelPG.Size = new System.Drawing.Size(35, 35);
            this.btnCancelPG.TabIndex = 9;
            this.btnCancelPG.UseVisualStyleBackColor = true;
            this.btnCancelPG.UseWaitCursor = true;
            this.btnCancelPG.Visible = false;
            this.btnCancelPG.Click += new System.EventHandler(this.btnCancelPG_Click);
            // 
            // btnAceptPG
            // 
            this.btnAceptPG.Image = global::Zoologic_Karen.Properties.Resources.Acept;
            this.btnAceptPG.Location = new System.Drawing.Point(556, 115);
            this.btnAceptPG.Name = "btnAceptPG";
            this.btnAceptPG.Size = new System.Drawing.Size(35, 35);
            this.btnAceptPG.TabIndex = 8;
            this.btnAceptPG.UseVisualStyleBackColor = true;
            this.btnAceptPG.UseWaitCursor = true;
            this.btnAceptPG.Visible = false;
            this.btnAceptPG.Click += new System.EventHandler(this.btnAceptPG_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zoologic_Karen.Properties.Resources.lineas;
            this.pictureBox2.Location = new System.Drawing.Point(12, 463);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 11);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zoologic_Karen.Properties.Resources.lineas;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 18);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Zoologic_Karen.Properties.Resources.ardillita;
            this.pictureBox5.Location = new System.Drawing.Point(26, 407);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.UseWaitCursor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnImprimir.Image = global::Zoologic_Karen.Properties.Resources.Save;
            this.btnImprimir.Location = new System.Drawing.Point(584, 406);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 45);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.UseWaitCursor = true;
            this.btnImprimir.Visible = false;
            // 
            // Venta_Boetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(745, 510);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtToPM);
            this.Controls.Add(this.txtToPI);
            this.Controls.Add(this.txtToPG);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalPG);
            this.Controls.Add(this.plusGeneral);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelPM);
            this.Controls.Add(this.btnCancelPI);
            this.Controls.Add(this.btnAceptPM);
            this.Controls.Add(this.btnAceptPI);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelPG);
            this.Controls.Add(this.btnAceptPG);
            this.Controls.Add(this.plusMayores);
            this.Controls.Add(this.plusInf);
            this.Controls.Add(this.PanelBoletos);
            this.Controls.Add(this.lblBoleto);
            this.Controls.Add(this.lblFolioVenta);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Venta_Boetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta_Boetos";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Venta_Boetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plusInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusMayores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Label lblFolioVenta;
        private System.Windows.Forms.Label lblBoleto;
        private System.Windows.Forms.FlowLayoutPanel PanelBoletos;
        private System.Windows.Forms.NumericUpDown plusInf;
        private System.Windows.Forms.NumericUpDown plusMayores;
        private System.Windows.Forms.Button btnAceptPG;
        private System.Windows.Forms.Button btnCancelPG;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAceptPI;
        private System.Windows.Forms.Button btnAceptPM;
        private System.Windows.Forms.Button btnCancelPI;
        private System.Windows.Forms.Button btnCancelPM;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown plusGeneral;
        private System.Windows.Forms.Label txtTotalPG;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtToPG;
        private System.Windows.Forms.TextBox txtToPI;
        private System.Windows.Forms.TextBox txtToPM;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnImprimir;
    }
}