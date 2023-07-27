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
    public partial class InformacionAnimal : Form
    {
        public InformacionAnimal()
        {
            InitializeComponent();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento v = new Mantenimiento();
            v.Show();
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlimentacionAnimal v = new AlimentacionAnimal();
            v.Show();
        }

        private void btnLocacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocacionAnimal v = new LocacionAnimal();
            v.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal v = new MenuPrincipal();
            v.Show();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animal v = new Animal();
            v.Show();
        }

        private void btnAtecionA_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtencionAnimal v = new AtencionAnimal();
            v.Show();
        }

        private void InformacionAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
