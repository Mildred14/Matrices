using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matrices m;
        private void btn_Crear_Click(object sender, EventArgs e)
        {
            int tamaño = Convert.ToInt32(txtTamaño.Text);
            m = new Matrices(tamaño);
        }

        private void btn_Llenar_Click(object sender, EventArgs e)
        {
            m.llenarMatriz();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            txt_Matriz.Clear();
            txt_Matriz.Text = m.ToString();
        }

        private void btnColumnas_Click(object sender, EventArgs e)
        {
            m.llenarColumnas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.renglonInverso();
        }

        private void bntDiagonapPp_Click(object sender, EventArgs e)
        {

            txt_Matriz.Text = m.diagonalPp();
        }

        private void btnDiagonalSec_Click(object sender, EventArgs e)
        {
            txt_Matriz.Text = m.diagonalSs();
        }

        private void arribaPersonal_Click(object sender, EventArgs e)
        {
            txt_Matriz.Text = m.arribaPpd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             m.abajoPp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.invertirDiagonalPP();
        }
    }
}
