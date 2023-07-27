using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologic_Karen
{
    public partial class Empleado : Form
    {
        String nomCargo;
        String numEmpleado;
        String rfc;
        String nombreEmpleado;
        String ape1;
        String ape2;
        public Empleado()
        {
            InitializeComponent();
        }

        private void cmbCargo_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbCargo, "SELECT CARGO_KAREN.NOMBRE_CARGO_KAREN FROM CARGO_KAREN");
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomCargo = cmbCargo.Text;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarDatos v = new AgregarDatos();
            v.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            numEmpleado = txtEmpleado.Text;
            rfc = txtRfc.Text;
            nombreEmpleado = txtNombre.Text;
            ape1 = txtApe1.Text;
            ape2 = txtApe2.Text;
            String sql = "EXECUTE sp_insertar_empleado '" + numEmpleado + "', '" + rfc + "', '" + nombreEmpleado + "', '" + ape1 + "', '" + ape2 + "', '" + nomCargo + "'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtEmpleado.Text = " ";
            txtNombre.Text = " ";
            txtApe1.Text = " ";
            txtApe2.Text = " ";
            txtRfc.Text = " ";
            cmbCargo.SelectedIndex = 0;
        }
    }
}
