using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SUISEI.CONTROLADOR;
using SUISEI.MODELO;


namespace SUISEI.VISTA
{
    public partial class Registro_Cliente : Form
    {
        public Registro_Cliente()
        {
            InitializeComponent();
        }

        clsCliente cli = new clsCliente();

        private Boolean validarCodigo()
        {
            using (SUISEIEntities bd = new SUISEIEntities())
            {
                foreach (Cliente cliente in bd.Cliente.ToList())
                {
                    if (txtId.Text.Length > 0)
                        if (Convert.ToInt32(txtId.Text) == cliente.id_cliente)
                        {
                            return false;

                        }
                }
                return true;
            }
        }


        private bool FormularioValido()
        {

            bool valido = false;
            //string sexo = " ";

            string nombres = txtNom.Text.Trim();
            string apellidoPaterno = txtAp.Text.Trim();
            string apellidoMaterno = txtAm.Text.Trim();
            //int edad = Convert.ToInt32(txtEdad.Text.Trim());

            string direccion = txtDireccion.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string dni = txtDni.Text.Trim();


            if (dni.Length > 0 && apellidoPaterno.Length > 0 && apellidoMaterno.Length > 0 && nombres.Length > 0 &&
               txtEdad.Text.Trim().Length > 0 && telefono.Length > 0 && direccion.Length > 0 && (rbtFemenino.Checked || rbtMasculino.Checked))

                valido = true;




            else
            {
                MessageBox.Show("Todos los datos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
            }

            return valido;
        }


        public void guardar()
        {
            if (FormularioValido())
            {
                if (validarCodigo())
                {
                    string sexo = "";
                    int id = 0;
                    string dni = txtDni.Text.Trim();
                    string apellidoPaterno = txtAp.Text.Trim();
                    string apellidoMaterno = txtAm.Text.Trim();
                    string nombres = txtNom.Text.Trim();
                    if (rbtFemenino.Checked)
                    {
                        sexo = "F";
                    }
                    if (rbtMasculino.Checked)
                    {

                        sexo = "M";
                    }
                    int edad = Convert.ToInt32(txtEdad.Text.Trim());
                    string telefono = txtTelefono.Text.Trim();
                    string direccion = txtDireccion.Text.Trim();

                    if (edad >= 18)
                    {
                        id = cli.InsertarCliente(nombres, apellidoPaterno, apellidoMaterno, edad, sexo, direccion, telefono, dni);
                        txtId.Text = id.ToString();
                        MessageBox.Show("Datos guardados satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCliente.DataSource = cli.obtenerClientes("");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El cliente debe ser mayor de edad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDni.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El código no se puede repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        void limpiar()
        {
            foreach (Control caja in this.grpDatos.Controls)
            {
                if (caja is TextBox)
                {
                    caja.Text = "";
                }
            }
            txtId.Text = "";
            txtDni.Focus();
            rbtMasculino.Checked = false;
            rbtFemenino.Checked = false;
        }

        private Boolean validarEliminacion()
        {
            using (SUISEIEntities bd = new SUISEIEntities())
            {
                foreach (Venta venta in bd.Venta.ToList())
                {
                    if (txtId.Text == venta.v_id_cliente.ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarEliminacion())
            {
                if (txtId.Text.Trim().Length > 0)
                {
                    DialogResult respuestaAdvertencia = DialogResult.OK;
                    respuestaAdvertencia = MessageBox.Show("¿Está se guro de eliminar al cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuestaAdvertencia == DialogResult.Yes)
                    {
                        cli.EliminarCliente(Convert.ToInt32(txtId.Text));
                        dgvCliente.DataSource = cli.obtenerClientes("");

                        limpiar();
                        MessageBox.Show("Registro eliminado satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el registro que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCliente.CurrentRow.Selected = true;

                txtId.Text = dgvCliente.Rows[e.RowIndex].Cells["id_cliente"].FormattedValue.ToString();
                txtNom.Text = dgvCliente.Rows[e.RowIndex].Cells["c_nombres"].FormattedValue.ToString();
                txtAp.Text = dgvCliente.Rows[e.RowIndex].Cells["c_paterno"].FormattedValue.ToString();
                txtAm.Text = dgvCliente.Rows[e.RowIndex].Cells["c_materno"].FormattedValue.ToString();
                txtEdad.Text = dgvCliente.Rows[e.RowIndex].Cells["c_edad"].FormattedValue.ToString();
                if (dgvCliente.Rows[e.RowIndex].Cells["c_sexo"].FormattedValue.ToString() == "F")
                    rbtFemenino.Checked = true;
                if (dgvCliente.Rows[e.RowIndex].Cells["c_sexo"].FormattedValue.ToString() == "M")
                    rbtMasculino.Checked = true;
                txtDireccion.Text = dgvCliente.Rows[e.RowIndex].Cells["c_direccion"].FormattedValue.ToString();
                txtTelefono.Text = dgvCliente.Rows[e.RowIndex].Cells["c_telefono"].FormattedValue.ToString();
                txtDni.Text = dgvCliente.Rows[e.RowIndex].Cells["c_dni"].FormattedValue.ToString();


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {

                if (FormularioValido())
                {
                    string sexo = "";
                    int id = 0;
                    string dni = txtDni.Text.Trim();
                    string apellidoPaterno = txtAp.Text.Trim();
                    string apellidoMaterno = txtAm.Text.Trim();
                    string nombres = txtNom.Text.Trim();
                    if (rbtFemenino.Checked)
                    {
                        sexo = "F";
                    }
                    if (rbtMasculino.Checked)
                    {

                        sexo = "M";
                    }
                    int edad = Convert.ToInt32(txtEdad.Text.Trim());
                    string telefono = txtTelefono.Text.Trim();
                    string direccion = txtDireccion.Text.Trim();

                    if (txtId.Text.Length > 0)
                    {
                        id = Convert.ToInt32(txtId.Text);
                        cli.modificarCliente(id, nombres, apellidoPaterno, apellidoMaterno, edad, sexo, direccion, telefono, dni);
                        dgvCliente.DataSource = cli.obtenerClientes("");
                        MessageBox.Show("Datos modificados", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro que desea modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtAp.Focus();
            }
            Validaciones.validarNumeros(e);
        }

        private void txtAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtAm.Focus();
            }
            Validaciones.validarLetras(e);
        }

        private void txtAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNom.Focus();
            }
            Validaciones.validarLetras(e);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
            Validaciones.validarLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEdad.Focus();
            }
            Validaciones.validarNumeros(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnRegistrar.Focus();
            }
            Validaciones.validarNumeros(e);
        }

        private void Registro_Cliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = cli.obtenerClientes("");
            dgvCliente.Columns[0].HeaderText = "Id";
            dgvCliente.Columns[1].HeaderText = "Paterno";
            dgvCliente.Columns[2].HeaderText = "Materno";
            dgvCliente.Columns[3].HeaderText = "Nombres";
            dgvCliente.Columns[4].HeaderText = "Edad";
            dgvCliente.Columns[5].HeaderText = "Sexo";
            dgvCliente.Columns[6].HeaderText = "Direccion";
            dgvCliente.Columns[7].HeaderText = "Telefono";
            dgvCliente.Columns[8].HeaderText = "DNI";
            dgvCliente.Columns[0].Width = 40;
            dgvCliente.Columns[1].Width = 65;
            dgvCliente.Columns[2].Width = 65;
            dgvCliente.Columns[3].Width = 65;
            dgvCliente.Columns[4].Width = 40;
            dgvCliente.Columns[5].Width = 40;
            dgvCliente.Columns[6].Width = 200;
            dgvCliente.Columns[7].Width = 80;
            dgvCliente.Columns[8].Width = 70;
        }
    }

}




