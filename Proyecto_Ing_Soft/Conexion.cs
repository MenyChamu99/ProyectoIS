using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


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
                MessageBox.Show("No se conecto con la base de datos: "+ex.ToString());
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

        public string actualizar(String id, String nombre, String usuario, String contraseña, String tipousuario)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE Usuarios set Nombre="+nombre+" Usuario="+usuario+" Contraseña="+contraseña+" Tipo_Usuario="+tipousuario+" WHERE ID_Usuario="+id+"",cn);
            }
            catch(Exception ex)
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
