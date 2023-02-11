using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioFinalEstudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Nota3, Nota4, Promedio;
            string Observacion;

            Nota1 = double.Parse(txtNota1.Text);
            Nota2 = double.Parse(txtNota2.Text);
            Nota3 = double.Parse(txtNota3.Text);
            Nota4 = double.Parse(txtNota4.Text);
            Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Promedio<=64)
            {
                Observacion = "Reprobado";
                txtPromedio.Text = Promedio.ToString("N2");
                txtObservacion.Text = Observacion;
            }else if (Promedio >= 65 && Promedio <= 100)
            {
                Observacion = "Aprobado";
                txtPromedio.Text = Promedio.ToString("N2");
                txtObservacion.Text = Observacion;

            }
        }
    }
}
