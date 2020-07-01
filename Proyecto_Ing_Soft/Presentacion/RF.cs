using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ing_Soft
{
    public partial class RF : Form
    {
        public RF()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void TR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TR3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TR4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TR5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (TR1.Text != "" && TR2.Text != "" && TR3.Text != "" && TR4.Text != "" && TR5.Text != "" && CR6.Text != "" && TR7.Text != "" && TR8.Text != "" && TR9.Text != "" && TR10.Text != "" && TR11.Text != "" && TR12.Text != "" && TR13.Text != "" && TR14.Text != "" && TR15.Text != "" && TR16.Text != "" && TR17.Text != "" && TR18.Text != "" && TR19.Text != "" && TR20.Text != "" && TR21.Text != "" && TR22.Text != "" && TR23.Text != "" && TR24.Text != "" && TR25.Text != "" && TR26.Text != "")
            {
                if (c.RFRegistrado(TR3.Text, CR6.Text)==0)
                {
                    c.insertarRF(TR1.Text, TR2.Text, TR3.Text, TR4.Text, TR5.Text, CR6.Text, TR7.Text, TR8.Text, TR9.Text, TR10.Text, TR11.Text, TR12.Text, TR13.Text, TR14.Text, TR15.Text, TR16.Text, TR17.Text, TR18.Text, TR19.Text, TR20.Text, TR21.Text, TR22.Text, TR23.Text, TR24.Text, TR25.Text, TR26.Text);
                    MessageBox.Show("Reporte Final Guardado", "Registro Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TR1.Clear();
                    TR2.Clear();
                    TR3.Clear();
                    TR4.Clear();
                    TR5.Clear();
                    CR6.Text = "";
                    TR7.Clear();
                    TR8.Clear();
                    TR9.Clear();
                    TR10.Clear();
                    TR11.Clear();
                    TR12.Clear();
                    TR13.Clear();
                    TR14.Clear();
                    TR15.Clear();
                    TR16.Clear();
                    TR17.Clear();
                    TR18.Clear();
                    TR19.Clear();
                    TR20.Clear();
                    TR21.Clear();
                    TR22.Clear();
                    TR23.Clear();
                    TR24.Clear();
                    TR25.Clear();
                    TR26.Clear();
                }
                else
                {
                    MessageBox.Show("El registro ya existe", "Imposible de registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TR1.Clear();
                    TR2.Clear();
                    TR3.Clear();
                    TR4.Clear();
                    TR5.Clear();
                    CR6.Text = "";
                    TR7.Clear();
                    TR8.Clear();
                    TR9.Clear();
                    TR10.Clear();
                    TR11.Clear();
                    TR12.Clear();
                    TR13.Clear();
                    TR14.Clear();
                    TR15.Clear();
                    TR16.Clear();
                    TR17.Clear();
                    TR18.Clear();
                    TR19.Clear();
                    TR20.Clear();
                    TR21.Clear();
                    TR22.Clear();
                    TR23.Clear();
                    TR24.Clear();
                    TR25.Clear();
                    TR26.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.actualizarRF(TR1.Text, TR2.Text, TR3.Text, TR4.Text, TR5.Text, CR6.Text, TR7.Text, TR8.Text, TR9.Text, TR10.Text, TR11.Text, TR12.Text, TR13.Text, TR14.Text, TR15.Text, TR16.Text, TR17.Text, TR18.Text, TR19.Text, TR20.Text, TR21.Text, TR22.Text, TR23.Text, TR24.Text, TR25.Text, TR26.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.RFRegistrado(TR3.Text, CR6.Text) > 0)
            {

                c.llenarTextBoxConsultaRF( TR1, TR2, TR3.Text, TR4, TR5, CR6.Text, TR7, TR8, TR9, TR10, TR11, TR12, TR13, TR14, TR15, TR16, TR17, TR18, TR19, TR20, TR21, TR22, TR23, TR24, TR25, TR26);
            }
            else
            {
                MessageBox.Show("La carrera no existe", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TR2.Text = "";
                
            }
        }
    }
    
}
