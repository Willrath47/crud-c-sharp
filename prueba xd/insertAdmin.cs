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

    public partial class insertAdmin : Form
    {

        public insertAdmin()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AdminTableAdapter ta
              = new DataSet1TableAdapters.AdminTableAdapter();

            ta.InsertQuery(txtUsuario.Text.Trim(), (int)txtContrasena.Value);

            Refresh();
            this.Close();
        }

        private void insertAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AdminTableAdapter ta
              = new DataSet1TableAdapters.AdminTableAdapter();

            ta.DeleteQuery(txtUsuario.Text.Trim());

            Refresh();
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AdminTableAdapter ta
              = new DataSet1TableAdapters.AdminTableAdapter();

            ta.UpdateQuery(txtUsuario.Text.Trim(), (int)txtContrasena.Value);

            Refresh();
            this.Close();
        }
    }
}


