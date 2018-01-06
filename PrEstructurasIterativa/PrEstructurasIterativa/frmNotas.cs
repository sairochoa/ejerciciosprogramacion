using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrEstructurasIterativa
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

      
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //declaramos variables
            int numalumnos;
            double nota, sumanota, notabaja, promedio;

            if (txtnumero.Text!="")
            {
                //entrada de datos
                numalumnos = Convert.ToInt32(txtnumero.Text);
                //inicializar variables
                sumanota = 0.0;
                notabaja = 20.0;

                for (int i = 1; i <= numalumnos; i = i + 1)
                {
                    nota = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("ingrese nota del alumno " + i, "promedio notas", "16", 100, 100));
                    sumanota = sumanota + nota;
                    if (nota < notabaja)
                    {
                        notabaja = nota;
                    }
                }
                promedio = sumanota / numalumnos;
                //salida de informacion
                txtpromedio.Text = Convert.ToString(promedio);
                txtnotabaja.Text = Convert.ToString(notabaja);
            }
            else
            {
                MessageBox.Show("ingrese un numero valido", "promedio notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtpromedio.Clear();
            txtnotabaja.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
