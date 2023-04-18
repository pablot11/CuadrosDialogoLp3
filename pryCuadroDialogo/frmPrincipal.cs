using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCuadroDialogo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para que se muestre el cuadro usamos le metodo showdialog
            fontDialog1.ShowDialog();
            //
            lblCambiarFont.Font = fontDialog1.Font;



        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            //Elegir carpeta y sacar su ruta
            fbdCarpeta.ShowDialog();
            MessageBox.Show(fbdCarpeta.SelectedPath);


        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Para filtrar archivos, sea mas como al usuario
            openFileDialog1.Filter = "Archivo de texto |*txt";
            openFileDialog1.FileName = "";
            //Elegir elarchivo de una carpeta
            openFileDialog1.ShowDialog();
            //Ruta del archivo
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            
            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
