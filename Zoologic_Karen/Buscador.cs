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
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            ConexionMaestra_Karen.abrir_karen();
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra_Karen.grid(datos,"EXEC sp_buscador_boleto '%"+txtBuscador.Text+"%'");
        }
    }
}
