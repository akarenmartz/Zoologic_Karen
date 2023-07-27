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
    public partial class AlimentacionAnimal : Form
    {
        String nomRecurso;

        public AlimentacionAnimal()
        {
            InitializeComponent();
        }

        private void cmbAimentacion_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbAlimentacion, "SELECT RECURSO_KAREN.NOMBRE_RECURSO_KAREN FROM RECURSO_KAREN");
        }

        private void cmbAimentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomRecurso = cmbAlimentacion.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sql = "execute sp_insertar_alimentacion '"+txtClaveAli.Text+"', '"+nomRecurso+"', '"+txtPorcion.Text+"','"+txtHorario.Text+"'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtClaveAli.Text = " ";
            txtPorcion.Text = "";
            txtHorario.Text = "";
            cmbAlimentacion.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
             InformacionAnimal v = new InformacionAnimal();
            v.Show();
        }
    }
}
