using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_1_arrays
{
    public partial class Problema01 : Form
    {
        public Problema01()
        {
            InitializeComponent();

        }

        //inicializamos variables de tipo entero para llevar un contador de los caracteres que deseamos buscar
        int vocales = 0;
        int espacios = 0;

        private void btningresar_Click(object sender, EventArgs e)
        {
            //inicializamos con el evento click del boton ingresar 

            //para facilitar la lectura de datos utilice una funcion tolower para convertir cualquier letra a minuscula y asi sera mas simple comparar
            char[] caracteres = txtingreso.Text.ToLower().ToCharArray();


            //recorremos el array en busca de los caracteres que deseamos buscar
            //utilizamos el comando length para que nos devuelva la cantidad de datos que tiene el array
            for(int i=0; i <caracteres.Length; i++)
            {
                //este if es para buscar las vocales
                if (caracteres[i] == 'a' || caracteres[i] == 'e'||
                    caracteres[i] == 'i' || caracteres[i] == 'o' || caracteres[i] == 'u')
                {
                    vocales++;
                }

                //este if es para buscar los espacios en blanco
                if (caracteres[i]==' ')
                {
                    espacios++;
                }
            }
            //al finalizar mostramos el resultado en este caso utiliza decidi utilizar label en lugar de texbox para evitar que el usuario intente ingresar datos en los mismos
            lbl_vocales.Text = vocales.ToString();
            lbl_espacios.Text = espacios.ToString();
        }
        //estos bonotes son opcionales pero yo decidi agregarlos para limpiar el contenido y cerrar el programa
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtingreso.Clear();
            lbl_espacios.Text = ".";
            lbl_vocales.Text = ".";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
