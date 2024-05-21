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
        System.IO.Ports.SerialPort Arduino;
        public frmRiegoManual()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen500, Accent.Red400, TextShade.WHITE);

            // Inicializar comunicación serial
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM8";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmModosRiego frmmodosriego = new frmModosRiego();
            frmmodosriego.Show();
            this.Close();
        }

        private void btnActivarRiego_Click(object sender, EventArgs e)
        {
            Arduino.Write("2");
        }

        private void frmRiegoManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen) { 
                Arduino.Close();
            }
        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            Arduino.Write("3");
        }
    }
}
