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
    public partial class GrupoaDocente : Form
    {
        public GrupoaDocente()
        {
            InitializeComponent();
        }
        
        Conexion c = new Conexion();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GrupoaDocente_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT ID_Grupo FROM Grupo", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox2.Items.Add(registro["ID_Grupo"].ToString());
            }
            registro.Close();
            SqlCommand comando2 = new SqlCommand("SELECT ID_Usuario FROM Usuarios WHERE Tipo_Usuario='Docente'", cn);
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                comboBox1.Items.Add(registro2["ID_Usuario"].ToString());
            }

            cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //c.llenarTextBoxConsultaGrupo(comboBox2.SelectedItem.ToString(), txtNombre, txtUsuario);

        }
        public void LlenarCampos()
        {
            String valor = comboBox1.SelectedItem.ToString();
            c.llenarTextBoxConsultaUsuario(valor, txtNombre, txtUsuario);
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        
        }
    }
}
