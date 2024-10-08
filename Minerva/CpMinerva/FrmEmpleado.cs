using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmEmpleado : Form
    {
        private bool esNuevo = false;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = EmpleadoCln.listarPa(txtParametro.Text);
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idUsuario"].Visible = false;
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "CI";
            dgvLista.Columns["nombres"].HeaderText = "Nombres";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["celular"].HeaderText = "Celular";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["usuario"].HeaderText = "Usuario";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;
            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["cedulaIdentidad"];
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            txtNombres.KeyPress += Util.onlyLetters;
            txtPrimerApellido.KeyPress += Util.onlyLetters;
            txtSegundoApellido.KeyPress += Util.onlyLetters;
            txtCelular.KeyPress += Util.onlyNumbers;
            Size = new Size(860, 349);
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(860, 481);
            txtCedulaIdentidad.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(860, 481);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var empleado = EmpleadoCln.obtenerUno(id);
            txtCedulaIdentidad.Text = empleado.cedulaIdentidad;
            txtNombres.Text = empleado.nombres;
            txtPrimerApellido.Text = empleado.primerApellido;
            txtSegundoApellido.Text = empleado.segundoApellido;
            txtDireccion.Text = empleado.direccion;
            txtCelular.Text = empleado.celular.ToString();
            cbxCargo.Text = empleado.cargo;
            txtUsuario.Text = empleado.Usuario.Count() > 0 ? empleado.Usuario.First().usuario1 : "";
            txtCedulaIdentidad.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(860, 349);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
            erpNombres.SetError(txtNombres, "");
            erpApellidos.SetError(txtPrimerApellido, "");
            erpApellidos.SetError(txtSegundoApellido, "");
            erpDireccion.SetError(txtDireccion, "");
            erpCelular.SetError(txtCelular, "");

            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo Cédula de Identidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                esValido = false;
                erpNombres.SetError(txtNombres, "El campo Nombres es obligatorio");
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                esValido = false;
                erpApellidos.SetError(txtPrimerApellido, "Debe introducir al menos un apellido");
                erpApellidos.SetError(txtSegundoApellido, "Debe introducir al menos un apellido");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                esValido = false;
                erpDireccion.SetError(txtDireccion, "El campo Dirección es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                esValido = false;
                erpCelular.SetError(txtCelular, "El campo Celular es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                empleado.nombres = txtNombres.Text.Trim();
                empleado.primerApellido = txtPrimerApellido.Text.Trim();
                empleado.segundoApellido = txtSegundoApellido.Text.Trim();
                empleado.direccion = txtDireccion.Text.Trim();
                empleado.celular = Convert.ToInt64(txtCelular.Text);
                empleado.cargo = cbxCargo.Text;
                empleado.usuarioRegistro = Util.usuario.usuario1;

                if (esNuevo)
                {
                    Usuario usuario = null;
                    if (!string.IsNullOrEmpty(txtUsuario.Text))
                    { 
                        usuario = new Usuario();
                        usuario.usuario1 = txtUsuario.Text.Trim();
                        usuario.clave = Util.Encrypt("hola123");
                    }

                    empleado.fechaRegistro = DateTime.Now;
                    empleado.estado = 1;
                    EmpleadoCln.insertar(empleado, usuario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    empleado.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    EmpleadoCln.actualizar(empleado);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Empleado guardado correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            txtCedulaIdentidad.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cbxCargo.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string cedulaIdentidad = dgvLista.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja el empleado con CI {cedulaIdentidad}?",
                "::: Minerva - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                EmpleadoCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Empleado dado de baja correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
