using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_xd
{
    public partial class notas : Form
    {
        public notas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            administrador administrador = new administrador();
            administrador.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cursos cursos = new cursos();
            cursos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            catedratico catedratico = new catedratico();
            catedratico.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alumnos alumnos = new alumnos();
            alumnos.Show();
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
