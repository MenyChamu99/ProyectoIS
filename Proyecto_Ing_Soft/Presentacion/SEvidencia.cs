using Proyecto_Ing_Soft;
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
using System.Data.SqlClient;
//using Proyecto_Ing_Soft.Model1;

namespace InterfazDocente
{
    public partial class SEvidencia : Form
    {
        public SEvidencia()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
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
            if (txClave.Text != ""  && txtNom.Text != "" && txtRuta.Text != "" &&  txClave.Text != "" && combomateria.SelectedItem.ToString() != "" && textBox1.Text != "")
            {
                if (c.EvidenciaRegistrada(txClave.Text) == 0)
                {
                    c.insertarE(txClave.Text, txtNom.Text, txtRuta.Text, combomateria.SelectedItem.ToString(), textBox1.Text);
                    MessageBox.Show("Trabajo Guardado", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txClave.Clear();
                    txtNom.Clear();
                    txtRuta.Clear();
                    combomateria.Text = "";
                    textBox1.Clear();


                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txClave.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //if (txtNom.Text.Trim().Equals("")|| txtRuta.Text.Trim().Equals(""))
            //{
            //    MessageBox.Show("El nombre es obligatorio");
            //     return;
            //}

            // byte[] file = null;
            // Stream myStream = openFileDialog1.OpenFile();
            // using (MemoryStream ms=new MemoryStream())
            // {
            //     myStream.CopyTo(ms);
            //     file = ms.ToArray();
            // }

            ////using (Model1)
            //// {

            //// }
        }

        private void SEvidencia_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT Nombre FROM Materias", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                combomateria.Items.Add(registro["Nombre"].ToString());
            }
            cn.Close();
        }

            
    }
}
