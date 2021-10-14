using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P3_Ejemplo_4
{
    public partial class Form1 : Form
    {
        
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1; 

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Productos; 
        }
        private void reseteo()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            pictureBox1.Image = null;
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected); 
            edit_indice = posicion; 
            Producto product = Productos[posicion];  
            
            txtnombre.Text = product.Nombre;
            txtdescripcion.Text = product.Descripcion;
            txtmarca.Text = product.Marca;
            txtprecio.Text = Convert.ToString(product.Precio);
            txtstock.Text = Convert.ToString(product.Stock);
            pictureBox1.Image = product.Imagen;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            Producto product = new Producto();
            product.Nombre = txtnombre.Text;
            product.Descripcion = txtdescripcion.Text;
            product.Marca = txtmarca.Text;
            product.Precio = float.Parse(txtprecio.Text);
            product.Stock = int.Parse(txtstock.Text);
            product.Imagen = pictureBox1.Image;
            if (edit_indice > -1) 
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product); 
                
            }
            actualizarGrid();
            reseteo(); 
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) 
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; 
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(opnfd.FileName);
        }
    }
}
