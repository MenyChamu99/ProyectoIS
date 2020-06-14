using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDocente
{
    public partial class SEvidencia : Form
    {
        public SEvidencia()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim().Equals("")|| txtRuta.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms=new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            //using (Datos)
            {

            }
        }
    }
}
