using Datos;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_riego
{
    public partial class frmInicio : MaterialForm

    {
        public frmInicio()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void btnVerEstados_Click(object sender, EventArgs e)
        {
            frmEstados frmestados = new frmEstados();
            frmestados.Show();
            this.Close();
        }

        private void btnModosRiego_Click(object sender, EventArgs e)
        {
            frmModosRiego frmmodosriego = new frmModosRiego();
            frmmodosriego.Show();
            this.Close();
        }

        private void btnModosFertilizacion_Click(object sender, EventArgs e)
        {
            frmFertilizacion frmfertilizacion = new frmFertilizacion();
            frmfertilizacion.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
