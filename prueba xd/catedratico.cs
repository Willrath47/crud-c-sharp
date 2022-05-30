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
   
    public partial class catedratico : Form
    {
        public catedratico()
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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notas notas = new notas();
            notas.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alumnos alumnos = new alumnos();
            alumnos.Show();
            this.Close();
        }

        private void Refresh()
        {
            DataSet1TableAdapters.MaestroTableAdapter ta
               = new DataSet1TableAdapters.MaestroTableAdapter();

            DataSet1.MaestroDataTable dt = ta.GetData();

            dataGridView1.DataSource = dt;


        }
        private void catedratico_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            insertmaestros insertmaestros = new insertmaestros();
            insertmaestros.ShowDialog();  
            Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
