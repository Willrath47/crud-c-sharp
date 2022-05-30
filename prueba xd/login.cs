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
       
    public partial class login : Form
    
    {
        SqlConnection conexion = new SqlConnection("USER ID= sa; Password= 1234; database=Pru; integrated security = true");

        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrimos Conexion a SQL Server
            conexion.Open();
            //Creamos consulta tipo string para extraer nuestros datos de SQL con un SELECT * FROM
            //Concatenamos los textBox donde se ingresaran los datos
            // DESKTOP-I8BPQVS\SQLEXPRESS
            string consulta = "select * from Admin where Usuario='" + textBox4.Text + "' and Contrasena='" + textbox_password.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                administrador administrador = new administrador();
                administrador.Show();
            }
            else
            {
                MessageBox.Show("Error al Ingresar Usuario o Contraseña");

            }
            conexion.Close();
        
         button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

           
       
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textbox_password.Clear();
            textBox4.Clear();
            textBox4.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox_passoword_CheckedChanged(object sender, EventArgs e)
        {



           /* if (checkBox_password.Checked)
            {
                textbox_password.UseSystemPasswordChar = true;
            }
            else
            {
                textbox_password.UseSystemPasswordChar = false;

            }*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if(textbox_password.PasswordChar == '*')
            {
                textbox_password.PasswordChar = '\0';
            }
            else
            {
                textbox_password.PasswordChar = '*';
            }

          
           


        }
    }
}
