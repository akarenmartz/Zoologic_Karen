namespace Zoologic_Karen
{
    partial class Animal
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
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.cmbLocacion = new System.Windows.Forms.ComboBox();
            this.cmbAlimentacion = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreIden = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtFechaLleg = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(389, 36);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecie.TabIndex = 0;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            this.cmbEspecie.Click += new System.EventHandler(this.cmbEspecie_Click);
            // 
            // cmbLocacion
            // 
            this.cmbLocacion.FormattingEnabled = true;
            this.cmbLocacion.Location = new System.Drawing.Point(389, 85);
            this.cmbLocacion.Name = "cmbLocacion";
            this.cmbLocacion.Size = new System.Drawing.Size(121, 21);
            this.cmbLocacion.TabIndex = 1;
            this.cmbLocacion.SelectedIndexChanged += new System.EventHandler(this.cmbLocacion_SelectedIndexChanged);
            this.cmbLocacion.Click += new System.EventHandler(this.cmbLocacion_Click);
            // 
            // cmbAlimentacion
            // 
            this.cmbAlimentacion.FormattingEnabled = true;
            this.cmbAlimentacion.Location = new System.Drawing.Point(409, 131);
            this.cmbAlimentacion.Name = "cmbAlimentacion";
            this.cmbAlimentacion.Size = new System.Drawing.Size(121, 21);
            this.cmbAlimentacion.TabIndex = 2;
            this.cmbAlimentacion.SelectedIndexChanged += new System.EventHandler(this.cmbAlimentacion_SelectedIndexChanged);
            this.cmbAlimentacion.Click += new System.EventHandler(this.cmbAlimentacion_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Zoologic_Karen.Properties.Resources.Return;
            this.btnRegresar.Location = new System.Drawing.Point(485, 272);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(49, 45);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(23, 37);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(152, 16);
            this.lblClave.TabIndex = 20;
            this.lblClave.Text = "Nombre Identificador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Genero\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pais Orgen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Especie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Locacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Alimentacion";
            // 
            // txtNombreIden
            // 
            this.txtNombreIden.Location = new System.Drawing.Point(182, 36);
            this.txtNombreIden.Name = "txtNombreIden";
            this.txtNombreIden.Size = new System.Drawing.Size(100, 20);
            this.txtNombreIden.TabIndex = 29;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(182, 84);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 30;
            // 
            // txtFechaLleg
            // 
            this.txtFechaLleg.Location = new System.Drawing.Point(182, 179);
            this.txtFechaLleg.Name = "txtFechaLleg";
            this.txtFechaLleg.Size = new System.Drawing.Size(100, 20);
            this.txtFechaLleg.TabIndex = 31;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(182, 226);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 32;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(182, 268);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(149, 20);
            this.txtObs.TabIndex = 33;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(182, 136);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 34;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = global::Zoologic_Karen.Properties.Resources.Save;
            this.btnGuardar.Location = new System.Drawing.Point(431, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 45);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 320);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtFechaLleg);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombreIden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmbAlimentacion);
            this.Controls.Add(this.cmbLocacion);
            this.Controls.Add(this.cmbEspecie);
            this.Name = "Animal";
            this.Text = "Animal";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.ComboBox cmbLocacion;
        private System.Windows.Forms.ComboBox cmbAlimentacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreIden;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtFechaLleg;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.Button btnGuardar;
    }
}