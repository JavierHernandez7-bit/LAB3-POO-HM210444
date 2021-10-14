using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Ejercicio_1
{
    public partial class Form1 : Form
    {
        private int cuentaCorriente = 1, cuentaAhorros = 1, cuentaPlazos = 1;  
        private List<Banco> Usuarios = new List<Banco>();          
        private int indexValue = -1;

        public void actualizardgv()   
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Usuarios;
        }

        private void limpiar()      
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDUI.Clear();
            txtNIT.Clear();
            txtMonto.Clear();
            txtCuenta.Clear();
            comboSucursal.Text = "";
            comboTipo.Text = "";
        }

        public Form1()
        {
            InitializeComponent();

            // sucursales
            comboSucursal.Items.Clear();
            comboSucursal.Items.Add("Santa Tecla");
            comboSucursal.Items.Add("Santo Tomas");
            comboSucursal.Items.Add("San Juan Opico");
            comboSucursal.Items.Add("Ciudad Merliot");
            comboSucursal.Items.Add("Santa Elena");

            //  tipos de cuenta
            comboTipo.Items.Clear();
            comboTipo.Items.Add("Cuenta corriente");
            comboTipo.Items.Add("Cuenta de ahorros");
            comboTipo.Items.Add("Cuenta a plazos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selection = dataGridView1.SelectedRows[0];
            int position = dataGridView1.Rows.IndexOf(selection);
            indexValue = position;

            Banco actualUser = Usuarios[position];

            txtNombres.Text = actualUser.Nombres;
            txtDUI.Text = actualUser.Dui;
            txtMonto.Text = Convert.ToString(actualUser.Monto);
            txtNIT.Text = actualUser.Nit;
            txtApellidos.Text = actualUser.Apellidos;
            comboTipo.Text = actualUser.TipoCuenta;
            comboSucursal.Text = actualUser.Sucursal;
            txtCuenta.Text = actualUser.NumeroCuenta;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Banco account = new Banco();
            account.Nombres = txtNombres.Text;
            account.Dui = txtDUI.Text;
            account.Nit = txtNIT.Text;
            account.Apellidos = txtApellidos.Text;
            account.Monto = double.Parse(txtMonto.Text);
            account.Sucursal = comboSucursal.Text;
            account.TipoCuenta = comboTipo.Text;
            account.NumeroCuenta = txtCuenta.Text;

            if (indexValue > -1)
            {
                Usuarios[indexValue] = account;
                indexValue = -1;
            }
            else
                Usuarios.Add(account);

            limpiar();
            actualizardgv();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipo.Text == "Cuenta de ahorros")
            {
                txtCuenta.Text = $"CC-{cuentaAhorros}";
                cuentaAhorros++;
            }
            if (comboTipo.Text == "Cuenta corriente")
            {
                txtCuenta.Text = $"CA-{cuentaCorriente}";
                cuentaCorriente++;
            }
            if (comboTipo.Text == "Cuenta a plazos")
            {
                txtCuenta.Text = $"CP-{cuentaPlazos}";
                cuentaPlazos++;
            }
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Usuarios.RemoveAt(indexValue);
            indexValue = -1;
            limpiar();
            actualizardgv();
        }

        
    }
}
