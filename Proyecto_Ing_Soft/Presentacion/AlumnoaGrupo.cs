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

namespace Proyecto_Ing_Soft
{
    public partial class AlumnoaGrupo : Form
    {
        public AlumnoaGrupo()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }

        private void AlumnoaGrupo_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        public void LlenarComboBox()
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT IdAlumno FROM Alumnos", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["idAlumno"].ToString());
            }
            registro.Close();
            SqlCommand comando2 = new SqlCommand("SELECT ID_Grupo FROM Grupo", cn);
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                comboBox2.Items.Add(registro2["ID_Grupo"].ToString());
            }

            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextBoxConsultaAlumno(comboBox1.SelectedItem.ToString(), lbNombres, lbApellidoP, lbApellidoM, lbCarrera);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextBoxConsultaGrupo(comboBox2.SelectedItem.ToString(), lbSemestre, lbGrupo, lbIdMateria);
        }

        private void lbIdMateria_Click(object sender, EventArgs e)
        {

        }

        private void lbIdMateria_TextChanged(object sender, EventArgs e)
        {
            //c.llenarTextBoxConsultaIdMateria(lbIdMateria.Text, lbNombreMateria);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRelacion.Text != "" || comboBox1.Text != "" || comboBox2.Text != "")
            {
                if (c.relacionAGRegistrado(txtRelacion.Text) == 0)
                {
                    c.insertarAG(txtRelacion.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                    MessageBox.Show("Relacion Hecha", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
        }
        public void Limpiar()
        {
            txtRelacion.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            lbNombres.Text = "";
            lbApellidoP.Text = "";
            lbApellidoM.Text = "";
            lbCarrera.Text = "";
            lbSemestre.Text = "";
            lbGrupo.Text = "";
            lbIdMateria.Text = "";
        }
    }
}
