namespace Zoologic_Karen
{
    partial class Mantenimiento
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
            this.cmbMantenimiento = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave_Man = new System.Windows.Forms.TextBox();
            this.txtTiem_Man = new System.Windows.Forms.TextBox();
            this.txtDescr_Man = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMantenimiento
            // 
            this.cmbMantenimiento.FormattingEnabled = true;
            this.cmbMantenimiento.Location = new System.Drawing.Point(206, 190);
            this.cmbMantenimiento.Name = "cmbMantenimiento";
            this.cmbMantenimiento.Size = new System.Drawing.Size(178, 21);
            this.cmbMantenimiento.TabIndex = 0;
            this.cmbMantenimiento.SelectedIndexChanged += new System.EventHandler(this.cmbMantenimiento_SelectedIndexChanged);
            this.cmbMantenimiento.Click += new System.EventHandler(this.cmbMantenimiento_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(12, 60);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(151, 16);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave Mantenimiento";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 113);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(90, 16);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descripcion";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(12, 152);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(60, 16);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empleado";
            // 
            // txtClave_Man
            // 
            this.txtClave_Man.Location = new System.Drawing.Point(206, 60);
            this.txtClave_Man.Name = "txtClave_Man";
            this.txtClave_Man.Size = new System.Drawing.Size(178, 20);
            this.txtClave_Man.TabIndex = 6;
            // 
            // txtTiem_Man
            // 
            this.txtTiem_Man.Location = new System.Drawing.Point(206, 152);
            this.txtTiem_Man.Name = "txtTiem_Man";
            this.txtTiem_Man.Size = new System.Drawing.Size(178, 20);
            this.txtTiem_Man.TabIndex = 7;
            // 
            // txtDescr_Man
            // 
            this.txtDescr_Man.Location = new System.Drawing.Point(206, 115);
            this.txtDescr_Man.Name = "txtDescr_Man";
            this.txtDescr_Man.Size = new System.Drawing.Size(178, 20);
            this.txtDescr_Man.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = global::Zoologic_Karen.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(349, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 45);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Zoologic_Karen.Properties.Resources.Return;
            this.btnRegresar.Location = new System.Drawing.Point(403, 245);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(49, 45);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 302);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescr_Man);
            this.Controls.Add(this.txtTiem_Man);
            this.Controls.Add(this.txtClave_Man);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbMantenimiento);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMantenimiento;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave_Man;
        private System.Windows.Forms.TextBox txtTiem_Man;
        private System.Windows.Forms.TextBox txtDescr_Man;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
    }
}