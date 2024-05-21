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
    public partial class frmFertilizacion : MaterialForm
    {
        System.IO.Ports.SerialPort Arduino;
        public frmFertilizacion()
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
            frmInicio frminicio = new frmInicio();
            frminicio.Show();
            this.Close();
        }

        private void btnActivarRiego_Click(object sender, EventArgs e)
        {
            Arduino.Write("4");
        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            Arduino.Write("5");
        }

        private void frmFertilizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen) { 
                Arduino.Close();
            }
        }
    }
}
