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
    public partial class insertCurso : Form
    {
        public insertCurso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.CursoTableAdapter ta
             = new DataSet1TableAdapters.CursoTableAdapter();


            ta.InsertQuery((int)txtCodCurso.Value,txtNombre.Text.Trim());
        }

        private void txtCodCurso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
