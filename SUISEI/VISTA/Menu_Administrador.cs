using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUISEI.VISTA
{
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            CambiarContra_U u = new CambiarContra_U();
            u.Show();
        }

        private void btn_registrarcliente_Click(object sender, EventArgs e)
        {
            Control_U control_U = new Control_U();
            control_U.Show();
        }
    }
}
