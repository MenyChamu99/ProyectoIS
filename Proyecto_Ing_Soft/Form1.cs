using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using InterfazDocente;

namespace Proyecto_Ing_Soft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-38Q67F7T\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security = True");
        
        public void logear(String usuario, String contraseña)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingresar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            { 
                try
                {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre,Tipo_Usuario FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contraseña", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                            Form3 f3 = new Form3();
                            f3.Show();
                            textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else if (dt.Rows[0][1].ToString() == "Docente")
                    {
                            ID id = new ID();
                            id.Show();
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else if (dt.Rows[0][1].ToString() == "Jefe")
                        {
                            Form4 f4 = new Form4();
                            f4.Show();
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                    }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                    con.Close();
            }
        }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text,this.textBox2.Text);
            //if (textBox1.Text == "" || textBox2.Text == "")
            //{
            //    MessageBox.Show("Ingresar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    Form2 f2 = new Form2();
            //    f2.Show();
            //    // this.Close();
            //    textBox1.Text = "";
            //    textBox2.Text = "";
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                logear(this.textBox1.Text, this.textBox2.Text);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
