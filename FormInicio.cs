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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMicros.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoRsv.Show();
            this.Hide();
        }

        private void btnContinuarInicio_Click(object sender, EventArgs e)
        {
            FormReserva.Show();
            this.Hide();
        }
    }
}
