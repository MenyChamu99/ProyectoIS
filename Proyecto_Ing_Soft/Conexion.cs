using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.IO;



namespace Proyecto_Ing_Soft
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");

            } catch (Exception ex)
            {
                //MessageBox.Show("No se conecto con la base de datos: "+ex.ToString());
            }
        }
       
        public string insertar(String id,String nombre,String usuario,String contraseña,String tipodeusuario)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Usuarios(ID_Usuario,Nombre,Usuario,Contraseña,Tipo_Usuario) values('"+id+"','"+nombre+"','"+usuario+"','"+contraseña+"','"+tipodeusuario+"')",cn);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarC(String id, String nombre)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Carrera(ID_Carrera,Nombre) values('" + id + "','" + nombre + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarM(String id, String nombre, String horas, String idcarrera, String creditos, String unidades)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Materias(Id_Materia, Nombre, Horas, Id_Carrera, Creditos, Unidades) values('" + id + "','" + nombre + "','" + horas + "','" + idcarrera + "','" + creditos + "','" + unidades + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarA(String id, String nombre, String apellidoP, String apellidoM, String sexo, String edoCivil, String edad, String fecha, String lugarN, String telefono, String correo, String domicilio, String entidad, String colonia, String carrera, String semestre, String sangre, String nomP, String telP, String nomM, String telM)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Alumnos(idAlumno,Nombres,ApellidoP,ApellidoM,Sexo,EdoCivil,Edad,FechaN,LugarNacimiento,Telefono,Correo,Domicilio,EntFed,Colonia,Carrera,Semestre,TipoSangre,NomPadre,TelPadre,NomMadre,TelMadre) values('" + id + "','" + nombre + "','" + apellidoP + "','" + apellidoM + "','" + sexo + "','" + edoCivil + "','" + edad + "','"+ fecha + "','" + lugarN + "','" + telefono + "','" + correo + "','" + domicilio + "','" + entidad + "','" + colonia + "','" + carrera + "','" + semestre + "','" + sangre + "','" + nomP + "','" + telP + "','" + nomM + "','" + telM + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarG(String id, String semestre, String grupo, String turno, String idmateria)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Grupo(Id_Grupo,Semestre,Grupo,Turno,Id_Materia) values('" + id + "','" + semestre + "','" + grupo + "','" + turno + "','" + idmateria + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarAG(String idA, String idG)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO RAlumnoGrupo(idAlumno, idGrupo) values('" + idA + "','" + idG + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarGD(String idG, String idD)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO RGrupoDocente(idGrupo, idDocente) values('" + idG + "','" + idD + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        // public string insertarCal(String id, String nombres, String apellidop, String apellidom, int unidad1, int unidad2, int unidad3, int unidad4, int unidad5)
        //{
        //  string salida = "Si se inserto";
        //try
        //{
        //  cmd = new SqlCommand("INSERT INTO Calificaciones(IdAlumno,Nombres,ApellidoP,ApellidoM,Unidad1,Unidad2,Unidad3,Unidad4,Unidad5) values('" + id + "','" + nombres + "','" + apellidop + "','" + apellidom + "'," + unidad1 + "," + unidad2 + "," + unidad3 + "," + unidad4 + "," + unidad5 + ")", cn);
        //cmd.ExecuteNonQuery();
        //}
        //catch (Exception ex)
        //{
        //  salida = "No se conecto: " + ex.ToString();
        //}
        //return salida;
        // }
        public string insertarCal1(String id, String nombres, String apellidop, String apellidom, int unidad1)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Calificaciones(IdAlumno,Nombres,ApellidoP,ApellidoM,Unidad1) values('" + id + "','" + nombres + "','" + apellidop + "','" + apellidom + "'," + unidad1 + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarCal2(String id, String nombres, String apellidop, String apellidom, int unidad2)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Calificaciones(IdAlumno,Nombres,ApellidoP,ApellidoM,Unidad2) values('" + id + "','" + nombres + "','" + apellidop + "','" + apellidom + "'," + unidad2 +  ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarCal3(String id, String nombres, String apellidop, String apellidom, int unidad3)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Calificaciones(IdAlumno,Nombres,ApellidoP,ApellidoM,Unidad3) values('" + id + "','" + nombres + "','" + apellidop + "','" + apellidom + "'," + unidad3 + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarCal4(String id, String nombres, String apellidop, String apellidom, int unidad4)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Calificaciones(IdAlumno,Nombres,ApellidoP,ApellidoM,Unidad4) values('" + id + "','" + nombres + "','" + apellidop + "','" + apellidom + "'," + unidad4 +  ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarCal5(String id, String nombres, String apellidop, String apellidom, int unidad5)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Calificaciones(IdAlumno,Nombres,ApellidoP,ApellidoM,Unidad5) values('" + id + "','" + nombres + "','" + apellidop + "','" + apellidom + "'," + unidad5 + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public int personaRegistrada(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Usuarios WHERE ID_Usuario='"+id+"'", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: "+ex.ToString());
            }
            return contador;
        }
        public int carreraRegistrada(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Carrera WHERE ID_Carrera='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int MateriaRegistrada(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Materias WHERE Id_Materia='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int alumnoRegistrado(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Alumnos WHERE idAlumno='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int grupoRegistrado(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Grupo WHERE Id_Grupo='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int relacionAGRegistrado(String idA, String idG)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM RAlumnoGrupo WHERE idAlumno='" + idA + "' AND idGrupo='" + idG + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public int relacionGDRegistrado(String idG, String idD)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM RGrupoDocente WHERE idGrupo='" + idG + "' AND idDocente='" + idD + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int CalificacionRegistrada(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Calificaciones WHERE IdAlumno='"+ id +"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public String CalAlumno(String id)
        {
            string cmp = "";
            try
            {
                cmd = new SqlCommand("SELECT * FROM Calificaciones WHERE IdAlumno='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return cmp;
        }

        public string existeAlumno(string alumno)
        {
            string cmp = "";
            string query = "SELECT * FROM Calificaciones WHERE IdAlumno =@alumno";
            try
            {

            }
            catch (Exception es)
            {
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@alumno", alumno);
                cn.Open();
                cmp = cmd.ExecuteScalar().ToString();
            }
            finally
            {
                cn.Close();
            }
            return cmp;
        }
        public void llenarTextBoxConsulta(String id,TextBox txtNombre, TextBox txtUsuario, TextBox txtContraseña, ComboBox cbtipousuario)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Usuarios WHERE ID_Usuario="+id+"",cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtUsuario.Text = dr["Usuario"].ToString();
                    txtContraseña.Text = dr["Contraseña"].ToString();
                    cbtipousuario.SelectedItem = dr["Tipo_Usuario"].ToString();
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaCarrera(String id, TextBox txtNombreC)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Carrera WHERE ID_Carrera=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreC.Text = dr["Nombre"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaMateria(String id, TextBox txtNombreM, TextBox txtHoras, ComboBox cbIdCarrera, TextBox txtCreditos, TextBox txtUnidades)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Materias WHERE Id_Materia=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreM.Text = dr["Nombre"].ToString();
                    txtHoras.Text = dr["Horas"].ToString();
                    cbIdCarrera.SelectedItem = dr["Id_Carrera"].ToString();
                    txtCreditos.Text = dr["Creditos"].ToString();
                    txtUnidades.Text = dr["Unidades"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaUsuario(String id, TextBox txtNombre, TextBox txtUsuario)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Usuarios WHERE ID_Usuario=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtUsuario.Text = dr["Usuario"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaAlumno(String id, Label lbNombres, Label lbApellidoP, Label lbApellidoM, Label lbCarrera)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Alumnos WHERE idAlumno=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbNombres.Text = dr["Nombres"].ToString();
                    lbApellidoP.Text = dr["ApellidoP"].ToString();
                    lbApellidoM.Text = dr["ApellidoM"].ToString();
                    lbCarrera.Text = dr["Carrera"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaalumno(String id, TextBox txtNombre, TextBox txtApellidoP, TextBox txtApellidoM, ComboBox cbSexo, ComboBox cbEstadoCivil, TextBox txtEdad, TextBox dtbFechaNacimiento, ComboBox cbLugarNac, TextBox txtTelefono, TextBox txtCorreo, TextBox txtDomicilio, ComboBox cbEntidadFede, TextBox txtColonia, ComboBox cbCarrera, ComboBox cbSemestre,ComboBox cbTipoSangre, TextBox txtNombreP, TextBox txtTelefonoP, TextBox txtNombreM, TextBox txtTelefonoM)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Alumnos WHERE idAlumno=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    txtNombre.Text = dr["Nombres"].ToString();   
                    txtApellidoP.Text = dr["ApellidoP"].ToString();
                    txtApellidoM.Text = dr["ApellidoM"].ToString();
                    cbSexo.SelectedItem = dr["Sexo"].ToString();
                    cbEstadoCivil.SelectedItem = dr["EdoCivil"].ToString();
                    txtEdad.Text = dr["Edad"].ToString();
                    dtbFechaNacimiento.Text = dr["FechaN"].ToString();
                    cbLugarNac.SelectedItem = dr["LugarNacimiento"].ToString();
                    txtTelefono.Text = dr["Telefono"].ToString();
                    txtCorreo.Text = dr["Correo"].ToString();
                    txtDomicilio.Text = dr["Domicilio"].ToString();
                    cbEntidadFede.SelectedItem = dr["EntFed"].ToString();
                    txtColonia.Text = dr["Colonia"].ToString();
                    cbCarrera.SelectedItem = dr["Carrera"].ToString();
                    cbSemestre.SelectedItem = dr["Semestre"].ToString();
                    cbTipoSangre.SelectedItem = dr["TipoSangre"].ToString();
                    txtNombreP.Text = dr["NomPadre"].ToString();
                    txtTelefonoP.Text = dr["TelPadre"].ToString();
                    txtNombreM.Text = dr["NomMadre"].ToString();
                    txtTelefonoM.Text = dr["TelMadre"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaGrupo(String id, Label lbSemestre, Label lbGrupo, Label lbIdMateria)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Grupo WHERE Id_Grupo=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbSemestre.Text = dr["Semestre"].ToString();
                    lbGrupo.Text = dr["Grupo"].ToString();
                    lbIdMateria.Text = dr["Id_Materia"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaAlCal(String id, TextBox txtNombres, TextBox txtApellidoP, TextBox txtApellidoM)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Alumnos WHERE idAlumno=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombres.Text = dr["Nombres"].ToString();
                    txtApellidoP.Text = dr["ApellidoP"].ToString();
                    txtApellidoM.Text = dr["ApellidoM"].ToString();

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
         }
            public void llenarTextBoxConsultaCalUni(String idC, TextBox txtU1, TextBox txtU2, TextBox txtU3, TextBox txtU4, TextBox txtU5 )
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM Calificaciones WHERE IdAlumno=" + idC + "", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtU1.Text = dr["Unidad1"].ToString();
                        txtU2.Text = dr["Unidad2"].ToString();
                        txtU3.Text = dr["Unidad3"].ToString();
                        txtU4.Text = dr["Unidad4"].ToString();
                        txtU5.Text = dr["Unidad5"].ToString();
                }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
                }
            }
        //public void llenarTextBoxConsultaIdMateria(String id, Label lbNombreMateria)
        //{
        //    try
        //    {
        //        cmd = new SqlCommand("SELECT * FROM Materias WHERE Id_Materia=" + id + "", cn);
        //        dr2 = cmd.ExecuteReader();
        //        if (dr2.Read())
        //        {
        //            lbNombreMateria.Text = dr2["Nombre"].ToString();

        //        }
        //        dr2.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
        //    }
        //}
        public void llenarTextBoxConsultaMateria2(String id, Label lbNombreMateria)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Materias WHERE Id_Materia=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbNombreMateria.Text = dr["Nombre"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        
        public void llenarTextBoxConsultaDocente(String id, Label lbNombreD)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Usuarios WHERE ID_Usuario=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbNombreD.Text = dr["Nombre"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void cargarPersonas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Usuarios",cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: "+ex);
            }
        }
        public void cargarAlumnos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Calificaciones", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex);
            }
        }

        public string actualizarU(String id, String nombre, String usuario, String contraseña, String tipousuario)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE Usuarios set Nombre = '"+nombre+"', Usuario = '"+usuario+"', Contraseña = '"+contraseña+"', Tipo_Usuario = '"+tipousuario+"' WHERE ID_Usuario="+id+"",cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }

        public string actualizarM(String idM, String nombre, String horas, String idC, String creditos, String unida)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE Materias set Nombre = '" + nombre + "', Horas = '" + horas + "', Id_Carrera = '" + idC + "', Creditos = '" + creditos + "', Unidades = '" + unida + "' WHERE Id_Materia=" + idM + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarC(String idC, String nombre)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE Carrera set Nombre = '" + nombre + "' WHERE ID_Carrera =" + idC + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarCal(String id, String nombres, String apellidop, String apellidom, int unidad1, int unidad2, int unidad3, int unidad4, int unidad5)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE Calificaciones set Nombres = '" + nombres + "', ApellidoP = '" + apellidop + "', ApellidoM = '" + apellidom + "', Unidad1 = '" + unidad1 + "', Unidad2 = '" + unidad2 + "',Unidad3 = '" + unidad3 + "', Unidad4 = '" + unidad4 + "', Unidad5 = '" + unidad5 + "' WHERE IdAlumno =" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarA(String id, String nombre, String apellidoP, String apellidoM, String sexo, String edoCivil, String edad, String fecha, String lugarN, String telefono, String correo, String domicilio, String entidad, String colonia, String carrera, String semestre, String sangre, String nomP, String telP, String nomM, String telM)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE Alumnos set Nombres = '" + nombre + "', ApellidoP = '" + apellidoP + "', ApellidoM = '" + apellidoM + "', Sexo = '" + sexo + "', EdoCivil = '" + edoCivil + "', Edad = '" + edad + "', FechaN = '" + fecha + "', LugarNacimiento = '" + lugarN + "', Telefono = '" + telefono + "', Correo = '" + correo + "', Domicilio = '" + domicilio + "', EntFed = '" + entidad + "', Colonia = '" + colonia + "', Carrera = '" + carrera + "', Semestre = '" + semestre + "', TipoSangre = '" + sangre + "', NomPadre = '" + nomP + "', TelPadre = '" + telP + "', NomMadre = '" + nomM + "', TelMadre = '" + telM + "' WHERE idAlumno=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string Eliminar(String id)
        {
            string salida = "Si se eliminó";
            try
            {
                
                cmd = new SqlCommand("DELETE FROM Usuarios  WHERE ID_Usuario=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se eliminó: " + ex.ToString();
            }
            //cn.Close();
            return salida;
        }
        public string EliminarCarrera(String id)
        {
            string salida = "Si se eliminó";
            try
            {

                cmd = new SqlCommand("DELETE FROM Carrera  WHERE ID_Carrera=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se eliminó: " + ex.ToString();
            }
            //cn.Close();
            return salida;
        }
        public string EliminarMateria(String id)
        {
            string salida = "Si se eliminó";
            try
            {

                cmd = new SqlCommand("DELETE FROM Materias WHERE Id_Materia=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se eliminó: " + ex.ToString();
            }
            //cn.Close();
            return salida;
        }
       
    }
}
