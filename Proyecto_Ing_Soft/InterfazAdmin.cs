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
    public partial class InterfazAdmin : Form
    {
        Conexion c = new Conexion();
        public InterfazAdmin()
        {
            InitializeComponent();
        }

        private void jefeDeDptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UsuarioCampos
            lbIdUsuario.Visible = true;
            txtIdUsuario.Visible = true;
            Nombre.Visible = true;
            Usuario.Visible = true;
            Contraseña.Visible = true;
            TipoUsuario.Visible = true;
            //txtID.Visible = false;
            txtNombre.Visible = true;
            txtUsuario.Visible = true;
            txtContra.Visible = true;
            cbTipousuario.Visible = true;
            btnAgregar.Visible = true;
            btnEditarUsuario.Visible = false;
            btnBuscar.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CarreraCampos
            txtIdCarrera.Visible = false;
            IdCarrera.Visible = false;
            NombreCarrera.Visible = false;
            txtNombreC.Visible = false;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //MateriaCampos
            btnAgregarM.Visible = false;
            IdMateria.Visible = false;
            NombreM.Visible = false;
            IdCarreraM.Visible = false;
            Creditos.Visible = false;
            Horas.Visible = false;
            txtIdMateria.Visible = false;
            txtNombreM.Visible = false;
            cbIdCarrera.Visible = false;
            txtCreditos.Visible = false;
            txtHoras.Visible = false;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            txtUnidades.Visible = false;
            lbUnidades.Visible = false;
            //
            DgvUsuarios.Visible = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioSesion f1 = new InicioSesion();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conexion c=new Conexion();
            if (txtIdUsuario.Text!="" && txtNombre.Text!="" && txtUsuario.Text!="" && txtContra.Text!="" && cbTipousuario.SelectedItem.ToString()!=null) {
                if (c.personaRegistrada(txtIdUsuario.Text) == 0)
                {
                    c.insertar(txtIdUsuario.Text, txtNombre.Text, txtUsuario.Text, txtContra.Text, cbTipousuario.SelectedItem.ToString());
                    MessageBox.Show("Usuario Guardado", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.cargarPersonas(DgvUsuarios);
                    txtIdUsuario.Clear();
                    txtNombre.Clear();
                    txtUsuario.Clear();
                    txtContra.Clear();
                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // MessageBox.Show(cbTipousuario.SelectedItem.ToString());
            //MessageBox.Show(txtIdUsuario.Text);
            //  MessageBox.Show(txtNombre.Text);
            // MessageBox.Show(txtUsuario.Text);
            //  MessageBox.Show(txtContra.Text);
            
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UsuarioCampos
            //txtID.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            lbIdUsuario.Visible = false;
            txtIdUsuario.Visible = false;
            //IdUsuario.Visible = false;
            Nombre.Visible = false;
            Usuario.Visible = false;
            Contraseña.Visible = false;
            TipoUsuario.Visible = false;
            //txtID.Visible = false;
            txtNombre.Visible = false;
            txtUsuario.Visible = false;
            txtContra.Visible = false;
            cbTipousuario.Visible = false;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscar.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CarreraCampos
            txtIdCarrera.Visible = true;
            IdCarrera.Visible = true;
            NombreCarrera.Visible = true;
            txtNombreC.Visible = true;
            btnAgregarC.Visible = true;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //CamposMateria
            btnAgregarM.Visible = false;
            IdMateria.Visible = false;
            NombreM.Visible = false;
            IdCarreraM.Visible = false;
            Creditos.Visible = false;
            Horas.Visible = false;
            txtIdMateria.Visible = false;
            txtNombreM.Visible = false;
            txtUnidades.Visible = false;
            lbUnidades.Visible = false;
            cbIdCarrera.Visible = false;
            txtCreditos.Visible = false;
            txtHoras.Visible = false;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            //
            DgvUsuarios.Visible = false;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbIdUsuario.Visible = true;
            txtIdUsuario.Visible = true;
            //IdUsuario.Visible = true;
            Nombre.Visible = true;
            Usuario.Visible = true;
            Contraseña.Visible = true;
            TipoUsuario.Visible = true;
            //txtID.Visible = true;
            txtNombre.Visible = true;
            txtUsuario.Visible = true;
            txtContra.Visible = true;
            cbTipousuario.Visible = true;
            btnEditarUsuario.Visible = true;
            btnBuscar.Visible = true;
            btnAgregar.Visible = false;
            btnEliminarUsuario.Visible = true;
            //CarreraCampos
            txtIdCarrera.Visible = false;
            IdCarrera.Visible = false;
            NombreCarrera.Visible = false;
            txtNombreC.Visible = false;
            btnAgregarC.Visible = false;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //CamposMateria
            btnAgregarM.Visible = false;
            IdMateria.Visible = false;
            NombreM.Visible = false;
            IdCarreraM.Visible = false;
            Creditos.Visible = false;
            Horas.Visible = false;
            txtIdMateria.Visible = false;
            txtNombreM.Visible = false;
            cbIdCarrera.Visible = false;
            txtCreditos.Visible = false;
            txtHoras.Visible = false;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            txtUnidades.Visible = false;
            lbUnidades.Visible = false;
            //
            DgvUsuarios.Visible = false;
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CarreraCampos
            txtIdCarrera.Visible = false;
            IdCarrera.Visible = false;
            NombreCarrera.Visible = false;
            txtNombreC.Visible = false;
            btnAgregarC.Visible = false;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //Usuario Campos
            lbIdUsuario.Visible = false;
            txtIdUsuario.Visible = false;
           // IdUsuario.Visible = false;
            Nombre.Visible = false;
            Usuario.Visible = false;
            Contraseña.Visible = false;
            TipoUsuario.Visible = false;
            //txtID.Visible = false;
            txtNombre.Visible = false;
            txtUsuario.Visible = false;
            txtContra.Visible = false;
            cbTipousuario.Visible = false;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CamposMateria
            btnAgregarM.Visible = true;
            IdMateria.Visible = true;
            NombreM.Visible = true;
            IdCarreraM.Visible = true;
            Creditos.Visible = true;
            Horas.Visible = true;
            txtIdMateria.Visible = true;
            txtNombreM.Visible = true;
            cbIdCarrera.Visible = true;
            txtCreditos.Visible = true;
            txtHoras.Visible = true;
            txtUnidades.Visible = true;
            lbUnidades.Visible = true;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            //
            DgvUsuarios.Visible = false;
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            if (txtIdMateria.Text != "" && txtNombreM.Text != "" && txtUnidades.Text != "" && cbIdCarrera.SelectedIndex != 0 && txtHoras.Text != "" && txtCreditos.Text != "")
            {
                if (c.MateriaRegistrada(txtIdMateria.Text) == 0)
                {
                    c.insertarM(txtIdMateria.Text, txtNombreM.Text, txtHoras.Text, cbIdCarrera.SelectedItem.ToString(), txtCreditos.Text, txtUnidades.Text);
                    MessageBox.Show("Materia Guardada", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //c.cargarPersonas(DgvUsuarios);
                    txtIdMateria.Clear();
                    txtNombreM.Clear();
                    txtHoras.Clear();
                    cbIdCarrera.SelectedIndex = 0;
                    txtCreditos.Clear();
                    txtUnidades.Clear();

                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            if (txtIdCarrera.Text != "" && txtNombreC.Text != "")
            {
                if (c.carreraRegistrada(txtIdCarrera.Text) == 0)
                {
                    c.insertarC(txtIdCarrera.Text, txtNombreC.Text);
                    MessageBox.Show("Carrera Guardada", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //c.cargarPersonas(DgvUsuarios);
                    txtIdCarrera.Clear();
                    txtNombreC.Clear();
                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)//btnEditarUsuario
        {
            MessageBox.Show(c.actualizar(txtIdUsuario.Text, txtNombre.Text, txtUsuario.Text, txtContra.Text, cbTipousuario.SelectedItem.ToString()));
            c.cargarPersonas(DgvUsuarios);
        }

        private void btnEditarCarrera_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar la Materia?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                c.EliminarCarrera(txtIdCarrera.Text);
                txtIdMateria.Clear();
                txtNombreM.Clear();
                txtHoras.Clear();
                cbIdCarrera.SelectedIndex = 0;
                txtCreditos.Clear();
                txtUnidades.Clear();
            }
        }

        private void btnEliminarCarrera_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar la Carrera?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                c.EliminarCarrera(txtIdCarrera.Text);
                txtIdCarrera.Clear();
                txtNombreC.Clear();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el usuario?","Advertencia",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                c.Eliminar(txtIdUsuario.Text);
            }
            
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UsuarioCampos
            //txtID.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            lbIdUsuario.Visible = false;
            txtIdUsuario.Visible = false;
            //IdUsuario.Visible = false;
            Nombre.Visible = false;
            Usuario.Visible = false;
            Contraseña.Visible = false;
            TipoUsuario.Visible = false;
            //txtID.Visible = false;
            txtNombre.Visible = false;
            txtUsuario.Visible = false;
            txtContra.Visible = false;
            cbTipousuario.Visible = false;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscar.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CarreraCampos
            txtIdCarrera.Visible = true;
            IdCarrera.Visible = true;
            NombreCarrera.Visible = true;
            txtNombreC.Visible = true;
            btnAgregarC.Visible = false;
            btnEditarCarrera.Visible = true;
            btnBuscarC.Visible = true;
            btnEliminarCarrera.Visible = true;
            //CamposMateria
            btnAgregarM.Visible = false;
            IdMateria.Visible = false;
            NombreM.Visible = false;
            IdCarreraM.Visible = false;
            Creditos.Visible = false;
            Horas.Visible = false;
            txtIdMateria.Visible = false;
            txtNombreM.Visible = false;
            cbIdCarrera.Visible = false;
            txtCreditos.Visible = false;
            txtHoras.Visible = false;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            txtUnidades.Visible = false;
            lbUnidades.Visible = false;
            //
            DgvUsuarios.Visible = false;
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CarreraCampos
            txtIdCarrera.Visible = false;
            IdCarrera.Visible = false;
            NombreCarrera.Visible = false;
            txtNombreC.Visible = false;
            btnAgregarC.Visible = false;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //Usuario Campos
            lbIdUsuario.Visible = false;
            txtIdUsuario.Visible = false;
            //IdUsuario.Visible = false;
            Nombre.Visible = false;
            Usuario.Visible = false;
            Contraseña.Visible = false;
            TipoUsuario.Visible = false;
            //txtID.Visible = false;
            txtNombre.Visible = false;
            txtUsuario.Visible = false;
            txtContra.Visible = false;
            cbTipousuario.Visible = false;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CamposMateria
            btnAgregarM.Visible = false;
            IdMateria.Visible = true;
            NombreM.Visible = true;
            IdCarreraM.Visible = true;
            Creditos.Visible = true;
            Horas.Visible = true;
            txtIdMateria.Visible = true;
            txtNombreM.Visible = true;
            cbIdCarrera.Visible = true;
            txtCreditos.Visible = true;
            txtHoras.Visible = true;
            btnEditarMateria.Visible = true;
            btnBuscarM.Visible = true;
            btnEliminarMateria.Visible = true;
            txtUnidades.Visible = true;
            lbUnidades.Visible = true;
            //
            DgvUsuarios.Visible = false;
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //UsuarioCampos
            //IdUsuario.Visible = false;
            Nombre.Visible = true;
            Usuario.Visible = true;
            Contraseña.Visible = true;
            TipoUsuario.Visible = true;
           // txtID.Visible = false;
            txtNombre.Visible = true;
            txtUsuario.Visible = true;
            txtContra.Visible = true;
            cbTipousuario.Visible = true;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscar.Visible = false;
            btnEliminarUsuario.Visible = true;
            //CarreraCampos
            txtIdCarrera.Visible = false;
            IdCarrera.Visible = false;
            NombreCarrera.Visible = false;
            txtNombreC.Visible = false;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //MateriaCampos
            btnAgregarM.Visible = false;
            IdMateria.Visible = false;
            NombreM.Visible = false;
            IdCarreraM.Visible = false;
            Creditos.Visible = false;
            Horas.Visible = false;
            txtIdMateria.Visible = false;
            txtNombreM.Visible = false;
            cbIdCarrera.Visible = false;
            txtCreditos.Visible = false;
            txtHoras.Visible = false;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            //
            DgvUsuarios.Visible = false;
        }

        private void carreraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //UsuarioCampos
           // txtID.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
           // IdUsuario.Visible = false;
            Nombre.Visible = false;
            Usuario.Visible = false;
            Contraseña.Visible = false;
            TipoUsuario.Visible = false;
            //txtID.Visible = false;
            txtNombre.Visible = false;
            txtUsuario.Visible = false;
            txtContra.Visible = false;
            cbTipousuario.Visible = false;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnBuscar.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CarreraCampos
            txtIdCarrera.Visible = true;
            IdCarrera.Visible = true;
            NombreCarrera.Visible = true;
            txtNombreC.Visible = true;
            btnAgregarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnBuscarC.Visible = true;
            btnEliminarCarrera.Visible = true;

            //CamposMateria
            btnAgregarM.Visible = false;
            IdMateria.Visible = false;
            NombreM.Visible = false;
            IdCarreraM.Visible = false;
            Creditos.Visible = false;
            Horas.Visible = false;
            txtIdMateria.Visible = false;
            txtNombreM.Visible = false;
            cbIdCarrera.Visible = false;
            txtCreditos.Visible = false;
            txtHoras.Visible = false;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = false;
            btnEliminarMateria.Visible = false;
            //
            DgvUsuarios.Visible = false;
        }

        private void materiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CarreraCampos
            txtIdCarrera.Visible = false;
            IdCarrera.Visible = false;
            NombreCarrera.Visible = false;
            txtNombreC.Visible = false;
            btnAgregarC.Visible = false;
            btnBuscarC.Visible = false;
            btnEditarCarrera.Visible = false;
            btnEliminarCarrera.Visible = false;
            //Usuario Campos
            //IdUsuario.Visible = false;
            Nombre.Visible = false;
            Usuario.Visible = false;
            Contraseña.Visible = false;
            TipoUsuario.Visible = false;
            //txtID.Visible = false;
            txtNombre.Visible = false;
            txtUsuario.Visible = false;
            txtContra.Visible = false;
            cbTipousuario.Visible = false;
            btnAgregar.Visible = false;
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            //CamposMateria
            btnAgregarM.Visible = false;
            IdMateria.Visible = true;
            NombreM.Visible = true;
            IdCarreraM.Visible = true;
            Creditos.Visible = true;
            Horas.Visible = true;
            txtIdMateria.Visible = true;
            txtNombreM.Visible = true;
            cbIdCarrera.Visible = true;
            txtCreditos.Visible = true;
            txtHoras.Visible = true;
            btnEditarMateria.Visible = false;
            btnBuscarM.Visible = true;
            btnEliminarMateria.Visible = true;
            //
            DgvUsuarios.Visible = false;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargarPersonas(DgvUsuarios);
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT ID_Carrera FROM Carrera", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbIdCarrera.Items.Add(registro["ID_Carrera"].ToString());
            }
            cn.Close();
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(txtIdUsuario.Text) > 0)
            {
                c.llenarTextBoxConsulta(txtIdUsuario.Text, txtNombre, txtUsuario, txtContra, cbTipousuario);
            }
            else
            {
                MessageBox.Show("El Usuario no existe","No existe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtContra.Text = "";
                cbTipousuario.SelectedIndex = 0;
            }
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            if (c.carreraRegistrada(txtIdCarrera.Text) > 0)
            {
                c.llenarTextBoxConsultaCarrera(txtIdCarrera.Text, txtNombreC);
            }
            else
            {
                MessageBox.Show("La carrera no existe", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtIdCarrera.Text = "";
            }
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            if (c.MateriaRegistrada(txtIdMateria.Text) > 0)
            {
                c.llenarTextBoxConsultaMateria(txtIdMateria.Text, txtNombreM, txtHoras , cbIdCarrera, txtCreditos , txtUnidades);
            }
            else
            {
                MessageBox.Show("La carrera no existe", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                //txtIdCarrera.Text = "";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdMateria_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
