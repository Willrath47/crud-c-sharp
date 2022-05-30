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
    public partial class administrador : Form

    {
        SqlConnection conexion = new SqlConnection("USER ID= sa; Password= 1234; database=Pru; integrated security = true");


        public administrador()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          Refresh();
        }
        private void Refresh()
        {
            DataSet1TableAdapters.AdminTableAdapter ta 
                = new DataSet1TableAdapters.AdminTableAdapter();

            DataSet1.AdminDataTable dt  = ta.GetData();
            dataGridView2.DataSource = dt;  


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            alumnos f2 = new alumnos();
            f2.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuarios_boton_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           /* conexion.Open();
            string consulta = "select * from Admin where Usuario='" + textBox1; //+ "' and Contrasena='" + textbox_password.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
          lector = comando.ExecuteReader(); */
        } 

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Refresh();

        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
           alumnos alumnos = new alumnos();
           alumnos.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cursos cursos = new cursos();
            cursos.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            catedratico catedratico = new catedratico();
            catedratico.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            notas notas = new notas();
            notas.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           insertAdmin insertAdmin = new insertAdmin(); 
            insertAdmin.Show();
            
            Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            insertAdmin insertAdmin = new insertAdmin();
            insertAdmin.Show();

            Refresh();
        }
    }
}
