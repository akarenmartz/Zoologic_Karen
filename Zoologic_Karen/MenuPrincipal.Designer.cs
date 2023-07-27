namespace Zoologic_Karen
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnInfAnimal = new System.Windows.Forms.Button();
            this.btnAggDatos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.button1.Image = global::Zoologic_Karen.Properties.Resources.Cancel_Ventas;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 61);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancelaciones";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuscador.Image = global::Zoologic_Karen.Properties.Resources.buscador;
            this.btnBuscador.Location = new System.Drawing.Point(1196, 24);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(77, 73);
            this.btnBuscador.TabIndex = 40;
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.White;
            this.btnShop.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnShop.Image = global::Zoologic_Karen.Properties.Resources.Carrito;
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(42, 278);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(228, 61);
            this.btnShop.TabIndex = 39;
            this.btnShop.Text = "Zoo Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnInfAnimal
            // 
            this.btnInfAnimal.BackColor = System.Drawing.Color.White;
            this.btnInfAnimal.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnInfAnimal.Image = global::Zoologic_Karen.Properties.Resources.InfoAnimal_;
            this.btnInfAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfAnimal.Location = new System.Drawing.Point(42, 358);
            this.btnInfAnimal.Name = "btnInfAnimal";
            this.btnInfAnimal.Size = new System.Drawing.Size(228, 61);
            this.btnInfAnimal.TabIndex = 38;
            this.btnInfAnimal.Text = "Información\r\n Animal";
            this.btnInfAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfAnimal.UseVisualStyleBackColor = false;
            this.btnInfAnimal.Click += new System.EventHandler(this.btnInfAnimal_Click_1);
            // 
            // btnAggDatos
            // 
            this.btnAggDatos.BackColor = System.Drawing.Color.White;
            this.btnAggDatos.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnAggDatos.Image = global::Zoologic_Karen.Properties.Resources.AggInf;
            this.btnAggDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggDatos.Location = new System.Drawing.Point(42, 204);
            this.btnAggDatos.Name = "btnAggDatos";
            this.btnAggDatos.Size = new System.Drawing.Size(228, 61);
            this.btnAggDatos.TabIndex = 37;
            this.btnAggDatos.Text = "Agregar Datos";
            this.btnAggDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAggDatos.UseVisualStyleBackColor = false;
            this.btnAggDatos.Click += new System.EventHandler(this.btnAggDatos_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zoologic_Karen.Properties.Resources.MenuRec;
            this.pictureBox2.Location = new System.Drawing.Point(32, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 333);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Zoologic_Karen.Properties.Resources.FondoJirafius;
            this.pictureBox3.Location = new System.Drawing.Point(0, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1285, 432);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Zoologic_Karen.Properties.Resources.FSup;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1285, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1208, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "BOLETOS";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1285, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnInfAnimal);
            this.Controls.Add(this.btnAggDatos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAggDatos;
        private System.Windows.Forms.Button btnInfAnimal;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

