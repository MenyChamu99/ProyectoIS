using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDocente;
using System.Data.SqlClient;
using Proyecto_Ing_Soft.Presentacion;
using Proyecto_Ing_Soft;

namespace InterfazDocente
{
    public partial class PlanT : Form
    {
        public PlanT()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlanT_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT Catedratico FROM PlanTrabajo", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbCate.Items.Add(registro["Catedratico"].ToString());
            }
            registro.Close();
            SqlCommand comando2 = new SqlCommand("Select Unidad From PlanTrabajo ", cn);
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cbUnidad.Items.Add(registro2["Unidad"].ToString());
            }
            registro2.Close();
            SqlCommand comando3 = new SqlCommand("Select NombreAsignatura From PlanTrabajo ", cn);
            SqlDataReader registro3 = comando3.ExecuteReader();
            while (registro3.Read())
            {
                cbMateria.Items.Add(registro3["NombreAsignatura"].ToString());
            }
            cn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }


        private void evidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEvidencia SE = new SEvidencia();
            SE.Show();
        }

        private void evidenciaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            SEvidencia SE = new SEvidencia();
            SE.Show();
        }

        private void TR46_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plan de Trabajo Validado","¡Validado!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btnObs_Click(object sender, EventArgs e)
        {
            EnviarObs obs = new EnviarObs();
            obs.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((cbCate.Text != "Seleccionar Catedratico") && (cbUnidad.Text != "Seleccionar Unidad") && (cbMateria.Text != "Seleccionar Materia")) 
            {
                if (c.PTRegistrado(cbCate.Text, Convert.ToInt32(cbUnidad.Text), cbMateria.Text) > 0)
                {

                    c.llenarTextBoxConsultaPTR(cbCate.Text, T2, T3, cbMateria.Text, T5, T7, T9, T6, T8, T10, T13, T11, T12, T30, T33, T36, T37, T39, Convert.ToInt32(cbUnidad.Text), T15, T16, T17, T18, T28, T29, T38, T40, T41, T42, T43, T48, T49, T55, T56, T57, T58, T61, T64);
                    T1.Text = cbCate.Text;
                    T14.Text = cbUnidad.Text;
                    T4.Text = cbMateria.Text;
                }
                else
                {
                    MessageBox.Show("El Plan no existe", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    T1.Text = "";

                }
            }
            else
            {
                MessageBox.Show("No se puede Consultar","Falta Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
