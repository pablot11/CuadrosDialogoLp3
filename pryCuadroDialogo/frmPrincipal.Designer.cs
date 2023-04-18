namespace pryCuadroDialogo
{
    partial class frmPrincipal
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
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblCambiarFont = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.fbdCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Location = new System.Drawing.Point(12, 12);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(88, 43);
            this.btnCambiarColor.TabIndex = 0;
            this.btnCambiarColor.Text = "Cambiar Color";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCambiarFont
            // 
            this.lblCambiarFont.AutoSize = true;
            this.lblCambiarFont.Location = new System.Drawing.Point(182, 91);
            this.lblCambiarFont.Name = "lblCambiarFont";
            this.lblCambiarFont.Size = new System.Drawing.Size(110, 13);
            this.lblCambiarFont.TabIndex = 1;
            this.lblCambiarFont.Text = "Cuidado con el perrito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Location = new System.Drawing.Point(242, 12);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(88, 43);
            this.btnCarpeta.TabIndex = 3;
            this.btnCarpeta.Text = "Elegir carpeta";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(354, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(88, 43);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "carpetas, elegir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(460, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 43);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCarpeta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCambiarFont);
            this.Controls.Add(this.btnCambiarColor);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblCambiarFont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.FolderBrowserDialog fbdCarpeta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

