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

        }
    }
}
