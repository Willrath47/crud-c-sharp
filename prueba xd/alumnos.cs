using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace prueba_xd
{
    public partial class alumnos : Form
    {

        public alumnos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            administrador f2 = new administrador();
            f2.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            catedratico catedratico = new catedratico();
            catedratico.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notas notas = new notas();
            notas.Show();
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            insertAlumnos insertAlumnos = new insertAlumnos(); 
            insertAlumnos.Show();
            
            Refresh();
        }

        private void alumnos_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {



            DataSet1TableAdapters.AlumnoTableAdapter ta
                = new DataSet1TableAdapters.AlumnoTableAdapter();

            DataSet1.AlumnoDataTable dt = ta.conseguirdatos();
            dataGridView2.DataSource = dt;



        }
    }
}
