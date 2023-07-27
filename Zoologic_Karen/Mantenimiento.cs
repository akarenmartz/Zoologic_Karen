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
    public partial class Mantenimiento : Form
    {
        String empleado;
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void cmbMantenimiento_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbMantenimiento, "SELECT CONCAT(NOMBRE_EMPLEADO_KAREN,' ',APELLIDO_P_EMLEADO_KAREN,' ', APELLIDO_M_EMPLEADO_KAREN) FROM EMPLEADO_KAREN");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformacionAnimal v = new InformacionAnimal();
            v.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_mantenimiento '" + txtClave_Man.Text + "', '" + txtDescr_Man.Text + "','" + txtTiem_Man.Text + "', '" + empleado + "'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtClave_Man.Text = " ";
            txtDescr_Man.Text = "";
            txtTiem_Man.Text = "";
            cmbMantenimiento.SelectedIndex = 0;
        }

        private void cmbMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            empleado = cmbMantenimiento.Text;
        }
    }
}
