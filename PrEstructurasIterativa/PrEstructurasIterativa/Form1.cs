using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//este programa es desarrollado por Mr. Crow Labs®
//TODOS LOS DERECHOS RESERVADOS.

namespace PrEstructurasIterativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double numero;
            double suma, resta, mult, div;
            //entrada de datos
            numero = Convert.ToDouble(txtnumero.Text);
            //proceso
            //dejamos en blanco los combobox
            cbosuma.Items.Clear();
            cbores.Items.Clear();
            cbomul.Items.Clear();
            cbodiv.Items.Clear();

            //creamos nuestro bucle para mostrar la tabla del uno al 12
            for (int i=1;i<=12;i++)
            {
                suma = numero + i;
                resta = numero - i;
                mult = numero * i;
                div = numero / i;
                //agregar los resultados al combobox
                cbosuma.Items.Add(numero + "+" + i + "="+ suma);
                cbores.Items.Add(numero + "-" + i + "=" + resta);
                cbomul.Items.Add(numero + "*" + i + "=" + mult);
                cbodiv.Items.Add(numero + "/" + i + "=" + div);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            cbosuma.Items.Clear();
            cbores.Items.Clear();
            cbomul.Items.Clear();
            cbodiv.Items.Clear();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotas frmNotas = new frmNotas();
            frmNotas.Show();
        }
    }
}
//DERECHOS DE USO 
//Queda prohibido copiar, reproducir, distribuir, publicar, transmitir, difundir, 
//o en cualquier modo explotar cualquier parte de este programa sin la autorización 
//previa por escrito de Mr. Crow Labs® o de los titulares correspondientes.
//Sin embargo, usted podrá bajar material a su computadora personal para uso 
//exclusivamente personal o educacional y no comercial limitado a una copia del archivo.
//Usted no podrá remover o alterar de la copia ninguna leyenda de Derechos de Autor 
//o la que manifieste la autoría del material.