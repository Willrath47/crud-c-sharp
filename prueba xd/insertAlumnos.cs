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
    public partial class insertAlumnos : Form
    {
        public insertAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AlumnoTableAdapter ta
              = new DataSet1TableAdapters.AlumnoTableAdapter();

            ta.InsertQuery(txtNombre.Text.Trim(), txtApellido.Text.Trim()
                ,(int)txtCodCurso.Value, txtCurso.Text.Trim());

            Refresh();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AlumnoTableAdapter ta
              = new DataSet1TableAdapters.AlumnoTableAdapter();

            ta.DeleteQuery(txtNombre.Text.Trim());

            Refresh();
            this.Close();
        }
    }
}
