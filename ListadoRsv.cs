using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Plusmar
{
    public partial class ListadoRsv : Form
    {
        public ListadoRsv()
        {
            InitializeComponent();
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sistema.Imprimir( ); //?
           
        }

        private void btnSalirRsv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
