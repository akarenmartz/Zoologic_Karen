namespace Zoologic_Karen
{
    partial class AlimentacionAnimal
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
            this.cmbAlimentacion = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClaveAli = new System.Windows.Forms.TextBox();
            this.lblNomRecurso = new System.Windows.Forms.Label();
            this.lblPorcion = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtPorcion = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAlimentacion
            // 
            this.cmbAlimentacion.FormattingEnabled = true;
            this.cmbAlimentacion.Location = new System.Drawing.Point(172, 92);
            this.cmbAlimentacion.Name = "cmbAlimentacion";
            this.cmbAlimentacion.Size = new System.Drawing.Size(164, 21);
            this.cmbAlimentacion.TabIndex = 0;
            this.cmbAlimentacion.SelectedIndexChanged += new System.EventHandler(this.cmbAimentacion_SelectedIndexChanged);
            this.cmbAlimentacion.Click += new System.EventHandler(this.cmbAimentacion_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(12, 37);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(140, 16);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave Alimentación";
            // 
            // txtClaveAli
            // 
            this.txtClaveAli.Location = new System.Drawing.Point(172, 37);
            this.txtClaveAli.Name = "txtClaveAli";
            this.txtClaveAli.Size = new System.Drawing.Size(164, 20);
            this.txtClaveAli.TabIndex = 2;
            // 
            // lblNomRecurso
            // 
            this.lblNomRecurso.AutoSize = true;
            this.lblNomRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRecurso.Location = new System.Drawing.Point(12, 92);
            this.lblNomRecurso.Name = "lblNomRecurso";
            this.lblNomRecurso.Size = new System.Drawing.Size(146, 16);
            this.lblNomRecurso.TabIndex = 3;
            this.lblNomRecurso.Text = "Nombre de Recurso";
            // 
            // lblPorcion
            // 
            this.lblPorcion.AutoSize = true;
            this.lblPorcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcion.Location = new System.Drawing.Point(12, 144);
            this.lblPorcion.Name = "lblPorcion";
            this.lblPorcion.Size = new System.Drawing.Size(60, 16);
            this.lblPorcion.TabIndex = 4;
            this.lblPorcion.Text = "Porcion";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(12, 179);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(126, 16);
            this.lblHorario.TabIndex = 5;
            this.lblHorario.Text = "Horario en Horas";
            // 
            // txtPorcion
            // 
            this.txtPorcion.Location = new System.Drawing.Point(172, 140);
            this.txtPorcion.Name = "txtPorcion";
            this.txtPorcion.Size = new System.Drawing.Size(164, 20);
            this.txtPorcion.TabIndex = 6;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(172, 179);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(164, 20);
            this.txtHorario.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = global::Zoologic_Karen.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(323, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 45);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Zoologic_Karen.Properties.Resources.Return;
            this.btnRegresar.Location = new System.Drawing.Point(377, 224);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(49, 45);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // AlimentacionAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 281);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtPorcion);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblPorcion);
            this.Controls.Add(this.lblNomRecurso);
            this.Controls.Add(this.txtClaveAli);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbAlimentacion);
            this.Name = "AlimentacionAnimal";
            this.Text = "AlimentacionAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlimentacion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClaveAli;
        private System.Windows.Forms.Label lblNomRecurso;
        private System.Windows.Forms.Label lblPorcion;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtPorcion;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
    }
}