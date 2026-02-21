using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_3_arrays
{
    public partial class Form1 : Form
    {
        // declaramos las variables que utilizaremos en este caso harrays y una variable para ver que valor de moneda selecciona el usuario
        int[] monedas = new int[5];
        //arreglo con los valores permitidos
        int[] valores = { 50, 100, 200, 500, 1000 };
        //variable utilizada para saber la denominacion que el usuario selecciono
        int indiceSeleccionado = -1;

        

        public Form1()
        {
            InitializeComponent();
            ActualizarEstado(); //actualizamos la variables
        }

        //botoces que seleccionan la denominacion que eligio el usuario
        private void btn50_Click(object sender, EventArgs e)
        {
            indiceSeleccionado = 0;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            indiceSeleccionado = 1;
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            indiceSeleccionado = 2;
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            indiceSeleccionado = 3;
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            indiceSeleccionado = 4;
        }

        //boton que agrega la opcion elegida por el usuario
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado >= 0)
            {
                monedas[indiceSeleccionado]++;
                ActualizarEstado();
                indiceSeleccionado = -1;
            }
            else
            {
                MessageBox.Show("Seleccione una denominación");
            }
        }

        //el siguiente metodo que realizamos es para actualizar el estado de cuenta y mostrar lo que se nos pidio
        private void ActualizarEstado()
        {
            // Mostrar cantidad de monedas
            lbl50.Text = monedas[0].ToString();
            lbl100.Text = monedas[1].ToString();
            lbl200.Text = monedas[2].ToString();
            lbl500.Text = monedas[3].ToString();
            lbl1000.Text = monedas[4].ToString();

            lb50.Text = monedas[0].ToString();
            lb100.Text = monedas[1].ToString();
            lb200.Text = monedas[2].ToString();
            lb500.Text = monedas[3].ToString();
            lb1000.Text = monedas[4].ToString();

            // Calcular saldo
            int total = 0;

            for (int i = 0; i < monedas.Length; i++)
            {
                total += monedas[i] * valores[i];
            }

            lbsaldo.Text = total.ToString();
        }

        //boton utilizado para realizar la accion romper la alcancia 
        private void btnretirar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                 "¿Desea romper la alcancía?",
                 "Confirmación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                for (int i = 0; i < monedas.Length; i++)
                {
                    monedas[i] = 0;
                }

                ActualizarEstado();
                MessageBox.Show("Alcancía vaciada");
            }
        }


        //boton utilizado para cerrar la interfaz
        private void btnsalir_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
