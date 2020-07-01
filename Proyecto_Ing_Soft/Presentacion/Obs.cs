using System;
using Proyecto_Ing_Soft;
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
    public partial class Obs : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        String user,pass;
        public bool lleno;
        public Obs()
        {
            InitializeComponent();
        }
        public Obs(String User, String Pass)
        {
            InitializeComponent();
            this.user = User;
            this.pass = Pass;
        }
        Conexion c = new Conexion();

        private void lbContra_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string usua, contra;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsua.Text != "" && txtContra.Text != "") 
            {
                usua = txtUsua.Text;
                contra = txtContra.Text;
                lbContra.Visible = false;
                lbUsuario.Visible = false;
                txtContra.Visible = false;
                txtUsua.Visible = false;
                btnIngresar.Visible = false;

                label1.Visible = true;
                BandejaE.Visible = true;
                button1.Visible = true;
                logear(txtUsua.Text,txtContra.Text);
                
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void logear(String usuario, String contraseña)
        {
            CamposLlenos(lleno);
            bool bandera = CamposLlenos(lleno);
            if (bandera == true)
            {
                try
                {
                    cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nombre,Tipo_Usuario FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña", cn);
                    cmd.Parameters.AddWithValue("usuario", usuario);
                    cmd.Parameters.AddWithValue("contraseña", contraseña);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                         if (dt.Rows[0][1].ToString() == "Docente")
                        {
                            MessageBox.Show(usua+","+contra);
                            SqlConnection cn2 = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
                            SqlCommand cmd2 = new SqlCommand("select ID_Usuario from Usuarios Where Usuario='" + usua + "' and Contraseña='" + contra + "'", cn2);
                            String Consulta = cmd2.ToString();
                            cn2.Open();
                            DataTable tabla = c.llenarMensajes();
                            MessageBox.Show(Consulta);
                            foreach (DataRow row in tabla.Rows)
                            {
                                if (row["id"].ToString() == Consulta    )
                                {
                                    BandejaE.Text = row["Mensaje"].ToString();
                                }
                            }
                            LimpiarCampos();
                            cn2.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta");
                        LimpiarCampos();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public Boolean CamposLlenos(bool lleno)
        {
            if (txtUsua.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("Ingresar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lleno = false;
                LimpiarCampos();
            }
            else
            {
                lleno = true;
            }
            return lleno;
        }
        public void LimpiarCampos()
        {
            txtUsua.Clear();
            txtContra.Clear();
        }

        //InicioSesion Is = new InicioSesion();
        //Usuario u = new Usuario();

        private void Obs_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese su usuario y contraseña nuevamente","Alerta de seguridad",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //String User = u.getUsuario;
            //String Pass = u.getContraseña;
            //MessageBox.Show(User+","+Pass);
            
        }
    }
}
