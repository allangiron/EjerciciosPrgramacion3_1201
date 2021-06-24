using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPrgramacion3_1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            string[] estudiantes = { "Jose", "Roberto", "Allan", "Norma", "Daniel", "Gustavo" };
            string[] edades = { "12", "20", "22", "24", "33", "54" };

            for (int i = 0; i < estudiantes.Length ; i++)
            {
                CB_agregar.Items.Add(estudiantes[i] + edades[i]);
            }

        }

        private void Btn_ordenarAscendente_Click(object sender, EventArgs e)
        {
            string[] estudiantes = { "Jose", "Roberto", "Allan", "Norma", "Daniel", "Gustavo" };
            string[] edades = { "12", "20", "22", "24", "33", "54" };

            Array.Sort(estudiantes);


            for (int i = 0; i < estudiantes.Length; i++)
            {
                Cb_ordenarAscendente.Items.Add(estudiantes[i] + edades[i]);
            }
        }

        private void Btn_ordenarDescendente_Click(object sender, EventArgs e)
        {
            string[] estudiantes = { "Jose", "Roberto", "Allan", "Norma", "Daniel", "Gustavo" };
            string[] edades = { "12", "20", "22", "24", "33", "54" };

            Array.Sort(estudiantes);
            Array.Reverse(estudiantes);

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Cb_ordenarDescendente.Items.Add(estudiantes[i] + edades[i]);
            }
        }
    }
}
