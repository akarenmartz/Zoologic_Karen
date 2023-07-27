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
    public partial class AtencionAnimal : Form
    {
        String animal;
        String empl;
        public AtencionAnimal()
        {
            InitializeComponent();
        }

        private void cmbAnimal_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbAnimal, "SELECT ANIMAL_KAREN.NOMBRE_IDENTIFICADOR_ANIMAL_KAREN FROM ANIMAL_KAREN");
        }

        private void cmbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            animal = cmbAnimal.Text;
        }

        private void cmbEmpleado_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbEmpleado, "SELECT CONCAT(NOMBRE_EMPLEADO_KAREN,' ',APELLIDO_P_EMLEADO_KAREN,' ', APELLIDO_M_EMPLEADO_KAREN) FROM EMPLEADO_KAREN");
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            empl = cmbEmpleado.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_atencionAnimal '"+animal+"','"+empl+"','"+txtPadecimiento.Text+"','"+txtObser.Text+"'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtPadecimiento.Text = " ";
            txtObser.Text = " ";
            cmbAnimal.SelectedIndex = 0;
            cmbEmpleado.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformacionAnimal v = new InformacionAnimal();
            v.Show();
        }
    }
}
