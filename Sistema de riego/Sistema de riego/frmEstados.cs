using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_riego
{
    public partial class frmEstados : MaterialForm
    {

        System.IO.Ports.SerialPort Arduino;
        bool IsClose = false;

        public frmEstados()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen500, Accent.LightGreen200, TextShade.WHITE);

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

        private void frmEstados_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();
        }

        private void EscucharSerial() {
            while (!IsClose) { 
                try { 
                    string humedad = Arduino.ReadLine();
                    lblHumedad.Invoke(new MethodInvoker(
                        delegate {
                            try{
                                int valor = int.Parse(humedad);
                                if(valor>=125 && valor<=304) {
                                    lblHumedad.Text = "Muy alta";
                                }
                                else if(valor>=305 && valor<=484) {
                                    lblHumedad.Text = "Alta";
                                }
                                else if(valor>=485 && valor<=664) {
                                    lblHumedad.Text = "Moderada";
                                }
                                else if(valor>=665 && valor<=844) {
                                    lblHumedad.Text = "Baja";
                                }
                                else if(valor>=845 && valor<=1024) {
                                    lblHumedad.Text = "Muy baja";
                                }
                                double porcentaje = ((Double)(1024-valor)/(Double)1024) * 100;
                                lblPorcentaje.Text = porcentaje.ToString() + " %";
                            } catch {
                                lblHumedad.Text = "Moderada";
                                lblPorcentaje.Text = "50 %";
                            }
                            
                        }
                    ));
                } catch { 
                }
            }
        }

        private void frmEstados_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClose = true;
            if (Arduino.IsOpen) {
                Arduino.Close();
            }
        }
    }
}
