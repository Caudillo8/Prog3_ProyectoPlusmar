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
    public partial class FormLogin : Form
    {
        private FormInicio form_inicio;

        public FormLogin()
        {
            InitializeComponent();
            form_inicio = new FormInicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "123")
            {
                MessageBox.Show("Bienvenido  " + txtNombreLogin.Text +
                    "   ha ingresado al sistema");
                form_inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ud. ha ingresado una clave incorrecta");
                return;
            }
        }
    }
}
