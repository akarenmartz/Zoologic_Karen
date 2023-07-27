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
    public partial class Recursos : Form
    {
        String medida;
        public Recursos()
        {
            InitializeComponent();
        }

        private void cmbMedida_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbMedida, "SELECT NOMBRE_MEDIDA_KAREN FROM MEDIDA_KAREN");
        }

        private void cmbMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            medida = cmbMedida.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_recurso '"+txtClaveRec.Text+"', '"+txtNombreRec.Text+"', '"+txtDescrRec.Text+"', '"+txtExiRec.Text+"' ,'"+medida+"'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtClaveRec.Text = " ";
            txtDescrRec.Text = "";
            txtNombreRec.Text = "";
            txtExiRec.Text = "";
            cmbMedida.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarDatos v = new AgregarDatos();
            v.Show();
        }
    }
}
