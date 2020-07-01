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
    public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr, dr2;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder cb;
        //String User;
        //String Pass;
        DataSet ds;
        public bool igual=false;

        //public string User1 { get => User; set => User = value; }
        //public string Pass1 { get => Pass; set => Pass = value; }

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
                cmd = new SqlCommand("INSERT INTO Alumnos(idAlumno,Nombres,ApellidoP,ApellidoM,Sexo,EdoCivil,Edad,FechaN,LugarNacimiento,Telefono,Correo,Domicilio,EntFed,Colonia,Carrera,Semestre,TipoSangre,NomPadre,TelPadre,NomMadre,TelMadre,Unidad1,Unidad2,Unidad3,Unidad4,Unidad5) values('" + id + "','" + nombre + "','" + apellidoP + "','" + apellidoM + "','" + sexo + "','" + edoCivil + "','" + edad + "','"+ fecha + "','" + lugarN + "','" + telefono + "','" + correo + "','" + domicilio + "','" + entidad + "','" + colonia + "','" + carrera + "','" + semestre + "','" + sangre + "','" + nomP + "','" + telP + "','" + nomM + "','" + telM + "',null,null,null,null,null)", cn);
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
        public string insertarCal1(String id,  int unidad1)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + ",null,null,null,null" , cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string insertarCal2(String id, int unidad1, int unidad2)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + ",null,null,null", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string insertarCal3(String id, int unidad1, int unidad2, int unidad3)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + "," + unidad3 + ",null,null", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string insertarCal4(String id, int unidad1, int unidad2, int unidad3, int unidad4)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + "," + unidad3 + "," + unidad4 + ",null", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string insertarCal(String id, int unidad1, int unidad2, int unidad3, int unidad4,int unidad5)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + "," + unidad3 + "," + unidad4 + "," + unidad5, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string insertarMensaje(String id, String mensaje)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Mensajes(idProfesor,Mensaje) values('" + id + "','" + mensaje + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarPT(String catedratico, String periodo, String planEs, String nombreA, String claveA, int numU, String grupo, String horasT, String horasP, int creditos, String caracteAsig, String compeAsig, String IntencionD, String practicas, String visitas, String porRepro, String porDes, String fichaRe, int unidad, String competecniaE, String sesionesPro, String sesionesRea, String subtemas, String sesionEval, String sesionRealEva, String observa, String actiApren, String ActEnse, String competenciasGen, String apoyosDida, String equipoRe, String fuentesInf, String conseptual, String procedimental, String actitud, String indicador, String evidencia, String fechaEnt)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO PlanTrabajo(Catedratico, Periodo, PlanEstudios, NombreAsignatura, ClaveAsignatura, NumUnidades, Grupo, HrsTeoricas, HrsPracticas, Creditos, CaracterizacionAsign, CompetenciaAsign, IntencionDida, PracticasRequeridas, VisitasRequeridas, PorReprobacion, PorDes, FichaRevision, Unidad, CompetenciaEsp, SesionesPro, SesionesReales, Subtemas, SesionEvalUni, SesionRealEva, Observaciones, ActividadesApren, ActividadesEnseñ, CompetenciasGen, ApoyosDida, EquipoRequerido, FuentesInfo, Conceptual, Procedimental, Actitudinal, IndicadorAlcance, Evidencia, FechaEntrega) values('" + catedratico + "','" + periodo + "','" + planEs + "','" + nombreA + "','" + claveA + "'," + numU + ",'" + grupo + "','" + horasT + "','" +  horasP + "'," + creditos + ",'" + caracteAsig + "','" + compeAsig + "','" + IntencionD + "','" + practicas + "','" + visitas + "','" + porRepro + "','" + porDes + "','" + fichaRe + "'," + unidad + ",'" + competecniaE + "','" + sesionesPro + "','" + sesionesRea + "','" + subtemas + "','" + sesionEval + "','" + sesionRealEva + "','" + observa + "','" + actiApren + "','" + ActEnse + "','" + competenciasGen + "','" + apoyosDida + "','" + equipoRe + "','" + fuentesInf + "','" + conseptual + "','" + procedimental + "','" + actitud + "','" + indicador + "','" + evidencia + "','" + fechaEnt + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string insertarRF(String departamentoA, String reporte, String docente, String numG, String numA, String periodo, String carrera, String asignatura, String totalE, String primeraO, String segundaO, String acreditacion, String noAcredi, String porNoAcredi, String deserto, String porDesercion, String sumaE, String total1, String total2, String total3, String total4, String total5, String total6, String total7, String total8, String total9)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO ReporteFinal(DepartamentoA, ReporteFinal, Docente, NumGrup, NumAsig, Periodo, Carrera, Asignatura, TotalEstudiantes, PrimeraOportunidad, SegundaOportunidad, Acreditacion, NoAcreditado, PorNoAcreditacion, Deserto, PorDesercion, SumaEstudiantes, Total1, Total2, Total3, Total4, Total5, Total6, Total7, Total8, Total9) values('" + departamentoA + "','" + reporte + "','" + docente + "','" + numG + "','" + numA + "','" + periodo + "','" + carrera + "','" + asignatura + "','" + totalE + "','" + primeraO + "','" + segundaO + "','" + acreditacion + "','" + noAcredi + "','" + porNoAcredi + "','" + deserto + "','" + porDesercion + "','" + sumaE + "','" + total1 + "','" + total2 + "','" + total3 + "','" + total4 + "','" + total5 + "','" + total6 + "','" + total7 + "','" + total8 + "','" + total9 + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarE(String id, String nomA, String nomR, String nomM, String comentarios)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO SubirArchivo(Id_Archivo, NombreArchivo, NombreReal, NomMateria, Comentarios) values('" + id + "','" + nomA + "','" + nomR + "','" + nomM + "','" + comentarios + "')", cn);
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

        public int PTRegistrado(String cat, int unidad,String nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM PlanTrabajo WHERE Catedratico='" + cat + "' AND Unidad='" + unidad + "' AND NombreAsignatura='"+nombre+"'", cn);
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

        public int RFRegistrado(String docente, String periodo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM ReporteFinal WHERE Docente='" + docente + "' AND Periodo='" + periodo + "'", cn);
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
        public Boolean CalAlumno(String id)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Calificaciones WHERE IdAlumno='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    igual = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return igual;
        }

        public int EvidenciaRegistrada(String id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM SubirArchivo WHERE Id_Archivo='" + id + "'", cn);
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
                    cbtipousuario.Text = dr["Tipo_Usuario"].ToString();
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
                    cbIdCarrera.Text = dr["Id_Carrera"].ToString();
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
                    cbSexo.Text = dr["Sexo"].ToString();
                    cbEstadoCivil.Text = dr["EdoCivil"].ToString();
                    txtEdad.Text = dr["Edad"].ToString();
                    dtbFechaNacimiento.Text = dr["FechaN"].ToString();
                    cbLugarNac.Text = dr["LugarNacimiento"].ToString();
                    txtTelefono.Text = dr["Telefono"].ToString();
                    txtCorreo.Text = dr["Correo"].ToString();
                    txtDomicilio.Text = dr["Domicilio"].ToString();
                    cbEntidadFede.Text = dr["EntFed"].ToString();
                    txtColonia.Text = dr["Colonia"].ToString();
                    cbCarrera.Text = dr["Carrera"].ToString();
                    cbSemestre.Text = dr["Semestre"].ToString();
                    cbTipoSangre.Text = dr["TipoSangre"].ToString();
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
        public void llenarTextBoxConsultagrupo(String id, ComboBox cbSemestre, ComboBox cbGrupo,ComboBox cbTurno, ComboBox cbIdMateria)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Grupo WHERE Id_Grupo=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cbSemestre.Text = dr["Semestre"].ToString();
                    cbGrupo.Text = dr["Grupo"].ToString();
                    cbTurno.Text = dr["Turno"].ToString();
                    cbIdMateria.Text = dr["Id_Materia"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaAlCal(String id, TextBox txtNombres, TextBox txtApellidoP, TextBox txtApellidoM, TextBox txtU1, TextBox txtU2, TextBox txtU3, TextBox txtU4, TextBox txtU5)
        {

            try
            {

                da = new SqlDataAdapter("Select idAlumno[Número Control],Nombres[Nombres], ApellidoP[Apellido Paterno], ApellidoM[Apellido Materno], Unidad1[Unidad 1], Unidad2[Unidad 2], Unidad3[Unidad 3], Unidad4[Unidad 4], Unidad5[Unidad 5] from Alumnos WHERE idAlumno=" + id + "", cn);             
                dt = new DataTable();
                da.Fill(dt);
                cmd = new SqlCommand("Select idAlumno[Número Control],Nombres[Nombres], ApellidoP[Apellido Paterno], ApellidoM[Apellido Materno], Unidad1[Unidad 1], Unidad2[Unidad 2], Unidad3[Unidad 3], Unidad4[Unidad 4], Unidad5[Unidad 5] from Alumnos WHERE idAlumno=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DataRow row;
                    row = dt.Rows[0];
                    txtNombres.Text = row["Nombres"].ToString();
                    txtApellidoP.Text = row["Apellido Paterno"].ToString();
                    txtApellidoM.Text = row["Apellido Materno"].ToString();
                    txtU1.Text = row["Unidad 1"].ToString();
                    txtU2.Text = row["Unidad 2"].ToString();
                    txtU3.Text = row["Unidad 3"].ToString();
                    txtU4.Text = row["Unidad 4"].ToString();
                    txtU5.Text = row["Unidad 5"].ToString();
                }
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
         }
        public DataTable llenarMensajes()
        {
            try
            {

                da = new SqlDataAdapter("Select idProfesor id,Mensaje mensaje From Mensajes", cn);
                dt = new DataTable();
                da.Fill(dt);
   
                //dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
            return dt;
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
        public void llenarTextBoxConsultaMateriaPT(String id, TextBox T5, TextBox T10)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Materias WHERE Id_Materia=" + id + "", cn);
                dr2 = cmd.ExecuteReader();
                if (dr2.Read())
                {
                    T5.Text = dr2["Nombre"].ToString();
                    T10.Text = dr2["Creditos"].ToString();
                }
                dr2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }

        public void llenarTextBoxConsultaRF( TextBox TR1, TextBox TR2, String docente, TextBox TR4, TextBox TR5, String periodo, TextBox TR7, TextBox TR8, TextBox TR9, TextBox TR10, TextBox TR11, TextBox TR12, TextBox TR13, TextBox TR14, TextBox TR15, TextBox TR16, TextBox TR17, TextBox TR18, TextBox TR19, TextBox TR20, TextBox TR21, TextBox TR22, TextBox TR23, TextBox TR24, TextBox TR25, TextBox TR26)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM ReporteFinal WHERE Docente='" + docente + "'AND Periodo='" + periodo +"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TR1.Text = dr["DepartamentoA"].ToString();
                    TR2.Text = dr["ReporteFinal"].ToString();
                    TR4.Text = dr["NumGrup"].ToString();
                    TR5.Text = dr["NumAsig"].ToString();
                    TR7.Text = dr["Carrera"].ToString();
                    TR8.Text = dr["Asignatura"].ToString();
                    TR9.Text = dr["TotalEstudiantes"].ToString();
                    TR10.Text = dr["PrimeraOportunidad"].ToString();
                    TR11.Text = dr["SegundaOportunidad"].ToString();
                    TR12.Text = dr["Acreditacion"].ToString();
                    TR13.Text = dr["NoAcreditado"].ToString();
                    TR14.Text = dr["PorNoAcreditacion"].ToString();
                    TR15.Text = dr["Deserto"].ToString();
                    TR16.Text = dr["PorDesercion"].ToString();
                    TR17.Text = dr["SumaEstudiantes"].ToString();
                    TR18.Text = dr["Total1"].ToString();
                    TR19.Text = dr["Total2"].ToString();
                    TR20.Text = dr["Total3"].ToString();
                    TR21.Text = dr["Total4"].ToString();
                    TR22.Text = dr["Total5"].ToString();
                    TR23.Text = dr["Total6"].ToString();
                    TR24.Text = dr["Total7"].ToString();
                    TR25.Text = dr["Total8"].ToString();
                    TR26.Text = dr["Total9"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }

        public void llenarTextBoxConsultaPT(String T1, ComboBox T2, TextBox T3, TextBox T5, ComboBox combobox2, TextBox T7, ComboBox combobox3, TextBox T6, TextBox T8, TextBox T10, TextBox T13, TextBox T11, TextBox T12, TextBox T30, TextBox T33, TextBox T36, TextBox T37, TextBox T39, int T14, TextBox T15, TextBox T16, TextBox T17, TextBox T18, TextBox T28, TextBox T29, TextBox T38, TextBox T40, TextBox T41, TextBox T42, TextBox T43, TextBox T48, TextBox T49, TextBox T55, TextBox T56, TextBox T57, TextBox T58, TextBox T61, TextBox T64)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM PlanTrabajo WHERE Catedratico='" + T1 + "'AND Unidad='" + T14 + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    T2.Text = dr["Periodo"].ToString();
                    T3.Text = dr["PlanEstudios"].ToString();
                    T5.Text = dr["NombreAsignatura"].ToString();
                    combobox2.Text = dr["ClaveAsignatura"].ToString();
                    T7.Text = dr["NumUnidades"].ToString();
                    combobox3.Text = dr["Grupo"].ToString();
                    T6.Text = dr["HrsTeoricas"].ToString();
                    T8.Text = dr["HrsPracticas"].ToString();
                    T10.Text = dr["Creditos"].ToString();
                    T13.Text = dr["CaracterizacionAsign"].ToString();
                    T11.Text = dr["CompetenciaAsign"].ToString();
                    T12.Text = dr["IntencionDida"].ToString();
                    T30.Text = dr["PracticasRequeridas"].ToString();
                    T33.Text = dr["VisitasRequeridas"].ToString();
                    T36.Text = dr["PorReprobacion"].ToString();
                    T37.Text = dr["PorDes"].ToString();
                    T39.Text = dr["FichaRevision"].ToString();
                    T15.Text = dr["CompetenciaEsp"].ToString();
                    T16.Text = dr["SesionesPro"].ToString();
                    T17.Text = dr["SesionesReales"].ToString();
                    T18.Text = dr["Subtemas"].ToString();
                    T28.Text = dr["SesionEvalUni"].ToString();
                    T29.Text = dr["SesionRealEva"].ToString();
                    T38.Text = dr["Observaciones"].ToString();
                    T40.Text = dr["ActividadesApren"].ToString();
                    T41.Text = dr["ActividadesEnseñ"].ToString();
                    T42.Text = dr["CompetenciasGen"].ToString();
                    T43.Text = dr["ApoyosDida"].ToString();
                    T48.Text = dr["EquipoRequerido"].ToString();
                    T49.Text = dr["FuentesInfo"].ToString();
                    T55.Text = dr["Conceptual"].ToString();
                    T56.Text = dr["Procedimental"].ToString();
                    T57.Text = dr["Actitudinal"].ToString();
                    T58.Text = dr["IndicadorAlcance"].ToString();
                    T61.Text = dr["Evidencia"].ToString();
                    T64.Text = dr["FechaEntrega"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaPTR(String cbCate, TextBox T2, TextBox T3, String cbMateria, TextBox T5, TextBox T7, TextBox T9, TextBox T6, TextBox T8, TextBox T10, TextBox T13, TextBox T11, TextBox T12, TextBox T30, TextBox T33, TextBox T36, TextBox T37, TextBox T39, int cbUnidad, TextBox T15, TextBox T16, TextBox T17, TextBox T18, TextBox T28, TextBox T29, TextBox T38, TextBox T40, TextBox T41, TextBox T42, TextBox T43, TextBox T48, TextBox T49, TextBox T55, TextBox T56, TextBox T57, TextBox T58, TextBox T61, TextBox T64)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM PlanTrabajo WHERE Catedratico='" + cbCate + "'AND Unidad='" + cbUnidad + "' AND NombreAsignatura='"+cbMateria +"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    T2.Text = dr["Periodo"].ToString();
                    T3.Text = dr["PlanEstudios"].ToString();
                    //T4.Text = dr["NombreAsignatura"].ToString();
                    T5.Text = dr["ClaveAsignatura"].ToString();
                    T7.Text = dr["NumUnidades"].ToString();
                    T9.Text = dr["Grupo"].ToString();
                    T6.Text = dr["HrsTeoricas"].ToString();
                    T8.Text = dr["HrsPracticas"].ToString();
                    T10.Text = dr["Creditos"].ToString();
                    T13.Text = dr["CaracterizacionAsign"].ToString();
                    T11.Text = dr["CompetenciaAsign"].ToString();
                    T12.Text = dr["IntencionDida"].ToString();
                    T30.Text = dr["PracticasRequeridas"].ToString();
                    T33.Text = dr["VisitasRequeridas"].ToString();
                    T36.Text = dr["PorReprobacion"].ToString();
                    T37.Text = dr["PorDes"].ToString();
                    T39.Text = dr["FichaRevision"].ToString();
                    T15.Text = dr["CompetenciaEsp"].ToString();
                    T16.Text = dr["SesionesPro"].ToString();
                    T17.Text = dr["SesionesReales"].ToString();
                    T18.Text = dr["Subtemas"].ToString();
                    T28.Text = dr["SesionEvalUni"].ToString();
                    T29.Text = dr["SesionRealEva"].ToString();
                    T38.Text = dr["Observaciones"].ToString();
                    T40.Text = dr["ActividadesApren"].ToString();
                    T41.Text = dr["ActividadesEnseñ"].ToString();
                    T42.Text = dr["CompetenciasGen"].ToString();
                    T43.Text = dr["ApoyosDida"].ToString();
                    T48.Text = dr["EquipoRequerido"].ToString();
                    T49.Text = dr["FuentesInfo"].ToString();
                    T55.Text = dr["Conceptual"].ToString();
                    T56.Text = dr["Procedimental"].ToString();
                    T57.Text = dr["Actitudinal"].ToString();
                    T58.Text = dr["IndicadorAlcance"].ToString();
                    T61.Text = dr["Evidencia"].ToString();
                    T64.Text = dr["FechaEntrega"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public void llenarTextBoxConsultaCatedratico(String id, TextBox T1)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Usuarios WHERE ID_Usuario=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    T1.Text = dr["Usuario"].ToString();
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

        public void cargarEvidencias(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM SubirArchivo", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex);
            }
        }
        public void cargarAlumnos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select idAlumno[Número Control],Nombres[Nombres], ApellidoP[Apellido Paterno], ApellidoM[Apellido Materno], Unidad1[Unidad 1], Unidad2[Unidad 2], Unidad3[Unidad 3], Unidad4[Unidad 4], Unidad5[Unidad 5] from Alumnos ", cn);
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
                cmd = new SqlCommand("exec EditarAlumno '"+id+"',"+unidad1+","+unidad2+","+unidad3+","+unidad4+","+unidad5,cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarCal1(String id, int unidad1)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + ",null,null,null,null", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarCal2(String id, int unidad1, int unidad2)
        {
            string salida = "Se actualizaron los datos"; 
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + ",null,null,null" , cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarCal3(String id, int unidad1, int unidad2, int unidad3)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + "," + unidad3 + ",null,null" , cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string actualizarCal4(String id,int unidad1, int unidad2, int unidad3, int unidad4)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("exec EditarAlumno '" + id + "'," + unidad1 + "," + unidad2 + "," + unidad3 + "," + unidad4 +",null", cn);
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

        public string actualizarRF(String departamentoA, String reporte, String docente, String numG, String numA, String periodo, String carrera, String asignatura, String totalE, String primeraO, String segundaO, String acreditacion, String noAcredi, String porNoAcredi, String deserto, String porDesercion, String sumaE, String total1, String total2, String total3, String total4, String total5, String total6, String total7, String total8, String total9)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE ReporteFinal set DepartamentoA = '" + departamentoA + "', ReporteFinal = '" + reporte + "', NumGrup = '" + numG + "', NumAsig = '" + numA + "', Carrera = '" + carrera + "', Asignatura = '" + asignatura + "', TotalEstudiantes = '" + totalE + "', PrimeraOportunidad = '" + primeraO + "', SegundaOportunidad = '" + segundaO + "', Acreditacion = '" + acreditacion + "', NoAcreditado = '" + noAcredi + "', PorNoAcreditacion = '" + porNoAcredi + "', Deserto = '" + deserto + "', PorDesercion = '" + porDesercion + "', SumaEstudiantes = '" + sumaE + "', Total1 = '" + total1 + "', Total2 = '" + total2 + "', Total3 = '" + total3 + "', Total4 = '" + total4 + "', Total5 = '" + total5 + "', Total6 = '" + total6 + "', Total7 = '" + total7 + "', Total8 = '" + total8 + "', Total9 = '" + total9 + "' WHERE Docente='" + docente + "' AND Periodo ='" + periodo + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }

        public string actualizarPT(String catedratico, String periodo, String planEs, String nombreA, String claveA, int numU, String grupo, String horasT, String horasP, int creditos, String caracteAsig, String compeAsig, String IntencionD, String practicas, String visitas, String porRepro, String porDes, String fichaRe, int unidad, String competecniaE, String sesionesPro, String sesionesRea, String subtemas, String sesionEval, String sesionRealEva, String observa, String actiApren, String ActEnse, String competenciasGen, String apoyosDida, String equipoRe, String fuentesInf, String conseptual, String procedimental, String actitud, String indicador, String evidencia, String fechaEnt)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("UPDATE PlanTrabajo set Periodo = '" + periodo + "', PlanEstudios = '" + planEs + "', NombreAsignatura = '" + nombreA + "', ClaveAsignatura = '" + claveA + "', NumUnidades = " + numU + ", Grupo = '" + grupo + "', HrsTeoricas = '" + horasT + "', HrsPracticas = '" + horasP + "', Creditos = " + creditos + ", CaracterizacionAsign = '" + caracteAsig + "', CompetenciaAsign = '" + compeAsig + "', IntencionDida = '" + IntencionD + "', PracticasRequeridas = '" + practicas + "', VisitasRequeridas = '" + visitas + "', PorReprobacion = '" + porRepro + "', PorDes = '" + porDes + "', FichaRevision = '" + fichaRe + "', CompetenciaEsp = '" + competecniaE + "', SesionesPro = '" + sesionesPro + "', SesionesReales = '" + sesionesRea + "', Subtemas = '" + subtemas + "', SesionEvalUni = '" + sesionEval + "', SesionRealEva = '" + sesionRealEva + "', Observaciones = '" + observa + "', ActividadesApren = '" + actiApren + "', ActividadesEnseñ = '" + ActEnse + "', CompetenciasGen = '" + competenciasGen + "', ApoyosDida = '" + apoyosDida + "', EquipoRequerido = '" + equipoRe + "', FuentesInfo = '" + fuentesInf + "', Conceptual = '" + conseptual + "', Procedimental = '" + procedimental + "', Actitudinal = '" + actitud + "', IndicadorAlcance = '" + indicador + "', Evidencia = '" + evidencia + "', FechaEntrega = '" + fechaEnt + "' WHERE Catedratico='" + catedratico + "' AND Unidad =" + unidad + "", cn);
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
