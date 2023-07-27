using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel =Microsoft.Office.Interop.Excel;
using Button = System.Windows.Forms.Button;
using Font = System.Drawing.Font;

namespace Zoologic_Karen
{
    public partial class Venta_Boetos : Form
    {
        String nombreEmpleado;
        String numEmpleado;
        String folio;
        String nombreBoleto;
        String idBoleto;
        String precioBoleto;
        int totalPG;
        int totalPI;
        int totalPM;
        String vacio = Convert.ToString(0);
        private Worksheet hoja;

        public Venta_Boetos()
        {
            InitializeComponent();
        }

        private void Venta_Boetos_Load(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.abrir_karen();
            Panel.Controls.Clear();
            karen_mostrar_empleado();
            
        }

        public void karen_mostrar_empleado()
        {
            ConexionMaestra_Karen.Karen_Ejecutar("EXECUTE sp_consultar_empleado ");

            //Leer mientras exista un registro
            while (ConexionMaestra_Karen.leer_karen.Read())
            {
                btn_empleado(ConexionMaestra_Karen.leer_karen[0].ToString(), ConexionMaestra_Karen.leer_karen[1].ToString());
            }
            //Cerrar el leer
            ConexionMaestra_Karen.leer_karen.Close();
        }

        public void btn_img()
        {
            Button nuevobtn = new Button();
            nuevobtn.BackColor = Color.CadetBlue;
            nuevobtn.Width = 135;
            nuevobtn.Height = 325;
            nuevobtn.Image = Properties.Resources.Fondo_Venta;
            nuevobtn.ImageAlign = ContentAlignment.TopCenter;
            Panel.Controls.Add(nuevobtn);
            
        }
        public void btn_empleado(string karen_nombre_empleado, string numEmpleado)
        {
            //karen_vector = new Button[karen_contador + 1];
            Button nuevobtn = new System.Windows.Forms.Button();
            nuevobtn.Text = karen_nombre_empleado;
            nuevobtn.Tag = numEmpleado;
            nuevobtn.TextAlign = ContentAlignment.TopCenter;
            nuevobtn.Font = new Font(("Microsoft Sans Serif"), 12, FontStyle.Bold);
            nuevobtn.BackColor = Color.CadetBlue;
            nuevobtn.Width = 100;
            nuevobtn.Height = 80;
            Panel.Controls.Add(nuevobtn);
            nuevobtn.Click += new EventHandler(karen_btnEmpleado_Click);
        }
        public void karen_btnEmpleado_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string karen_contra = Microsoft.VisualBasic.Interaction.InputBox("Ingrese tu contraseña " + btn.Text);
            if (karen_contra == "1")
            {
                Button btnEmpleado = sender as Button;
                nombreEmpleado = btnEmpleado.Text.ToString();
                numEmpleado = btnEmpleado.Tag.ToString();
                Panel.Controls.Clear();
                DateTime thisDay = DateTime.Now;
                //MessageBox.Show(thisDay.ToString("ddMMyyyyhhmmssff"));
                btn.Text = thisDay.ToString("ddMMyyyyhhmmss");
                folio = btn.Text;
                lblFolioVenta.Visible = false;
                lblFolioVenta.Text = btn.Text;
                ConexionMaestra_Karen.Karen_Ejecutar("EXECUTE sp_insertar_venta '" + btn.Text + "','" + numEmpleado + "'");
                ConexionMaestra_Karen.leer_karen.Close();
                //int com = Convert.ToInt32(btn.Tag);
                btn_img();
                lblBoleto.Visible = true;
                karen_mostrar_boletos();
                plusGeneral.Visible = true;
                lblCantidad.Visible = true;
                plusGeneral.Visible = true;
                plusInf.Visible = true;
                plusMayores.Visible = true;
                btnAceptPG.Visible = true;
                btnAceptPI.Visible = true;
                btnAceptPM.Visible = true;
                btnCancelPG.Visible = true;
                btnCancelPI.Visible = true;
                btnCancelPM.Visible = true;
                lblTotal.Visible = true;
                txtToPG.Visible = true;
                txtToPI.Visible = true;
                txtToPM.Visible = true;
                txtMontoTotal.Visible = true;
                btnGuardar.Visible = true;
                txtToPM.Text = vacio;
                txtToPG.Text = vacio;
                txtToPI.Text = vacio;
                //txtFolio.Visible = true;
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }

        public void karen_mostrar_boletos()
        {
            ConexionMaestra_Karen.Karen_Ejecutar("SELECT BOLETO_KAREN.NOMBRE_BOLETO_KAREN, BOLETO_KAREN.ID_BOLETO_KAREN, BOLETO_KAREN.PRECIO_BOLETO_KAREN FROM BOLETO_KAREN");


            //Leer mientras exista un registro
            while (ConexionMaestra_Karen.leer_karen.Read())
            {
                txtBoleto(ConexionMaestra_Karen.leer_karen[0].ToString(),ConexionMaestra_Karen.leer_karen[1].ToString(), ConexionMaestra_Karen.leer_karen[2].ToString());
            }
            //Cerrar el leer
            ConexionMaestra_Karen.leer_karen.Close();
        }

        public void txtBoleto(string nombreBoleto, string idBoleto, String precioBoleto)
        {
            Button nuevo = new Button();

            nuevo.Text = nombreBoleto;
            nuevo.Tag = idBoleto;
            nuevo.Tag = precioBoleto;
            //nuevo.TextAlign = (HorizontalAlignment).ContentAlignment.TopCenter;
            nuevo.Font = new Font(("Microsoft Sans Serif"), 12, FontStyle.Bold);
            nuevo.BackColor = Color.CadetBlue;
            nuevo.Width = 200;
            nuevo.Height = 80;
            PanelBoletos.Controls.Add(nuevo);
        }

        private void btnAceptPG_Click(object sender, EventArgs e)
        {
            
            String sql = "EXECUTE sp_insertar_detalleVenta '"+folio+"', '1','"+plusGeneral.Value+"'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            //MessageBox.Show("Guardado Exitosamente");
            int precioPG = 350;
            int cPG = ((int)Decimal.Parse(Decimal.ToInt32(plusGeneral.Value).ToString()));
            totalPG = precioPG * cPG;
            String t = Convert.ToString(totalPG);

            txtToPG.Text = t;

        }

        private void btnCancelPG_Click(object sender, EventArgs e)
        {
           
            plusGeneral.Value = 0;
            txtToPG.Text = vacio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtToPG.Text);
            int b = Convert.ToInt32(txtToPI.Text);
            int c = Convert.ToInt32(txtToPM.Text);
            int montoTotal = a + b + c;
            String mtotal = Convert.ToString(montoTotal);
            txtMontoTotal.Text = mtotal;
            String sql = "EXECUTE sp_actualizar_venta '"+montoTotal+"', '"+folio+"'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            MessageBox.Show("Guardado Exitosamente");
            btnExcel_Click(sender, e);
            this.Hide();
            MenuPrincipal v = new MenuPrincipal();
            v.Show();
        }

        private void btnCancelPI_Click(object sender, EventArgs e)
        {
            plusInf.Value = 0;
            txtToPI.Text = vacio;
        }

        private void btnCancelPM_Click(object sender, EventArgs e)
        {
            plusMayores.Value = 0;
            txtToPM.Text = vacio;
        }

        private void btnAceptPI_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_detalleVenta '" + folio + "', '6','" + plusInf.Value + "'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            //MessageBox.Show("Guardado Exitosamente");
            int precioPI = 250;
            int cPI = ((int)Decimal.Parse(Decimal.ToInt32(plusInf.Value).ToString()));
            totalPI = precioPI * cPI;
            String tPI = Convert.ToString(totalPI);

            txtToPI.Text = tPI;
        }

        private void btnAceptPM_Click(object sender, EventArgs e)
        {
            String sql = "EXECUTE sp_insertar_detalleVenta '" + folio + "', '8','" + plusMayores.Value + "'";
            ConexionMaestra_Karen.Karen_Ejecutar(sql);
            ConexionMaestra_Karen.leer_karen.Close();
            //MessageBox.Show("Guardado Exitosamente");
            int precioPM = 275;
            int cPM = ((int)Decimal.Parse(Decimal.ToInt32(plusMayores.Value).ToString()));
            totalPM = precioPM * cPM;
            String tPM = Convert.ToString(totalPM);

            txtToPM.Text = tPM;
        }

        /*private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                MessageBox.Show("Tecleo un Enter");
                txtToPG.Focus();
            }
        }*/

        /*private void txtToPG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                button1_Click(sender,e);
            }
            
        }*/

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
            Workbook libro = aplicacion.Workbooks.Add("ticket_venta");
            aplicacion.Visible = true;
            ConexionMaestra_Karen.Karen_Ejecutar("Exec sp_imprimir_venta '"+folio+"'");
            hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[6,4] = folio;
            hoja.Cells[8,4]= numEmpleado;
            int i = 11;
            while (ConexionMaestra_Karen.leer_karen.Read()) { 

                hoja.Cells[i, 2] = ConexionMaestra_Karen.leer_karen[0];
                hoja.Cells[i, 3] = ConexionMaestra_Karen.leer_karen[1];
                hoja.Cells[i, 4] = ConexionMaestra_Karen.leer_karen[2];
                hoja.Cells[i, 5] = ConexionMaestra_Karen.leer_karen[3];
                i++;
            }

            libro.PrintOutEx();
            libro.SaveAs(@"C:\Users\Martínez\Documents\ticket34.xlsx");
            aplicacion.Quit();
        }
    }
}
