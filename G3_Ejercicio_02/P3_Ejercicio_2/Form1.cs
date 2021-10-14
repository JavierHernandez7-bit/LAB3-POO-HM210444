using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P3_Ejercicio_2
{
    public partial class Form1 : Form
    {
        private List<Registro> registroNotas = new List<Registro>();
        private int edit_index = -1;
        private void actualizar()
        {
            dgvnotas.DataSource = null;
            dgvnotas.DataSource = registroNotas;
        }

        private void limpiar()
        {
            txtcarnet.Clear();
            txtnombres.Clear();
            txtapellidos.Clear();
            txtasignatura.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dgvnotas_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selection = dgvnotas.SelectedRows[0];
            int posicion = dgvnotas.Rows.IndexOf(selection);
            edit_index = posicion;

            Registro dgvreg = registroNotas[posicion];

            txtcarnet.Text = dgvreg.Carnet;
            txtnombres.Text = dgvreg.Nombres;
            txtapellidos.Text = dgvreg.Apellidos;
            txtasignatura.Text = dgvreg.Asignaturas;
            txtnota1.Text = Convert.ToString(dgvreg.Nota1);
            txtnota2.Text = Convert.ToString(dgvreg.Nota2);
            txtnota3.Text = Convert.ToString(dgvreg.Nota3);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Registro dgvreg = new Registro();
            dgvreg.Carnet = txtcarnet.Text;
            dgvreg.Nombres = txtnombres.Text;
            dgvreg.Apellidos = txtapellidos.Text;
            dgvreg.Asignaturas = txtasignatura.Text;
            dgvreg.Nota1 = double.Parse(txtnota1.Text);
            dgvreg.Nota2 = double.Parse(txtnota2.Text);
            dgvreg.Nota3 = double.Parse(txtnota3.Text);

            if (edit_index > -1)
            {
                registroNotas[edit_index] = dgvreg;
                edit_index = -1;
            }
            else
            registroNotas.Add(dgvreg);
            actualizar();
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_index > -1)
            {
                registroNotas.RemoveAt(edit_index);
                edit_index = -1;
                limpiar();
                actualizar();
            }
            else
                MessageBox.Show("Selecciona antes de eliminar.");          
        }
    }
}
