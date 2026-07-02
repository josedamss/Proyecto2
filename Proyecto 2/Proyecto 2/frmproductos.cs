using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_2
{
    public partial class frmproductos : Form
    {
        public frmproductos()
        {
            InitializeComponent();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            string error = "";

            var validaciones = new[]
            {
                new { Condicion = txtnombre.Text.Length < 3, Mensaje = "\nEl nombre debe tener al menos 3 caracteres." },
                new { Condicion = string.IsNullOrWhiteSpace(txtnombre.Text), Mensaje = "\nEl nombre no puede estar vacío." },
                new { Condicion = cbcategoria.SelectedIndex == -1, Mensaje = "\nDebe seleccionar una categoría." },
                new { Condicion = string.IsNullOrWhiteSpace(cbcategoria.Text), Mensaje = "\nLa categoría no puede estar vacía." },
                new { Condicion = txtprecio.Text.Length < 1, Mensaje = "\nEl precio debe tener al menos 1 caracter." },
                new { Condicion = string.IsNullOrWhiteSpace(txtprecio.Text), Mensaje = "\nEl precio no puede estar vacío." },
                new { Condicion = txtstock.Text.Length < 1, Mensaje = "\nEl stock debe tener al menos 1 caracter." },
                new { Condicion = string.IsNullOrWhiteSpace(txtstock.Text), Mensaje = "\nEl stock no puede estar vacío." }


            };

            for (int i = 0; i < validaciones.Length; i++)
            {
                if (validaciones[i].Condicion)
                {
                    error += validaciones[i].Mensaje;
                }
            }

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    Conexion conexion = new Conexion();
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "INSERT INTO productos (nombre, id_categoria, precio, stock) VALUES (@nombre, @id_categoria, @precio, @stock)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                            cmd.Parameters.AddWithValue("@id_categoria", Convert.ToInt32(cbcategoria.SelectedValue));
                            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtprecio.Text));
                            cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtstock.Text));
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtnombre.Clear();
                                cbcategoria.SelectedIndex = -1;
                                txtprecio.Clear();
                                txtstock.Clear();

                                mostrarDatos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            mostrarDatos();


        }

        private void CargarCategorias()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT id_categoria, nombre FROM categorias";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            cbcategoria.DataSource = dt;
                            cbcategoria.DisplayMember = "nombre"; 
                            cbcategoria.ValueMember = "id_categoria"; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarDatos(string buscar = "")
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT
                        id_producto,
                        nombre,
                        precio,
                        stock,
                        id_categoria
                    FROM productos
                    WHERE nombre LIKE @buscar
                       OR id_categoria LIKE @buscar";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        dtgridproduct.DataSource = tabla;
                    }
                }
                conn.Close();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            mostrarDatos(txtbuscar.Text);
        }
    }
}





