namespace Sistema_de_riego
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerEstados = new MaterialSkin.Controls.MaterialButton();
            this.btnModosRiego = new MaterialSkin.Controls.MaterialButton();
            this.btnModosFertilizacion = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerEstados
            // 
            this.btnVerEstados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerEstados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerEstados.Depth = 0;
            this.btnVerEstados.HighEmphasis = true;
            this.btnVerEstados.Icon = null;
            this.btnVerEstados.Location = new System.Drawing.Point(89, 163);
            this.btnVerEstados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerEstados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerEstados.Name = "btnVerEstados";
            this.btnVerEstados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerEstados.Size = new System.Drawing.Size(117, 36);
            this.btnVerEstados.TabIndex = 0;
            this.btnVerEstados.Text = "ver estados";
            this.btnVerEstados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerEstados.UseAccentColor = false;
            this.btnVerEstados.UseVisualStyleBackColor = true;
            this.btnVerEstados.Click += new System.EventHandler(this.btnVerEstados_Click);
            // 
            // btnModosRiego
            // 
            this.btnModosRiego.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModosRiego.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModosRiego.Depth = 0;
            this.btnModosRiego.HighEmphasis = true;
            this.btnModosRiego.Icon = null;
            this.btnModosRiego.Location = new System.Drawing.Point(76, 230);
            this.btnModosRiego.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModosRiego.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModosRiego.Name = "btnModosRiego";
            this.btnModosRiego.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModosRiego.Size = new System.Drawing.Size(141, 36);
            this.btnModosRiego.TabIndex = 1;
            this.btnModosRiego.Text = "modos de riego";
            this.btnModosRiego.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModosRiego.UseAccentColor = false;
            this.btnModosRiego.UseVisualStyleBackColor = true;
            this.btnModosRiego.Click += new System.EventHandler(this.btnModosRiego_Click);
            // 
            // btnModosFertilizacion
            // 
            this.btnModosFertilizacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModosFertilizacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModosFertilizacion.Depth = 0;
            this.btnModosFertilizacion.HighEmphasis = true;
            this.btnModosFertilizacion.Icon = null;
            this.btnModosFertilizacion.Location = new System.Drawing.Point(85, 298);
            this.btnModosFertilizacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModosFertilizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModosFertilizacion.Name = "btnModosFertilizacion";
            this.btnModosFertilizacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModosFertilizacion.Size = new System.Drawing.Size(126, 36);
            this.btnModosFertilizacion.TabIndex = 2;
            this.btnModosFertilizacion.Text = "Fertilizacion";
            this.btnModosFertilizacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModosFertilizacion.UseAccentColor = false;
            this.btnModosFertilizacion.UseVisualStyleBackColor = true;
            this.btnModosFertilizacion.Click += new System.EventHandler(this.btnModosFertilizacion_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(7, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(276, 64);
            this.materialCard1.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(52, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(181, 29);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Sistema de riego";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 443);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnModosFertilizacion);
            this.Controls.Add(this.btnModosRiego);
            this.Controls.Add(this.btnVerEstados);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de riego";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnVerEstados;
        private MaterialSkin.Controls.MaterialButton btnModosRiego;
        private MaterialSkin.Controls.MaterialButton btnModosFertilizacion;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

