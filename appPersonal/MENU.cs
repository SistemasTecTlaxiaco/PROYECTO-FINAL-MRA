using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPersonal
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            LOGIN_principal formulario = new LOGIN_principal();
            formulario.Show();
        }
    }
}
