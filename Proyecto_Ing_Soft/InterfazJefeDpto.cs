﻿
using InterfazDocente;
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
    public partial class InterfazJefeDpto : Form
    {
     

        public InterfazJefeDpto()
        {
            InitializeComponent();

        }
        Conexion c = new Conexion();


        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
   
                InicioSesion f1 = new InicioSesion();
                f1.Show();
            
        }

        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //crear Alumno
            btnBuscar.Visible = true;
            lbIdAlumno.Visible = true;
            txtIdAlumno.Visible = true;
            lbNombre.Visible = true;
            txtNombre.Visible = true;
            lbApellidoP.Visible = true;
            txtApellidoP.Visible = true;
            lbApellidoM.Visible = true;
            txtApellidoM.Visible = true;
            lbSexo.Visible = true;
            cbSexo.Visible = true;
            lbEstadoCivil.Visible = true;
            cbEstadoCivil.Visible = true;
            lbEdad.Visible = true;
            txtEdad.Visible = true;
            lbFechaNacimiento.Visible = true;
            dtbFechaNacimiento.Visible = true;
            lbLugarNac.Visible = true;
            cbLugarNac.Visible = true;
            lbTelefono.Visible = true;
            txtTelefono.Visible = true;
            lbCorreoEle.Visible = true;
            txtCorreo.Visible = true;
            lbDomicilio.Visible = true;
            txtDomicilio.Visible = true;
            lbEntidadFederativa.Visible = true;
            cbEntidadFede.Visible = true;
            lbColonia.Visible = true;
            txtColonia.Visible = true;
            lbCarrera.Visible = true;
            cbCarrera.Visible = true;
            lbSemestre.Visible = true;
            cbSemestre.Visible = true;
            lbTipodeSangre.Visible = true;
            cbTipoSangre.Visible = true;
            lbNombredelPadre.Visible = true;
            txtNombreP.Visible = true;
            lbTelefonoP.Visible = true;
            txtTelefonoP.Visible = true;
            lbNombreMadre.Visible = true;
            txtNombreM.Visible = true;
            lbTelefonoM.Visible = true;
            txtTelefonoM.Visible = true;
            btnAgregar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            //
            // Crear Grupo
            lbIdGrupo.Visible = false;
            txtIdGrupo.Visible = false;
            lbSemestreG.Visible = false;
            cbSemestreG.Visible = false;
            lbGrupo.Visible = false;
            cbGrupo.Visible = false;
            lbTurno.Visible = false;
            cbTurno.Visible = false;
            btnBuscarG.Visible = false;
            //
            TablaAlumno.Visible = false;
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear Alumno
            btnBuscar.Visible = false;
            lbIdAlumno.Visible = false;
            txtIdAlumno.Visible = false;
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbApellidoP.Visible = false;
            txtApellidoP.Visible = false;
            lbApellidoM.Visible = false;
            txtApellidoM.Visible = false;
            lbSexo.Visible = false;
            cbSexo.Visible = false;
            lbEstadoCivil.Visible = false;
            cbEstadoCivil.Visible = false;
            lbEdad.Visible = false;
            txtEdad.Visible = false;
            lbFechaNacimiento.Visible = false;
            dtbFechaNacimiento.Visible = false;
            lbLugarNac.Visible = false;
            cbLugarNac.Visible = false;
            lbTelefono.Visible = false;
            txtTelefono.Visible = false;
            lbCorreoEle.Visible = false;
            txtCorreo.Visible = false;
            lbDomicilio.Visible = false;
            txtDomicilio.Visible = false;
            lbEntidadFederativa.Visible = false;
            cbEntidadFede.Visible = false;
            lbColonia.Visible = false;
            txtColonia.Visible = false;
            lbCarrera.Visible = false;
            cbCarrera.Visible = false;
            lbSemestre.Visible = false;
            cbSemestre.Visible = false;
            lbTipodeSangre.Visible = false;
            cbTipoSangre.Visible = false;
            lbNombredelPadre.Visible = false;
            txtNombreP.Visible = false;
            lbTelefonoP.Visible = false;
            txtTelefonoP.Visible = false;
            lbNombreMadre.Visible = false;
            txtNombreM.Visible = false;
            lbTelefonoM.Visible = false;
            txtTelefonoM.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            //

            //crear Grupo
            lbIdGrupo.Visible = true;
            txtIdGrupo.Visible = true;
            lbSemestreG.Visible = true;
            cbSemestreG.Visible = true;
            lbGrupo.Visible = true;
            cbGrupo.Visible = true;
            lbTurno.Visible = true;
            cbTurno.Visible = true;
            btnBuscarG.Visible = true;

            //            
            TablaAlumno.Visible = false;
        }

        private void grupoAProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear Alumno
            btnBuscar.Visible = false;
            lbIdAlumno.Visible = false;
            txtIdAlumno.Visible = false;
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbApellidoP.Visible = false;
            txtApellidoP.Visible = false;
            lbApellidoM.Visible = false;
            txtApellidoM.Visible = false;
            lbSexo.Visible = false;
            cbSexo.Visible = false;
            lbEstadoCivil.Visible = false;
            cbEstadoCivil.Visible = false;
            lbEdad.Visible = false;
            txtEdad.Visible = false;
            lbFechaNacimiento.Visible = false;
            dtbFechaNacimiento.Visible = false;
            lbLugarNac.Visible = false;
            cbLugarNac.Visible = false;
            lbTelefono.Visible = false;
            txtTelefono.Visible = false;
            lbCorreoEle.Visible = false;
            txtCorreo.Visible = false;
            lbDomicilio.Visible = false;
            txtDomicilio.Visible = false;
            lbEntidadFederativa.Visible = false;
            cbEntidadFede.Visible = false;
            lbColonia.Visible = false;
            txtColonia.Visible = false;
            lbCarrera.Visible = false;
            cbCarrera.Visible = false;
            lbSemestre.Visible = false;
            cbSemestre.Visible = false;
            lbTipodeSangre.Visible = false;
            cbTipoSangre.Visible = false;
            lbNombredelPadre.Visible = false;
            txtNombreP.Visible = false;
            lbTelefonoP.Visible = false;
            txtTelefonoP.Visible = false;
            lbNombreMadre.Visible = false;
            txtNombreM.Visible = false;
            lbTelefonoM.Visible = false;
            txtTelefonoM.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            //
            // Crear Grupo
            lbIdGrupo.Visible = false;
            txtIdGrupo.Visible = false;
            lbSemestreG.Visible = false;
            cbSemestreG.Visible = false;
            lbGrupo.Visible = false;
            cbGrupo.Visible = false;
            lbTurno.Visible = false;
            cbTurno.Visible = false;
            btnBuscarG.Visible = false;
            //
            TablaAlumno.Visible = false;
            GrupoaDocente f7 = new GrupoaDocente();
            f7.Show();
            
        }

        private void alumnoAGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear Alumno
            btnBuscar.Visible = false;
            lbIdAlumno.Visible = false;
            txtIdAlumno.Visible = false;
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbApellidoP.Visible = false;
            txtApellidoP.Visible = false;
            lbApellidoM.Visible = false;
            txtApellidoM.Visible = false;
            lbSexo.Visible = false;
            cbSexo.Visible = false;
            lbEstadoCivil.Visible = false;
            cbEstadoCivil.Visible = false;
            lbEdad.Visible = false;
            txtEdad.Visible = false;
            lbFechaNacimiento.Visible = false;
            dtbFechaNacimiento.Visible = false;
            lbLugarNac.Visible = false;
            cbLugarNac.Visible = false;
            lbTelefono.Visible = false;
            txtTelefono.Visible = false;
            lbCorreoEle.Visible = false;
            txtCorreo.Visible = false;
            lbDomicilio.Visible = false;
            txtDomicilio.Visible = false;
            lbEntidadFederativa.Visible = false;
            cbEntidadFede.Visible = false;
            lbColonia.Visible = false;
            txtColonia.Visible = false;
            lbCarrera.Visible = false;
            cbCarrera.Visible = false;
            lbSemestre.Visible = false;
            cbSemestre.Visible = false;
            lbTipodeSangre.Visible = false;
            cbTipoSangre.Visible = false;
            lbNombredelPadre.Visible = false;
            txtTelefonoP.Visible = false;
            txtNombreP.Visible = false;
            lbTelefonoP.Visible = false;
            lbNombreMadre.Visible = false;
            txtNombreM.Visible = false;
            lbTelefonoM.Visible = false;
            txtTelefonoM.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            //
            // Crear Grupo
            lbIdGrupo.Visible = false;
            txtIdGrupo.Visible = false;
            lbSemestreG.Visible = false;
            cbSemestreG.Visible = false;
            lbGrupo.Visible = false;
            cbGrupo.Visible = false;
            lbTurno.Visible = false;
            cbTurno.Visible = false;
            btnBuscarG.Visible = false;
            //
            TablaAlumno.Visible = true;
            AlumnoaGrupo f5 = new AlumnoaGrupo();
            f5.Show();
        }

        private void planDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear Alumno
            btnBuscar.Visible = false;
            lbIdAlumno.Visible = false;
            txtIdAlumno.Visible = false;
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbApellidoP.Visible = false;
            txtApellidoP.Visible = false;
            lbApellidoM.Visible = false;
            txtApellidoM.Visible = false;
            lbSexo.Visible = false;
            cbSexo.Visible = false;
            lbEstadoCivil.Visible = false;
            cbEstadoCivil.Visible = false;
            lbEdad.Visible = false;
            txtEdad.Visible = false;
            lbFechaNacimiento.Visible = false;
            dtbFechaNacimiento.Visible = false;
            lbLugarNac.Visible = false;
            cbLugarNac.Visible = false;
            lbTelefono.Visible = false;
            txtTelefono.Visible = false;
            lbCorreoEle.Visible = false;
            txtCorreo.Visible = false;
            lbDomicilio.Visible = false;
            txtDomicilio.Visible = false;
            lbEntidadFederativa.Visible = false;
            cbEntidadFede.Visible = false;
            lbColonia.Visible = false;
            txtColonia.Visible = false;
            lbCarrera.Visible = false;
            cbCarrera.Visible = false;
            lbSemestre.Visible = false;
            cbSemestre.Visible = false;
            lbTipodeSangre.Visible = false;
            cbTipoSangre.Visible = false;
            lbNombredelPadre.Visible = false;
            txtNombreP.Visible = false;
            lbTelefonoP.Visible = false;
            txtTelefonoP.Visible = false;
            lbNombreMadre.Visible = false;
            txtNombreM.Visible = false;
            lbTelefonoM.Visible = false;
            txtTelefonoM.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            //
            // Crear Grupo
            lbIdGrupo.Visible = false;
            txtIdGrupo.Visible = false;
            lbSemestreG.Visible = false;
            cbSemestreG.Visible = false;
            lbGrupo.Visible = false;
            cbGrupo.Visible = false;
            lbTurno.Visible = false;
            cbTurno.Visible = false;
            btnBuscarG.Visible = false;
            //
            TablaAlumno.Visible = false;
            PlanT PT = new PlanT();
            PT.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Conexion c=new Conexion();
            if (txtIdAlumno.Text != "" && txtNombre.Text != "" && txtApellidoP.Text != "" && txtApellidoM.Text != "" && cbSexo.SelectedItem.ToString() != "" && cbEstadoCivil.SelectedItem.ToString() != "" && txtEdad.Text != "" && dtbFechaNacimiento.Value.ToString() != "" && cbLugarNac.SelectedItem.ToString() != "" && txtTelefono.Text != "" && txtCorreo.Text != "" && txtDomicilio.Text != "" && cbEntidadFede.SelectedItem.ToString() != "" && txtColonia.Text != "" && cbCarrera.SelectedItem.ToString() != "" && cbSemestre.SelectedItem.ToString() != "" && cbTipoSangre.SelectedItem.ToString() !=  "" && txtNombreP.Text != "" && txtTelefonoP.Text != "" && txtNombreM.Text != "" && txtTelefonoM.Text != "")
            {
                if (c.alumnoRegistrado(txtIdAlumno.Text) == 0)
                {
                    c.insertarA(txtIdAlumno.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, cbSexo.SelectedItem.ToString(), cbEstadoCivil.SelectedItem.ToString(), txtEdad.Text, dtbFechaNacimiento.Value.ToString(), cbLugarNac.SelectedItem.ToString(), txtTelefono.Text, txtCorreo.Text, txtDomicilio.Text, cbEntidadFede.SelectedItem.ToString(), txtColonia.Text, cbCarrera.SelectedItem.ToString(), cbSemestre.SelectedItem.ToString(), cbTipoSangre.SelectedItem.ToString(), txtNombreP.Text, txtTelefonoP.Text, txtNombreM.Text, txtTelefonoM.Text);
                    MessageBox.Show("Usuario Guardado", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //c.cargarPersonas(Dgv);
                    txtIdAlumno.Clear();
                    txtNombre.Clear();
                    txtApellidoP.Clear();
                    txtApellidoM.Clear();
                    txtEdad.Clear();
                    txtEdad.Clear();
                    txtTelefono.Clear();
                    cbEstadoCivil = null;
                    cbSexo = null;
                    cbLugarNac = null;
                    txtCorreo.Clear();
                    txtDomicilio.Clear();
                    cbEntidadFede = null;
                    txtColonia.Clear();
                    cbCarrera = null;
                    cbSemestre = null;
                    cbTipoSangre = null;
                    txtNombreP.Clear();
                    txtTelefonoP.Clear();
                    txtNombreM.Clear();
                    txtTelefonoP.Clear();


                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdAlumno.Clear();
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

        private void InterfazJefeDpto_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT Nombre FROM Carrera",cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbCarrera.Items.Add(registro["Nombre"].ToString());
            }
            cn.Close();
        }
    }
}

