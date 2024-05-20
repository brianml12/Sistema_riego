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
    public partial class frmRiegoManual : MaterialForm

    {
        public frmRiegoManual()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen500, Accent.Red400, TextShade.WHITE);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmModosRiego frmmodosriego = new frmModosRiego();
            frmmodosriego.Show();
            this.Close();
        }
    }
}
