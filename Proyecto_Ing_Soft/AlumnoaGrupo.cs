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

        }
    }
}
