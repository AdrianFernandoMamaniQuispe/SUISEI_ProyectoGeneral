using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUISEI
{
    public partial class Rcontra2 : Form
    {
        public Rcontra2()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            txtNcontra.Enabled = true;
            txtNcontra2.Enabled = true;
            btnGuardarContra.Enabled = true;
        }

        private void btnGuardarContra_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtNcontra.Enabled = true;
            txtNcontra2.Enabled = true;
            btnGuardarContra.Enabled = true;
        }

        private void Rcontra2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            Rcontra2_Load(sender, e);
        }
    }
}
