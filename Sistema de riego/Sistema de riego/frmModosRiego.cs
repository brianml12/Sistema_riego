using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frmModosRiego : MaterialForm

    {
        public frmModosRiego()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio frminicio = new frmInicio();
            frminicio.Show();
            this.Close();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmRiegoManual frmriegomanual = new frmRiegoManual();
            frmriegomanual.Show();
            this.Close();
        }
    }
}
