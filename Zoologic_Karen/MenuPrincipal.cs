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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.abrir_karen();

        }

        private void btnAggDatos_Click_1(object sender, EventArgs e)
        {
            AgregarDatos n = new AgregarDatos();
            n.ShowDialog();
        }

        private void btnInfAnimal_Click_1(object sender, EventArgs e)
        {
            InformacionAnimal v = new InformacionAnimal();
            v.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Venta_Boetos V =new  Venta_Boetos();
            V.Show();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            Buscador v = new Buscador();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancelaciones v = new Cancelaciones();
            v.Show();
        }
    }
}
