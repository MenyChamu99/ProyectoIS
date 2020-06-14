using Proyecto_Ing_Soft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDocente
{
    public partial class Calif : Form
    {
        public Calif()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        bool aprobado;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Calif_Load(object sender, EventArgs e)
        {
            c.cargarAlumnos(TablaCalif);
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT idAlumno FROM Alumnos", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox2.Items.Add(registro["idAlumno"].ToString());
            }
            cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextBoxConsultaAlCal(comboBox2.SelectedItem.ToString(), txtNombres, txtApellidoP, txtApellidoM);
            c.llenarTextBoxConsultaCalUni(comboBox2.SelectedItem.ToString(), txtU1, txtU2, txtU3, txtU4, txtU5);
           
            //this.txtU1.Text = "";
            //txtU2.Text = "";
            //txtU3.Text = "";
            //txtU4.Text = "";
            //txtU5.Text = "";
       

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" || txtNombres.Text != "" || txtApellidoP.Text != "" || txtApellidoM.Text != "")
            {
                if (c.CalificacionRegistrada(comboBox2.SelectedIndex.ToString()) == 0)
                {
                    //c.insertarCal(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU1.Text) , Convert.ToInt32(txtU2.Text), Convert.ToInt32(txtU3.Text), Convert.ToInt32(txtU4.Text), Convert.ToInt32(txtU5.Text));
                    c.insertarCal1(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU1.Text));
                   
                    c.cargarAlumnos(TablaCalif);

                    c.insertarCal2(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU2.Text));
                    
                    c.cargarAlumnos(TablaCalif);

                    c.insertarCal3(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU3.Text));
                    
                    c.cargarAlumnos(TablaCalif);

                    c.insertarCal4(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU4.Text));
                    
                    c.cargarAlumnos(TablaCalif);

                    c.insertarCal5(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU5.Text));
                    
                    c.cargarAlumnos(TablaCalif);
                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (c.CalAlumno(comboBox2.SelectedIndex.ToString())== (TablaCalif.ToString())) {

                btnActualizar.Enabled = true;

                if (comboBox2.Text != "" || txtNombres.Text != "" || txtApellidoP.Text != "" || txtApellidoM.Text != "")
                {
                    c.actualizarCal(comboBox2.Text, txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt32(txtU1.Text), Convert.ToInt32(txtU2.Text), Convert.ToInt32(txtU3.Text), Convert.ToInt32(txtU4.Text), Convert.ToInt32(txtU5.Text));
                    MessageBox.Show("Calificación actualizada", "Actualización Hecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.cargarAlumnos(TablaCalif);


                }
            }
        }

        public static bool ValidarCampoEntero(TextBox cajatexto)
        {
            try
            {
                int d=Convert.ToInt32(cajatexto.Text);
                return true;
            }
            catch
            {
                cajatexto.Text = "0";
                cajatexto.Select(0, cajatexto.Text.Length);
                return false;

            }
        }

        public Boolean Promedio(bool aprobado)
        {
            int numerouni = 0;
            if (txtU1.Text != "")
            {
                numerouni++;
            }
            if (txtU2.Text != "")
            {
                numerouni++;
            }
            if (txtU3.Text != "")
            {
                numerouni++;
            }
            if (txtU4.Text != "")
            {
                numerouni++;
            }
            if (txtU5.Text != "")
            {
                numerouni++;
            }

          float promedio = (Convert.ToInt32(txtU1.Text) + Convert.ToInt32(txtU2.Text) + Convert.ToInt32(txtU3.Text) + Convert.ToInt32(txtU4.Text) + Convert.ToInt32(txtU5.Text)) / numerouni;
            if (promedio >= 70)
            {
                aprobado = true;
            }
            else
            {
                aprobado = false;
            }
            return aprobado;
        }
        bool unidadaprobada;
        public Boolean UnidadAprobada(bool unidadaprobada)
        {
            if (Convert.ToInt32(txtU1.Text) >= 70)
            {
                unidadaprobada = true;
            }
            else
            {
                unidadaprobada = false;
            }
            return unidadaprobada;
        }

        public static int SumaCalif(int cal1, int cal2, int cal3, int cal4, int cal5)
        {
            return cal1 + cal2 + cal3 + cal4 + cal5;
        }

        private void txtU1_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoEntero((TextBox)sender);
        }

        private void txtU2_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoEntero((TextBox)sender);
        }

        private void txtU3_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoEntero((TextBox)sender);
        }

        private void txtU4_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoEntero((TextBox)sender);
        }

        private void txtU5_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoEntero((TextBox)sender);
        }
    }
}
