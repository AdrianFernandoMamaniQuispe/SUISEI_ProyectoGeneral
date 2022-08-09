using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SUISEI.CONTROLADOR;

namespace SUISEI.VISTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void txt_codU_Enter(object sender, EventArgs e)
        {
            if(txt_codU.Text == "Código de Usuario")
            {
                txt_codU.Text = "";
                txt_codU.ForeColor = Color.Black;
            }
            
        }

        private void txt_codU_Leave(object sender, EventArgs e)
        {
            if(txt_codU.Text == "")
            {
                txt_codU.Text = "Código de Usuario";
                txt_codU.ForeColor = Color.DimGray;
            }
        }

        private void txt_contra_Leave(object sender, EventArgs e)
        {
            if (txt_contra.Text == "")
            {
                txt_contra.Text = "Contraseña";
                txt_contra.ForeColor = Color.DimGray;
            }

        }

        private void txt_contra_Enter(object sender, EventArgs e)
        {
            if (txt_contra.Text == "Contraseña")
            {
                txt_contra.Text = "";
                txt_contra.ForeColor = Color.Black;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_ContraU r = new Recuperar_ContraU();
            r.ShowDialog();
        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            String nomUsuario = txt_codU.Text;
            String clave = txt_contra.Text;

            List<string> roles = ClsLogin.retornarCredenciales(nomUsuario, clave);

            switch (roles[0])
            {
                case "Administrador":
                    Menu_Administrador m = new Menu_Administrador();
                    m.Show();
                    this.Visible = false;
                    break;
                case "Recepcionista":
                    Menu_Recepcion r = new Menu_Recepcion();
                    r.Show();
                    this.Visible = false;
                    break;
                case "Supervisor":
                    Menu_Supervisor s = new Menu_Supervisor();
                    s.Show();
                    this.Visible = false;
                    break;
                case "Vendedor":
                    Menu_Supervisor v = new Menu_Supervisor();
                    v.Show();
                    this.Visible = false;
                    break;
                default: MessageBox.Show("Id o Clave incorrectos");
                    break;
            }
            /*
            if (txt_codU.Text == "Administrador")
            {
                Menu_Administrador m = new Menu_Administrador();
                m.Show();
                this.Visible = false;
            }
            else if(txt_codU.Text == "Recepcionista")
            {
                Menu_Recepcion m = new Menu_Recepcion();
                m.Show();
                this.Visible = false;

            }
            if (txt_codU.Text == "Supervisor")
            {
                Menu_Supervisor m = new Menu_Supervisor();
                m.Show();
                this.Visible = false;

            }
            if (txt_codU.Text == "Vendedor")
            {
                Menu_Vendedor m = new Menu_Vendedor();
                m.Show();
                this.Visible = false;
            }
            */
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
