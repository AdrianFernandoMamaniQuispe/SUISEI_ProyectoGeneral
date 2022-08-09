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
    public partial class Recuperar_ContraU : Form
    {
        public Recuperar_ContraU()
        {
            InitializeComponent();
        }

        private void txt_palabrecu_Enter(object sender, EventArgs e)
        {
            if (txt_palabrecu.Text == "Contraseña")
            {
                txt_palabrecu.Text = "";
                txt_palabrecu.ForeColor = Color.Black;
            }
        }

        private void txt_palabrecu_Leave(object sender, EventArgs e)
        {
            if (txt_palabrecu.Text == "")
            {
                txt_palabrecu.Text = "Contraseña";
                txt_palabrecu.ForeColor = Color.DimGray;
            }
        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
