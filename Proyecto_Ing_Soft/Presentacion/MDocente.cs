using Proyecto_Ing_Soft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDocente
{
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Load(object sender, EventArgs e)
        {
            //combobox2
            SqlConnection cn;
            cn = new SqlConnection("Data Source=LAPTOP-38Q67F7T\\SQLEXPRESS;Initial Catalog=UsuariosBD;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT Id_Materia FROM Materias", cn);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox2.Items.Add(registro["Id_Materia"].ToString());
            }
            registro.Close();
            SqlCommand comando2 = new SqlCommand("Select Semestre From Grupo ", cn);
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                comboBox3.Items.Add(registro2["Semestre"].ToString());
            }
            registro2.Close();
            SqlCommand comando3 = new SqlCommand("Select ID_Usuario From Usuarios Where Tipo_Usuario='Docente'", cn);
            SqlDataReader registro3 = comando3.ExecuteReader();
            while (registro3.Read())
            {
                comboBox1.Items.Add(registro3["ID_Usuario"].ToString());
            }
            cn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void planDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            btnActualizar.Visible = true;
            bGuardar.Visible = true;
            btnBuscar.Visible = true;
            bImprimir.Visible = true;
            PT1.Visible = true;
            PT2.Visible = true;
            PT3.Visible = true;
            PT4.Visible = true;
            PT5.Visible = true;
            PT6.Visible = true;
            L1.Visible = true;
            L2.Visible = true;
            L3.Visible = true;
            L4.Visible = true;
            L5.Visible = true;
            L6.Visible = true;
            L7.Visible = true;
            L8.Visible = true;
            L9.Visible = true;
            L10.Visible = true;
            L11.Visible = true;
            L12.Visible = true;
            L13.Visible = true;
            L14.Visible = true;
            L15.Visible = true;
            L16.Visible = true;
            L17.Visible = true;
            L18.Visible = true;
            L19.Visible = true;
            //L20.Visible = true;
            //L21.Visible = true;
            //L22.Visible = true;
            //L23.Visible = true;
            //L24.Visible = true;
            //L25.Visible = true;
            //L26.Visible = true;
            //L27.Visible = true;
            //L28.Visible = true;
            //L29.Visible = true;
            L30.Visible = true;
            L31.Visible = true;
            L32.Visible = true;
            L33.Visible = true;
            L34.Visible = true;
            L35.Visible = true;
            L36.Visible = true;
            L37.Visible = true;
            L38.Visible = true;
            L39.Visible = true;
            L40.Visible = true;
            L41.Visible = true;
            L42.Visible = true;
            L43.Visible = true;
            L44.Visible = true;
            L45.Visible = true;
            L46.Visible = true;
            L47.Visible = true;
            L48.Visible = true;
            L49.Visible = true;
            L50.Visible = true;
            L51.Visible = true;
            L52.Visible = true;
            L53.Visible = true;
            L54.Visible = true;
            L55.Visible = true;
            L56.Visible = true;
            L57.Visible = true;
            L58.Visible = true;
            L59.Visible = true;
            L60.Visible = true;
            L61.Visible = true;
            L62.Visible = true;
            L63.Visible = true;
            L64.Visible = true;
            L65.Visible = true;
            bImprimir.Visible = true;
            

            T1.Visible = true;
            T2.Visible = true;
            T3.Visible = true;
            //T4.Visible = true;
            T5.Visible = true;
            T6.Visible = true;
            T7.Visible = true;
            T8.Visible = true;
            //T9.Visible = true;
            T10.Visible = true;
            T11.Visible = true;
            T12.Visible = true;
            T13.Visible = true;
            T14.Visible = true;
            T15.Visible = true;
            T16.Visible = true;
            T17.Visible = true;
            T18.Visible = true;
            //T19.Visible = true;
            //T20.Visible = true;
            //T21.Visible = true;
            //T22.Visible = true;
            //T23.Visible = true;
            //T24.Visible = true;
            //T25.Visible = true;
            //T26.Visible = true;
            //T27.Visible = true;
            T28.Visible = true;
            T29.Visible = true;
            T30.Visible = true;
            //T31.Visible = true;
            //T32.Visible = true;
            T33.Visible = true;
            //T34.Visible = true;
            //T35.Visible = true;
            T36.Visible = true;
            T37.Visible = true;
            T38.Visible = true;
            T39.Visible = true;
            T40.Visible = true;
            T41.Visible = true;
            T42.Visible = true;
            T43.Visible = true;
            //T44.Visible = true;
            //T45.Visible = true;
            //T46.Visible = true;
            //T47.Visible = true;
            T48.Visible = true;
            T49.Visible = true;
            //T50.Visible = true;
            //T51.Visible = true;
            //T52.Visible = true;
            //T53.Visible = true;
            //T54.Visible = true;
            T55.Visible = true;
            T56.Visible = true;
            T57.Visible = true;
            T58.Visible = true;
            //T59.Visible = true;
            //T60.Visible = true;
            T61.Visible = true;
            //T62.Visible = true;
            //T63.Visible = true;
            T64.Visible = true;

            
        }

        private void reporteFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           RF  RF = new RF();
            RF.Show();
            comboBox1.Visible = false;
            btnActualizar.Visible = false;
            bGuardar.Visible = false;
            btnBuscar.Visible = false;
            bImprimir.Visible = false;
            PT1.Visible = false;
            PT2.Visible = false;
            PT3.Visible = false;
            PT4.Visible = false;
            PT5.Visible = false;
            PT6.Visible = false;
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            //L20.Visible = false;
            //L21.Visible = false;
            //L22.Visible = false;
            //L23.Visible = false;
            //L24.Visible = false;
            //L25.Visible = false;
            //L26.Visible = false;
            //L27.Visible = false;
            //L28.Visible = false;
            //L29.Visible = false;
            L30.Visible = false;
            L31.Visible = false;
            L32.Visible = false;
            L33.Visible = false;
            L34.Visible = false;
            L35.Visible = false;
            L36.Visible = false;
            L37.Visible = false;
            L38.Visible = false;
            L39.Visible = false;
            L40.Visible = false;
            L41.Visible = false;
            L42.Visible = false;
            L43.Visible = false;
            L44.Visible = false;
            L45.Visible = false;
            L46.Visible = false;
            L47.Visible = false;
            L48.Visible = false;
            L49.Visible = false;
            L50.Visible = false;
            L51.Visible = false;
            L52.Visible = false;
            L53.Visible = false;
            L54.Visible = false;
            L55.Visible = false;
            L56.Visible = false;
            L57.Visible = false;
            L58.Visible = false;
            L59.Visible = false;
            L60.Visible = false;
            L61.Visible = false;
            L62.Visible = false;
            L63.Visible = false;
            L64.Visible = false;
            L65.Visible = false;

            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            //T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            //T9.Visible = false;
            T10.Visible = false;
            T11.Visible = false;
            T12.Visible = false;
            T13.Visible = false;
            T14.Visible = false;
            T15.Visible = false;
            T16.Visible = false;
            T17.Visible = false;
            T18.Visible = false;
            //T19.Visible = false;
            //T20.Visible = false;
            //T21.Visible = false;
            //T22.Visible = false;
            //T23.Visible = false;
            //T24.Visible = false;
            //T25.Visible = false;
            //T26.Visible = false;
            //T27.Visible = false;
            T28.Visible = false;
            T29.Visible = false;
            T30.Visible = false;
            //T31.Visible = false;
            //T32.Visible = false;
            //T33.Visible = false;
            //T34.Visible = false;
            //T35.Visible = false;
            T36.Visible = false;
            T37.Visible = false;
            T38.Visible = false;
            T39.Visible = false;
            T40.Visible = false;
            T41.Visible = false;
            T42.Visible = false;
            T43.Visible = false;
            //T44.Visible = false;
            //T45.Visible = false;
            //T46.Visible = false;
            //T47.Visible = false;
            T48.Visible = false;
            T49.Visible = false;
            //T50.Visible = false;
            //T51.Visible = false;
            //T53.Visible = false;
            //T54.Visible = false;
            T55.Visible = false;
            T56.Visible = false;
            T57.Visible = false;
            T58.Visible = false;
            //T59.Visible = false;
            //T60.Visible = false;
            T61.Visible = false;
            //T62.Visible = false;
            //T63.Visible = false;
            T64.Visible = false;

            
        }

        private void evidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEvidencia SE = new SEvidencia();
            SE.Show();
            btnActualizar.Visible = false;
            bGuardar.Visible = false;
            btnBuscar.Visible = false;
            bImprimir.Visible = false;
            PT1.Visible = false;
            PT2.Visible = false;
            PT3.Visible = false;
            PT4.Visible = false;
            PT5.Visible = false;
            PT6.Visible = false;
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            //L20.Visible = false;
            //L21.Visible = false;
            //L22.Visible = false;
            //L23.Visible = false;
            //L24.Visible = false;
            //L25.Visible = false;
            //L26.Visible = false;
            //L27.Visible = false;
            //L28.Visible = false;
            //L29.Visible = false;
            L30.Visible = false;
            L31.Visible = false;
            L32.Visible = false;
            L33.Visible = false;
            L34.Visible = false;
            L35.Visible = false;
            L36.Visible = false;
            L37.Visible = false;
            L38.Visible = false;
            L39.Visible = false;
            L40.Visible = false;
            L41.Visible = false;
            L42.Visible = false;
            L43.Visible = false;
            L44.Visible = false;
            L45.Visible = false;
            L46.Visible = false;
            L47.Visible = false;
            L48.Visible = false;
            L49.Visible = false;
            L50.Visible = false;
            L51.Visible = false;
            L52.Visible = false;
            L53.Visible = false;
            L54.Visible = false;
            L55.Visible = false;
            L56.Visible = false;
            L57.Visible = false;
            L58.Visible = false;
            L59.Visible = false;
            L60.Visible = false;
            L61.Visible = false;
            L62.Visible = false;
            L63.Visible = false;
            L64.Visible = false;
            L65.Visible = false;

            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            //T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            //T9.Visible = false;
            T10.Visible = false;
            T11.Visible = false;
            T12.Visible = false;
            T13.Visible = false;
            T14.Visible = false;
            T15.Visible = false;
            T16.Visible = false;
            T17.Visible = false;
            T18.Visible = false;
            //T19.Visible = false;
            //T20.Visible = false;
            //T21.Visible = false;
            //T22.Visible = false;
            //T23.Visible = false;
            //T24.Visible = false;
            //T25.Visible = false;
            //T26.Visible = false;
            //T27.Visible = false;
            T28.Visible = false;
            T29.Visible = false;
            T30.Visible = false;
            //T31.Visible = false;
            //T32.Visible = false;
            T33.Visible = false;
            //T34.Visible = false;
            //T35.Visible = false;
            T36.Visible = false;
            T37.Visible = false;
            T38.Visible = false;
            T39.Visible = false;
            T40.Visible = false;
            T41.Visible = false;
            T42.Visible = false;
            T43.Visible = false;
            //T44.Visible = false;
            //T45.Visible = false;
            //T46.Visible = false;
            //T47.Visible = false;
            T48.Visible = false;
            T49.Visible = false;
            //T50.Visible = false;
            //T51.Visible = false;
            //T53.Visible = false;
            //T54.Visible = false;
            T55.Visible = false;
            T56.Visible = false;
            T57.Visible = false;
            T58.Visible = false;
            //T59.Visible = false;
            //T60.Visible = false;
            T61.Visible = false;
            //T62.Visible = false;
            //T63.Visible = false;
            T64.Visible = false;
        }

        private void evidenciaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            SEvidencia SE = new SEvidencia();
            SE.Show();
            comboBox1.Visible = false;
            btnActualizar.Visible = false;
            bGuardar.Visible = false;
            bImprimir.Visible = false;
            PT1.Visible = false;
            PT2.Visible = false;
            PT3.Visible = false;
            PT4.Visible = false;
            PT5.Visible = false;
            PT6.Visible = false;
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            //L20.Visible = false;
            //L21.Visible = false;
            //L22.Visible = false;
            //L23.Visible = false;
            //L24.Visible = false;
            //L25.Visible = false;
            //L26.Visible = false;
            //L27.Visible = false;
            //L28.Visible = false;
            //L29.Visible = false;
            L30.Visible = false;
            L31.Visible = false;
            L32.Visible = false;
            L33.Visible = false;
            L34.Visible = false;
            L35.Visible = false;
            L36.Visible = false;
            L37.Visible = false;
            L38.Visible = false;
            L39.Visible = false;
            L40.Visible = false;
            L41.Visible = false;
            L42.Visible = false;
            L43.Visible = false;
            L44.Visible = false;
            L45.Visible = false;
            L46.Visible = false;
            L47.Visible = false;
            L48.Visible = false;
            L49.Visible = false;
            L50.Visible = false;
            L51.Visible = false;
            L52.Visible = false;
            L53.Visible = false;
            L54.Visible = false;
            L55.Visible = false;
            L56.Visible = false;
            L57.Visible = false;
            L58.Visible = false;
            L59.Visible = false;
            L60.Visible = false;
            L61.Visible = false;
            L62.Visible = false;
            L63.Visible = false;
            L64.Visible = false;
            L65.Visible = false;

            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            //T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            //T9.Visible = false;
            T10.Visible = false;
            T11.Visible = false;
            T12.Visible = false;
            T13.Visible = false;
            T14.Visible = false;
            T15.Visible = false;
            T16.Visible = false;
            T17.Visible = false;
            T18.Visible = false;
            //T19.Visible = false;
            //T20.Visible = false;
            //T21.Visible = false;
            //T22.Visible = false;
            //T23.Visible = false;
            //T24.Visible = false;
            //T25.Visible = false;
            //T26.Visible = false;
            //T27.Visible = false;
            T28.Visible = false;
            T29.Visible = false;
            T30.Visible = false;
            //T31.Visible = false;
            //T32.Visible = false;
            T33.Visible = false;
            //T34.Visible = false;
            //T35.Visible = false;
            T36.Visible = false;
            T37.Visible = false;
            T38.Visible = false;
            T39.Visible = false;
            T40.Visible = false;
            T41.Visible = false;
            T42.Visible = false;
            T43.Visible = false;
            //T44.Visible = false;
            //T45.Visible = false;
            //T46.Visible = false;
            //T47.Visible = false;
            T48.Visible = false;
            T49.Visible = false;
            //T50.Visible = false;
            //T51.Visible = false;
            //T53.Visible = false;
            //T54.Visible = false;
            T55.Visible = false;
            T56.Visible = false;
            T57.Visible = false;
            T58.Visible = false;
            //T59.Visible = false;
            //T60.Visible = false;
            T61.Visible = false;
            //T62.Visible = false;
            //T63.Visible = false;
            T64.Visible = false;
        }

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obs ob = new Obs();
            ob.Show();
            comboBox1.Visible = false;
            btnActualizar.Visible = false;
            bGuardar.Visible = false;
            btnBuscar.Visible = false;
            bImprimir.Visible = false;
            PT1.Visible = false;
            PT2.Visible = false;
            PT3.Visible = false;
            PT4.Visible = false;
            PT5.Visible = false;
            PT6.Visible = false;
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            //L20.Visible = false;
            //L21.Visible = false;
            //L22.Visible = false;
            //L23.Visible = false;
            //L24.Visible = false;
            //L25.Visible = false;
            //L26.Visible = false;
            //L27.Visible = false;
            //L28.Visible = false;
            //L29.Visible = false;
            L30.Visible = false;
            L31.Visible = false;
            L32.Visible = false;
            L33.Visible = false;
            L34.Visible = false;
            L35.Visible = false;
            L36.Visible = false;
            L37.Visible = false;
            L38.Visible = false;
            L39.Visible = false;
            L40.Visible = false;
            L41.Visible = false;
            L42.Visible = false;
            L43.Visible = false;
            L44.Visible = false;
            L45.Visible = false;
            L46.Visible = false;
            L47.Visible = false;
            L48.Visible = false;
            L49.Visible = false;
            L50.Visible = false;
            L51.Visible = false;
            L52.Visible = false;
            L53.Visible = false;
            L54.Visible = false;
            L55.Visible = false;
            L56.Visible = false;
            L57.Visible = false;
            L58.Visible = false;
            L59.Visible = false;
            L60.Visible = false;
            L61.Visible = false;
            L62.Visible = false;
            L63.Visible = false;
            L64.Visible = false;
            L65.Visible = false;

            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            //T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            //T9.Visible = false;
            T10.Visible = false;
            T11.Visible = false;
            T12.Visible = false;
            T13.Visible = false;
            T14.Visible = false;
            T15.Visible = false;
            T16.Visible = false;
            T17.Visible = false;
            T18.Visible = false;
            //T19.Visible = false;
            //T20.Visible = false;
            //T21.Visible = false;
            //T22.Visible = false;
            //T23.Visible = false;
            //T24.Visible = false;
            //T25.Visible = false;
            //T26.Visible = false;
            //T27.Visible = false;
            T28.Visible = false;
            T29.Visible = false;
            T30.Visible = false;
            //T31.Visible = false;
            //T32.Visible = false;
            T33.Visible = false;
            //T34.Visible = false;
            //T35.Visible = false;
            T36.Visible = false;
            T37.Visible = false;
            T38.Visible = false;
            T39.Visible = false;
            T40.Visible = false;
            T41.Visible = false;
            T42.Visible = false;
            T43.Visible = false;
            //T44.Visible = false;
            //T45.Visible = false;
            //T46.Visible = false;
            //T47.Visible = false;
            T48.Visible = false;
            T49.Visible = false;
            //T50.Visible = false;
            //T51.Visible = false;
            //T53.Visible = false;
            //T54.Visible = false;
            T55.Visible = false;
            T56.Visible = false;
            T57.Visible = false;
            T58.Visible = false;
            //T59.Visible = false;
            //T60.Visible = false;
            T61.Visible = false;
            //T62.Visible = false;
            //T63.Visible = false;
            T64.Visible = false;
        }

        private void trabajosEntregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Htrabajo ht = new Htrabajo();
            ht.Show();
            comboBox1.Visible = false;
            btnActualizar.Visible = false;
            bGuardar.Visible = false;
            btnBuscar.Visible = false;
            bImprimir.Visible = false;
            PT1.Visible = false;
            PT2.Visible = false;
            PT3.Visible = false;
            PT4.Visible = false;
            PT5.Visible = false;
            PT6.Visible = false;
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            //L20.Visible = false;
            //L21.Visible = false;
            //L22.Visible = false;
            //L23.Visible = false;
            //L24.Visible = false;
            //L25.Visible = false;
            //L26.Visible = false;
            //L27.Visible = false;
            //L28.Visible = false;
            //L29.Visible = false;
            L30.Visible = false;
            L31.Visible = false;
            L32.Visible = false;
            L33.Visible = false;
            L34.Visible = false;
            L35.Visible = false;
            L36.Visible = false;
            L37.Visible = false;
            L38.Visible = false;
            L39.Visible = false;
            L40.Visible = false;
            L41.Visible = false;
            L42.Visible = false;
            L43.Visible = false;
            L44.Visible = false;
            L45.Visible = false;
            L46.Visible = false;
            L47.Visible = false;
            L48.Visible = false;
            L49.Visible = false;
            L50.Visible = false;
            L51.Visible = false;
            L52.Visible = false;
            L53.Visible = false;
            L54.Visible = false;
            L55.Visible = false;
            L56.Visible = false;
            L57.Visible = false;
            L58.Visible = false;
            L59.Visible = false;
            L60.Visible = false;
            L61.Visible = false;
            L62.Visible = false;
            L63.Visible = false;
            L64.Visible = false;
            L65.Visible = false;

            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            //T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            //T9.Visible = false;
            T10.Visible = false;
            T11.Visible = false;
            T12.Visible = false;
            T13.Visible = false;
            T14.Visible = false;
            T15.Visible = false;
            T16.Visible = false;
            T17.Visible = false;
            T18.Visible = false;
            //T19.Visible = false;
            //T20.Visible = false;
            //T21.Visible = false;
            //T22.Visible = false;
            //T23.Visible = false;
            //T24.Visible = false;
            //T25.Visible = false;
            //T26.Visible = false;
            //T27.Visible = false;
            T28.Visible = false;
            T29.Visible = false;
            T30.Visible = false;
            //T31.Visible = false;
            //T32.Visible = false;
            T33.Visible = false;
            //T34.Visible = false;
            //T35.Visible = false;
            T36.Visible = false;
            T37.Visible = false;
            T38.Visible = false;
            T39.Visible = false;
            T40.Visible = false;
            T41.Visible = false;
            T42.Visible = false;
            T43.Visible = false;
            //T44.Visible = false;
            //T45.Visible = false;
            //T46.Visible = false;
            //T47.Visible = false;
            T48.Visible = false;
            T49.Visible = false;
            //T50.Visible = false;
            //T51.Visible = false;
            //T53.Visible = false;
            //T54.Visible = false;
            T55.Visible = false;
            T56.Visible = false;
            T57.Visible = false;
            T58.Visible = false;
            //T59.Visible = false;
            //T60.Visible = false;
            T61.Visible = false;
            //T62.Visible = false;
            //T63.Visible = false;
            T64.Visible = false;
        }

        private void ID_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioSesion f1 = new InicioSesion();
            f1.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calif cal = new Calif();
            cal.Show();
            comboBox1.Visible = false;
            btnActualizar.Visible = false;
            bGuardar.Visible = false;
            bImprimir.Visible = false;
            PT1.Visible = false;
            PT2.Visible = false;
            PT3.Visible = false;
            PT4.Visible = false;
            PT5.Visible = false;
            PT6.Visible = false;
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            //L20.Visible = false;
            //L21.Visible = false;
            //L22.Visible = false;
            //L23.Visible = false;
            //L24.Visible = false;
            //L25.Visible = false;
            //L26.Visible = false;
            //L27.Visible = false;
            //L28.Visible = false;
            //L29.Visible = false;
            L30.Visible = false;
            L31.Visible = false;
            L32.Visible = false;
            L33.Visible = false;
            L34.Visible = false;
            L35.Visible = false;
            L36.Visible = false;
            L37.Visible = false;
            L38.Visible = false;
            L39.Visible = false;
            L40.Visible = false;
            L41.Visible = false;
            L42.Visible = false;
            L43.Visible = false;
            L44.Visible = false;
            L45.Visible = false;
            L46.Visible = false;
            L47.Visible = false;
            L48.Visible = false;
            L49.Visible = false;
            L50.Visible = false;
            L51.Visible = false;
            L52.Visible = false;
            L53.Visible = false;
            L54.Visible = false;
            L55.Visible = false;
            L56.Visible = false;
            L57.Visible = false;
            L58.Visible = false;
            L59.Visible = false;
            L60.Visible = false;
            L61.Visible = false;
            L62.Visible = false;
            L63.Visible = false;
            L64.Visible = false;
            L65.Visible = false;

            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            //T4.Visible = false;
            T5.Visible = false;
            T6.Visible = false;
            T7.Visible = false;
            T8.Visible = false;
            //T9.Visible = false;
            T10.Visible = false;
            T11.Visible = false;
            T12.Visible = false;
            T13.Visible = false;
            T14.Visible = false;
            T15.Visible = false;
            T16.Visible = false;
            T17.Visible = false;
            T18.Visible = false;
            //T19.Visible = false;
            //T20.Visible = false;
            //T21.Visible = false;
            //T22.Visible = false;
            //T23.Visible = false;
            //T24.Visible = false;
            //T25.Visible = false;
            //T26.Visible = false;
            //T27.Visible = false;
            T28.Visible = false;
            T29.Visible = false;
            T30.Visible = false;
            //T31.Visible = false;
            //T32.Visible = false;
            T33.Visible = false;
            //T34.Visible = false;
            //T35.Visible = false;
            T36.Visible = false;
            T37.Visible = false;
            T38.Visible = false;
            T39.Visible = false;
            T40.Visible = false;
            T41.Visible = false;
            T42.Visible = false;
            T43.Visible = false;
            //T44.Visible = false;
            //T45.Visible = false;
            //T46.Visible = false;
            //T47.Visible = false;
            T48.Visible = false;
            T49.Visible = false;
            //T50.Visible = false;
            //T51.Visible = false;
            //T53.Visible = false;
            //T54.Visible = false;
            T55.Visible = false;
            T56.Visible = false;
            T57.Visible = false;
            T58.Visible = false;
            //T59.Visible = false;
            //T60.Visible = false;
            T61.Visible = false;
            //T62.Visible = false;
            //T63.Visible = false;
            T64.Visible = false;
        }

        private void TR4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TR5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TR1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TR2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TR3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TR1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();
        }
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextBoxConsultaMateriaPT(comboBox2.SelectedItem.ToString(), T5, T10);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (T1.Text != "" && (T2.Text != "" && T2.Text != "Selecionar Ciclo") && T3.Text != "" && T5.Text != "" && comboBox2.SelectedItem.ToString() != "" && T7.Text != "" && T6.Text != "" && T8.Text != "" && T10.Text != "" && comboBox3.SelectedItem.ToString() != "" && T11.Text != "" && T12.Text != "" && T13.Text != "" && T14.Text != "" && T15.Text != "" && T16.Text != "" && T17.Text != "" && T18.Text != "" && T28.Text != "" && T29.Text != "" && T30.Text != "" && T33.Text != "" && T36.Text != "" && T37.Text != "" && T38.Text != "" && T39.Text != "" && T40.Text != "" && T41.Text != "" && T42.Text != "" && T43.Text != "" && T48.Text != "" && T49.Text != "" && T55.Text != "" && T56.Text != "" && T57.Text != "" && T58.Text != "" && T61.Text != "" && T64.Text != "")
            {
                if (c.PTRegistrado(T1.Text, Convert.ToInt32(T14.Text), T5.Text) == 0)
                {
                    c.insertarPT(T1.Text, T2.Text, T3.Text, T5.Text, comboBox2.SelectedItem.ToString(), Convert.ToInt32(T7.Text), comboBox3.SelectedItem.ToString(), T6.Text, T8.Text, Convert.ToInt32(T10.Text), T13.Text, T12.Text, T11.Text, T30.Text, T33.Text, T36.Text, T37.Text, T39.Text, Convert.ToInt32(T14.Text), T15.Text, T16.Text, T17.Text, T18.Text, T28.Text, T29.Text, T38.Text, T40.Text, T41.Text, T42.Text, T43.Text, T48.Text, T49.Text, T55.Text, T56.Text, T57.Text, T58.Text, T61.Text, T64.Text);
                    MessageBox.Show("Plan de Trabajo Guardado", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    T1.Clear();
                    this.T2.Text="";
                    T3.Clear();
                    T5.Clear();
                    this.comboBox2.Text = "";
                    //T7.Clear();
                    T6.Clear();
                    T8.Clear();
                    T10.Clear();
                    this.comboBox3.Text = "";
                    T11.Clear();
                    T12.Clear();
                    T13.Clear();
                    T14.Clear();
                    T15.Clear();
                    T16.Clear();
                    T17.Clear();
                    T18.Clear();
                    T28.Clear();
                    T29.Clear();
                    T30.Clear();
                    T33.Clear();
                    T36.Clear();
                    T37.Clear();
                    T38.Clear();
                    T39.Clear();
                    T40.Clear();
                    T41.Clear();
                    T42.Clear();
                    T43.Clear();
                    T48.Clear();
                    T49.Clear();
                    T55.Clear();
                    T56.Clear();
                    T57.Clear();
                    T58.Clear();
                    T61.Clear();
                    T64.Clear();
                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    T1.Clear();
                    this.T2.Text = "";
                    T3.Clear();
                    T5.Clear();
                    this.comboBox2.Text = "";
                    //T7.Clear();
                    T6.Clear();
                    T8.Clear();
                    T10.Clear();
                    this.comboBox3.Text = "";
                    T11.Clear();
                    T12.Clear();
                    T13.Clear();
                    T14.Clear();
                    T15.Clear();
                    T16.Clear();
                    T17.Clear();
                    T18.Clear();
                    T28.Clear();
                    T29.Clear();
                    T30.Clear();
                    T33.Clear();
                    T36.Clear();
                    T37.Clear();
                    T38.Clear();
                    T39.Clear();
                    T40.Clear();
                    T41.Clear();
                    T42.Clear();
                    T43.Clear();
                    T48.Clear();
                    T49.Clear();
                    T55.Clear();
                    T56.Clear();
                    T57.Clear();
                    T58.Clear();
                    T61.Clear();
                    T64.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (T1.Text != "" && (T2.Text != "" && T2.Text != "Selecionar Ciclo") && T3.Text != "" && T5.Text != "" && comboBox2.SelectedItem.ToString() != "" && T7.Text != "" && T6.Text != "" && T8.Text != "" && T10.Text != "" && comboBox3.SelectedItem.ToString() != "" && T11.Text != "" && T12.Text != "" && T13.Text != "" && T14.Text != "" && T15.Text != "" && T16.Text != "" && T17.Text != "" && T18.Text != "" && T28.Text != "" && T29.Text != "" && T30.Text != "" && T33.Text != "" && T36.Text != "" && T37.Text != "" && T38.Text != "" && T39.Text != "" && T40.Text != "" && T41.Text != "" && T42.Text != "" && T43.Text != "" && T48.Text != "" && T49.Text != "" && T55.Text != "" && T56.Text != "" && T57.Text != "" && T58.Text != "" && T61.Text != "" && T64.Text != "")
            {
                c.actualizarPT(T1.Text, T2.Text, T3.Text, T5.Text, comboBox2.SelectedItem.ToString(), Convert.ToInt32(T7.Text), comboBox3.SelectedItem.ToString(), T6.Text, T8.Text, Convert.ToInt32(T10.Text), T13.Text, T12.Text, T11.Text, T30.Text, T33.Text, T36.Text, T37.Text, T39.Text, Convert.ToInt32(T14.Text), T15.Text, T16.Text, T17.Text, T18.Text, T28.Text, T29.Text, T38.Text, T40.Text, T41.Text, T42.Text, T43.Text, T48.Text, T49.Text, T55.Text, T56.Text, T57.Text, T58.Text, T61.Text, T64.Text);
                MessageBox.Show("Plan de Trabajo Actualizado", "Actualizacion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                T1.Clear();
                this.T2.Text = "";
                T3.Clear();
                T5.Clear();
                this.comboBox2.Text = "";
                //T7.Clear();
                T6.Clear();
                T8.Clear();
                T10.Clear();
                this.comboBox3.Text = "";
                T11.Clear();
                T12.Clear();
                T13.Clear();
                T14.Clear();
                T15.Clear();
                T16.Clear();
                T17.Clear();
                T18.Clear();
                T28.Clear();
                T29.Clear();
                T30.Clear();
                T33.Clear();
                T36.Clear();
                T37.Clear();
                T38.Clear();
                T39.Clear();
                T40.Clear();
                T41.Clear();
                T42.Clear();
                T43.Clear();
                T48.Clear();
                T49.Clear();
                T55.Clear();
                T56.Clear();
                T57.Clear();
                T58.Clear();
                T61.Clear();
                T64.Clear();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.PTRegistrado(T1.Text, Convert.ToInt32(T14.Text), T5.Text) > 0)
            {

                c.llenarTextBoxConsultaPT(T1.Text, T2, T3, T5, comboBox2, T7, comboBox3, T6, T8, T10, T13, T11, T12, T30, T33, T36, T37, T39, Convert.ToInt32(T14.Text), T15, T16, T17, T18, T28, T29, T38, T40, T41, T42, T43, T48, T49, T55, T56, T57, T58, T61, T64);
            }
            else
            {
                MessageBox.Show("La carrera no existe", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                T1.Text = "";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.llenarTextBoxConsultaCatedratico(comboBox1.SelectedItem.ToString(), T1);
        }
    }
}
