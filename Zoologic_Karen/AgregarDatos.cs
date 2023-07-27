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
    public partial class AgregarDatos : Form
    {
        public AgregarDatos()
        {
            InitializeComponent();
        }

        private void btnAgregarArea_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String nomArea = Microsoft.VisualBasic.Interaction.InputBox("Nombre de nueva Area", "Añadir Area");
            String descrArea = Microsoft.VisualBasic.Interaction.InputBox("Descripcion", "Añadir Area");
            ConexionMaestra_Karen.Karen_Ejecutar("INSERT AREA_KAREN VALUES ('" + nomArea + "', '" + descrArea + "','1')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT  * FROM AREA_KAREN");
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String descrCategoria = Microsoft.VisualBasic.Interaction.InputBox("Descripcion", "Añadir categoria");

            ConexionMaestra_Karen.Karen_Ejecutar("INSERT CATEGORIA_KAREN VALUES ( '" + descrCategoria + "','1')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT  * FROM CATEGORIA_KAREN");
        }

        private void btnEspecie_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String numEspecie = Microsoft.VisualBasic.Interaction.InputBox("Ingresar numero de Especie", "Añadir Especie");
            String nomAlias = Microsoft.VisualBasic.Interaction.InputBox("Nombre Alias de la Especie", "Añadir Especie");
            String nomCientifico = Microsoft.VisualBasic.Interaction.InputBox("Nombre Cientifico de la Especie", "Añadir Especie");
            String descEspecie = Microsoft.VisualBasic.Interaction.InputBox("Descripcion de la Especie", "Añadir Especie");
            ConexionMaestra_Karen.Karen_Ejecutar("INSERT ESPECIE_KAREN VALUES ( '" + numEspecie + "','" + nomAlias + "','" + nomCientifico + "','" + descEspecie + "','1')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT  * FROM ESPECIE_KAREN");
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String nomCargo = Microsoft.VisualBasic.Interaction.InputBox("Nombre de Cargo", "Añadir Cargo");
            String Actividades = Microsoft.VisualBasic.Interaction.InputBox("Atividades Cargo", "Añadir Cargo");
            ConexionMaestra_Karen.Karen_Ejecutar("INSERT CARGO_KAREN VALUES ( '" + nomCargo + "','" + Actividades + "','1')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT  * FROM CARGO_KAREN");
        }

        private void btnProvedor_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String claveProv = Microsoft.VisualBasic.Interaction.InputBox("Clave Proveedor", "Añadir Provedor");
            String razonS = Microsoft.VisualBasic.Interaction.InputBox("Razon Social", "Añadir Provedor");
            String contacto = Microsoft.VisualBasic.Interaction.InputBox("Contacto Proveedor", "Añadir Provedor");
            String direc = Microsoft.VisualBasic.Interaction.InputBox("Direccion Proveedor", "Añadir Provedor");
            String email = Microsoft.VisualBasic.Interaction.InputBox("E-mail Proveedor", "Añadir Provedor");
            String telefono = Microsoft.VisualBasic.Interaction.InputBox("Telefono Proveedor", "Añadir Provedor");
            ConexionMaestra_Karen.Karen_Ejecutar("INSERT PROVEEDOR_KAREN VALUES ( '" + claveProv + "','" + razonS + "','" + contacto + "','" + direc + "','" + email + "','" + telefono + "')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT  * FROM PROVEEDOR_KAREN");
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String claveEdad = Microsoft.VisualBasic.Interaction.InputBox("Clave Edad", "Añadir Edad");
            String nombreEdad = Microsoft.VisualBasic.Interaction.InputBox("Nombre Edad", "Añadir Edad");
            String descEdad = Microsoft.VisualBasic.Interaction.InputBox("Descripcion Edad", "Añadir Edad");
            ConexionMaestra_Karen.Karen_Ejecutar("INSERT EDAD_KAREN VALUES ( '" + claveEdad + "','" + nombreEdad + "','" + descEdad + "','1')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT  * FROM EDAD_KAREN");
        }


        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleado v = new Empleado();
            v.Show();
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            DGVDatos.Columns.Clear();
            String nombreMedida = Microsoft.VisualBasic.Interaction.InputBox("Nombre Medida", "Añadir Medida");
            String abrevMedida = Microsoft.VisualBasic.Interaction.InputBox("Abreviatura Medida", "Añadir Medida");
            ConexionMaestra_Karen.Karen_Ejecutar("INSERT MEDIDA_KAREN VALUES ('" + nombreMedida + "', '" + abrevMedida + "')");
            ConexionMaestra_Karen.leer_karen.Close();
            ConexionMaestra_Karen.grid(DGVDatos, "SELECT * FROM MEDIDA_KAREN");
        }

        private void btnRecurso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursos v = new Recursos();
            v.Show();
        }
    }
}
