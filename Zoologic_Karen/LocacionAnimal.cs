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
    public partial class LocacionAnimal : Form
    {
        String area;
        String mantenimiento;
        public LocacionAnimal()
        {
            InitializeComponent();
        }

        private void cmbArea_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbArea, "SELECT AREA_KAREN.NOMBRE_AREA_KAREN FROM AREA_KAREN");
        }

        private void cmbMantenimiento_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbMantenimiento, "SELECT MANTENIMIENTO_KAREN.DESCRIPCION_MANTENIMIENTO_KAREN FROM MANTENIMIENTO_KAREN");
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = cmbArea.Text;
        }

        private void cmbMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            mantenimiento = cmbMantenimiento.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_locacion '" + txtCodigo.Text + "','" + txtDesc_Loc.Text + "','" + area + "','" + mantenimiento + "','" + txtUbi_Loc.Text + "'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtCodigo.Text = " ";
            txtDesc_Loc.Text = "";
            txtUbi_Loc.Text = "";
            cmbArea.SelectedIndex = 0;
            cmbMantenimiento.SelectedIndex = 0;
        }
    }
}
