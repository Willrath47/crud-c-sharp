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
    public partial class insertmaestros : Form
    {
        public insertmaestros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataSet1TableAdapters.MaestroTableAdapter ta
              = new DataSet1TableAdapters.MaestroTableAdapter();


            ta.add(txtNombre.Text.Trim(),txtApellido.Text.Trim()
                ,txtNombreCurso.Text.Trim(),(int)txtCodCurso.Value);
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
