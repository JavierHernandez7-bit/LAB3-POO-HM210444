using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaPersonas
{
    public partial class Form1 : Form
    {
        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que 
        //no hay ninguno seleccionado, esto servirá para el DataGridView.
        private void actualizarGrid()
        {
            Dgvcontactos.DataSource = null;
            Dgvcontactos.DataSource = Personas;
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dgvcontactos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Dgvcontactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow seleccion = Dgvcontactos.SelectedRows[0];
            int pos = Dgvcontactos.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado
            Persona per = Personas[pos];

            txtnombre.Text = per.Nombre;
            txtapellido.Text = per.Apellido;
            txttelefono.Text = per.Telefono;
            txtcorreo.Text = per.Correo;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            Persona per = new Persona();
            per.Nombre = txtnombre.Text;
            per.Apellido = txtapellido.Text;
            per.Telefono = txttelefono.Text;
            per.Correo = txtcorreo.Text;
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {
                Personas.Add(per);

            }

            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            limpiar();//mandamos a llamar la función que limpia

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            {
                if (edit_indice > -1) //verifica si hay un índice seleccionado
                {
                    Personas.RemoveAt(edit_indice);
                    edit_indice = -1; //resetea variable a -1
                    limpiar();
                    actualizarGrid();
                }
                else
                {
                    MessageBox.Show("Debe dar doble click primero sobre contacto");

                }
            }
        }
    }
}
