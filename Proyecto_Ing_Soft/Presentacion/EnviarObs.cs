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

namespace Proyecto_Ing_Soft.Presentacion
{
    public partial class EnviarObs : Form
    {
        public EnviarObs()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void EnviarObs_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT ID_Usuario FROM Usuarios WHERE Tipo_Usuario= 'Docente'", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbIdDocente.Items.Add(registro["ID_Usuario"].ToString());
            }
            //registro.Close();
            //SqlCommand comando2 = new SqlCommand("SELECT Id_Materia FROM Materias", cn);
            //SqlDataReader registro2 = comando2.ExecuteReader();
            //while (registro2.Read())
            //{
            //    cbIdPlan.Items.Add(registro2["Id_Materia"].ToString());
            //}
            cn.Close();
        }

        private void cbIdDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextBoxConsultaDocente(cbIdDocente.SelectedItem.ToString(), lbNombreD);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
