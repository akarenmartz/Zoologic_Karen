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
    public partial class Animal : Form
    {
        String alimentacion;
        String especie;
        String locacion;
        public Animal()
        {
            InitializeComponent();
        }

        private void cmbEspecie_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbEspecie, "SELECT NOMBRE_ALIAS_ESPECIE_KAREN FROM ESPECIE_KAREN");
        }

        private void cmbLocacion_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbLocacion, "SELECT LOCACION_KAREN.DESCRIPCION_LOCACION_KAREN FROM LOCACION_KAREN");
        }

        private void cmbAlimentacion_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_llenaCombo(cmbAlimentacion, "EXECUTE sp_ver_alimentacion");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformacionAnimal v = new InformacionAnimal();
            v.Show();
        }

        private void cmbAlimentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            alimentacion = cmbAlimentacion.Text;
            alimentacion = alimentacion.Remove(alimentacion.Length - 2);
            //MessageBox.Show(alimentacion);
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            especie = cmbEspecie.Text;
        }

        private void cmbLocacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            locacion = cmbLocacion.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_Animal '"+txtNombreIden.Text+"','"+txtGenero.Text+"', '"+txtFechaNac.Text+"', '"+txtFechaLleg.Text+"','"+txtPais.Text+"', '"+txtObs.Text+"','"+especie+"','"+locacion+"', '"+alimentacion+"'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            txtNombreIden.Text = " ";
            txtGenero.Text = " ";
            txtFechaNac.Text = " ";
            txtPais.Text = " ";
            txtObs.Text = " ";
            txtFechaLleg.Text = " ";
            cmbEspecie.SelectedIndex = 0;
            cmbLocacion.SelectedIndex = 0;
            cmbAlimentacion.SelectedIndex = 0;
        }

    }
}