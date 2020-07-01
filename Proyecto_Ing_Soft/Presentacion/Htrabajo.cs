using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Ing_Soft;

namespace InterfazDocente
{
    public partial class Htrabajo : Form
    {
        public Htrabajo()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Htrabajo_Load(object sender, EventArgs e)
        {
            c.cargarEvidencias(dataGridView1);
        }
    }
}
