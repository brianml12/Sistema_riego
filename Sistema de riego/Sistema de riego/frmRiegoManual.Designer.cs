﻿namespace Sistema_de_riego
{
    partial class frmRiegoManual
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
            this.btnActivarRiego = new MaterialSkin.Controls.MaterialButton();
            this.btnAutomatico = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivarRiego
            // 
            this.btnActivarRiego.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActivarRiego.BackColor = System.Drawing.SystemColors.Control;
            this.btnActivarRiego.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActivarRiego.Depth = 0;
            this.btnActivarRiego.HighEmphasis = true;
            this.btnActivarRiego.Icon = null;
            this.btnActivarRiego.Location = new System.Drawing.Point(83, 207);
            this.btnActivarRiego.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActivarRiego.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActivarRiego.Name = "btnActivarRiego";
            this.btnActivarRiego.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActivarRiego.Size = new System.Drawing.Size(128, 36);
            this.btnActivarRiego.TabIndex = 0;
            this.btnActivarRiego.Text = "Activar Riego";
            this.btnActivarRiego.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActivarRiego.UseAccentColor = false;
            this.btnActivarRiego.UseVisualStyleBackColor = false;
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAutomatico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAutomatico.Depth = 0;
            this.btnAutomatico.HighEmphasis = true;
            this.btnAutomatico.Icon = null;
            this.btnAutomatico.Location = new System.Drawing.Point(69, 294);
            this.btnAutomatico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAutomatico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAutomatico.Size = new System.Drawing.Size(155, 36);
            this.btnAutomatico.TabIndex = 1;
            this.btnAutomatico.Text = "Desactivar Riego";
            this.btnAutomatico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAutomatico.UseAccentColor = true;
            this.btnAutomatico.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnVolver);
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
            // btnVolver
            // 
            this.btnVolver.Image = global::Sistema_de_riego.Properties.Resources.flecha;
            this.btnVolver.Location = new System.Drawing.Point(17, 19);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(30, 28);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 5;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(70, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 29);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Riego Manual";
            // 
            // frmRiegoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 443);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnAutomatico);
            this.Controls.Add(this.btnActivarRiego);
            this.Name = "frmRiegoManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de riego";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnActivarRiego;
        private MaterialSkin.Controls.MaterialButton btnAutomatico;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnVolver;
    }
}

