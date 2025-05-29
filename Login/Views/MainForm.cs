using Login.Data;
using Login.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Views
{
    public partial class MainForm : Form
    {
        private int empleadoId = 0;
        private bool actualizar = false;
        private readonly EmpleadoData empleadoData = new();
        private readonly DepartamentoData departamentoData = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CargarEmpleados(string buscar)
        {
            rgvEmpleados.DataSource = empleadoData.ObtenerEmpleados(buscar);
        }

        private void CargarDepartamentos()
        {
            cmbDepartamento.DataSource = departamentoData.ObtenerdDepartamentos();
            cmbDepartamento.DisplayMember = "NOMBRE";
            cmbDepartamento.ValueMember = "ID";
            cmbDepartamento.SelectedIndex = -1;
        }

        private void LimpiarTxt()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtSalario.Clear();
            txtBuscar.Clear();
            cmbDepartamento.SelectedIndex = -1;
        }

        private void HabilitarTxt(bool status)
        {
            txtBuscar.Enabled = !status;
            txtNombre.Enabled = status;
            txtEdad.Enabled = status;
            txtSalario.Enabled = status;
            cmbDepartamento.Enabled = status;
        }

        private void HabilitarBotones(bool status)
        {
            btnEliminar.Enabled = status;
            btnActualizar.Enabled = status;
            btnNuevo.Enabled = status;

            btnGuardar.Enabled = !status;
            btnCancelar.Enabled = !status;
        }

        private bool ValidarTxt()
        {
            bool validar = false;
            if (string.IsNullOrEmpty(txtNombre.Text)) validar = true;
            if (string.IsNullOrEmpty(txtEdad.Text)) validar = true;
            if (string.IsNullOrEmpty(txtSalario.Text)) validar = true;
            return validar;
        }

        private void Seleccionar()
        {
            empleadoId = Convert.ToInt32(rgvEmpleados.CurrentRow.Cells["ID"].Value);
            txtNombre.Text = Convert.ToString(rgvEmpleados.CurrentRow.Cells["EMPLEADO"].Value);
            txtEdad.Text = Convert.ToString(rgvEmpleados.CurrentRow.Cells["EDAD"].Value);
            txtSalario.Text = Convert.ToString(rgvEmpleados.CurrentRow.Cells["SALARIO"].Value);
            cmbDepartamento.Text = Convert.ToString(rgvEmpleados.CurrentRow.Cells["DEPARTAMENTO"].Value);
        }

        private void CrearEmpleado()
        {
            EmpleadoModel model = new EmpleadoModel();
            model.Nombre = txtNombre.Text;
            model.Edad = Convert.ToInt32(txtEdad.Text);
            model.Salario = Convert.ToDecimal(txtSalario.Text);
            model.IdDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);

            string resp = empleadoData.CrearEmpleado(model);

            if (!resp.Equals("Ok"))
            {
                MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CargarEmpleados("%");
            LimpiarTxt();
            HabilitarTxt(false);
            MessageBox.Show("Se registro con exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarEmpleado()
        {
            EmpleadoModel model = new EmpleadoModel();
            model.Id = empleadoId;
            model.Nombre = txtNombre.Text;
            model.Edad = Convert.ToInt32(txtEdad.Text);
            model.Salario = Convert.ToDecimal(txtSalario.Text);
            model.IdDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);

            string resp = empleadoData.ActualizarEmpleado(model);

            if (!resp.Equals("Ok"))
            {
                MessageBox.Show("No se pudo actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CargarEmpleados("%");
            LimpiarTxt();
            HabilitarTxt(false);
            MessageBox.Show("Se actualizo con exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EliminarEmpleado(int id)
        {
            string resp = empleadoData.EliminarEmpleado(id);
            if (!resp.Equals("Ok"))
            {
                MessageBox.Show("No se pudo eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CargarEmpleados("%");
            LimpiarTxt();
            HabilitarTxt(false);
            MessageBox.Show("Se elimino con exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarTxt(true);
            HabilitarBotones(false);
            LimpiarTxt();
            empleadoId = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }

        private void rgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTxt())
            {
                MessageBox.Show("Hay campos vacios... No se puede guardar.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (actualizar)
            {
                ActualizarEmpleado();
            }
            else
            {
                CrearEmpleado();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (empleadoId == 0)
            {
                MessageBox.Show("Selecciona un registro", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HabilitarTxt(true);
            actualizar = true;
            HabilitarBotones(false);
            txtNombre.Select();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (empleadoId == 0)
            {
                MessageBox.Show("Selecciona un registro para eliminar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Estas seguro que quieres eliminar este registro", "ALTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                EliminarEmpleado(empleadoId);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarTxt(false);
            HabilitarBotones(true);
            LimpiarTxt();
            empleadoId = 0;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
