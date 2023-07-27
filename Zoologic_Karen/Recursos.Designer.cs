namespace Zoologic_Karen
{
    partial class Recursos
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
            this.lblClaveRecurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.txtClaveRec = new System.Windows.Forms.TextBox();
            this.txtDescrRec = new System.Windows.Forms.TextBox();
            this.txtNombreRec = new System.Windows.Forms.TextBox();
            this.txtExiRec = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClaveRecurso
            // 
            this.lblClaveRecurso.AutoSize = true;
            this.lblClaveRecurso.Location = new System.Drawing.Point(13, 62);
            this.lblClaveRecurso.Name = "lblClaveRecurso";
            this.lblClaveRecurso.Size = new System.Drawing.Size(80, 13);
            this.lblClaveRecurso.TabIndex = 0;
            this.lblClaveRecurso.Text = "Clave  Recurso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre  Recurso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medida";
            // 
            // cmbMedida
            // 
            this.cmbMedida.FormattingEnabled = true;
            this.cmbMedida.Location = new System.Drawing.Point(116, 219);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(121, 21);
            this.cmbMedida.TabIndex = 5;
            this.cmbMedida.SelectedIndexChanged += new System.EventHandler(this.cmbMedida_SelectedIndexChanged);
            this.cmbMedida.Click += new System.EventHandler(this.cmbMedida_Click);
            // 
            // txtClaveRec
            // 
            this.txtClaveRec.Location = new System.Drawing.Point(116, 62);
            this.txtClaveRec.Name = "txtClaveRec";
            this.txtClaveRec.Size = new System.Drawing.Size(144, 20);
            this.txtClaveRec.TabIndex = 6;
            // 
            // txtDescrRec
            // 
            this.txtDescrRec.Location = new System.Drawing.Point(116, 141);
            this.txtDescrRec.Name = "txtDescrRec";
            this.txtDescrRec.Size = new System.Drawing.Size(144, 20);
            this.txtDescrRec.TabIndex = 7;
            // 
            // txtNombreRec
            // 
            this.txtNombreRec.Location = new System.Drawing.Point(116, 102);
            this.txtNombreRec.Name = "txtNombreRec";
            this.txtNombreRec.Size = new System.Drawing.Size(144, 20);
            this.txtNombreRec.TabIndex = 8;
            // 
            // txtExiRec
            // 
            this.txtExiRec.Location = new System.Drawing.Point(116, 182);
            this.txtExiRec.Name = "txtExiRec";
            this.txtExiRec.Size = new System.Drawing.Size(144, 20);
            this.txtExiRec.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Zoologic_Karen.Properties.Resources.Return;
            this.btnRegresar.Location = new System.Drawing.Point(369, 283);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(49, 45);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = global::Zoologic_Karen.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(424, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 45);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Recursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtExiRec);
            this.Controls.Add(this.txtNombreRec);
            this.Controls.Add(this.txtDescrRec);
            this.Controls.Add(this.txtClaveRec);
            this.Controls.Add(this.cmbMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClaveRecurso);
            this.Name = "Recursos";
            this.Text = "Recursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveRecurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedida;
        private System.Windows.Forms.TextBox txtClaveRec;
        private System.Windows.Forms.TextBox txtDescrRec;
        private System.Windows.Forms.TextBox txtNombreRec;
        private System.Windows.Forms.TextBox txtExiRec;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
    }
}