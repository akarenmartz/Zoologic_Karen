using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Zoologic_Karen
{
    public partial class Cancelaciones : Form
    {
        String id_DetalleVenta;
        private Worksheet hoja;
        public Cancelaciones()
        {
            InitializeComponent();
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra_Karen.grid(datos, "EXECUTE sp_buscador_venta '%"+txtBuscador.Text+"%'");
        }

        private void Cancelaciones_Load(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.abrir_karen();
        }

        private void datos_SelectionChanged(object sender, EventArgs e)
        {
            if(datos.SelectedRows.Count == 0)
            {
                return;
            }
            id_DetalleVenta =datos[0, datos.SelectedRows[0].Index].Value.ToString();
            txtFolio.Text = datos[1, datos.SelectedRows[0].Index].Value.ToString();
            txtBoleto.Text = datos[2, datos.SelectedRows[0].Index].Value.ToString();
            txtCantidad.Text = datos[3, datos.SelectedRows[0].Index].Value.ToString();
            txtPrecio.Text = datos[4, datos.SelectedRows[0].Index].Value.ToString();
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra_Karen.Karen_Ejecutar("EXECUTE sp_valores_venta '"+txtBoleto.Text+"', '"+txtCantidad.Text+"'");
            if (ConexionMaestra_Karen.leer_karen.Read())
            {
                txtPrecio.Text = ConexionMaestra_Karen.leer_karen[0].ToString();
            }
            ConexionMaestra_Karen.leer_karen.Close();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_Ejecutar("EXECUTE sp_eliminar_dtv '"+id_DetalleVenta+"','"+txtFolio.Text+"'");
            ConexionMaestra_Karen.leer_karen.Close();
            MessageBox.Show("DATOS ELIMINADOS");
            txtFolio.Text = " ";
            txtBoleto.Text=" ";
            txtCantidad.Text = " ";
            txtPrecio.Text = " ";
            datos.Columns.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.Karen_Ejecutar("EXECUTE sp_actualizar_cantidad '"+txtCantidad.Text+"', '"+id_DetalleVenta+"', '"+txtFolio.Text+"'");
            ConexionMaestra_Karen.leer_karen.Close();
            MessageBox.Show("DATOS GUARDADOS");
            txtFolio.Text = " ";
            txtBoleto.Text = " ";
            txtCantidad.Text = " ";
            txtPrecio.Text = " ";
            datos.Columns.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
            Workbook libro = aplicacion.Workbooks.Add("venta_karen");
            aplicacion.Visible = true;
            hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[3, 5] = "Lo hicimos";
            libro.SaveAs("zoo.pdf");
        }
    }
}
