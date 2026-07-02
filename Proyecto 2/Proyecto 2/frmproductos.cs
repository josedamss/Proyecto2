using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void mostrardatos(string buscar = "")
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT
                        id_,
                        nombre,
                        correo,
                        telefono,
                        direccion
                    FROM clientes
                    WHERE nombre LIKE @buscar
                       OR correo LIKE @buscar
                       OR telefono LIKE @buscar";
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


        private void btnguardar_Click(object sender, EventArgs e)
        {
            string error = "";

            var validaciones = new[]
            {
                new { Condicion = txtnombre.Text.Length < 3, Mensaje = "\nEl nombre debe tener al menos 3 caracteres." },
                new { Condicion = string.IsNullOrWhiteSpace(txtnombre.Text), Mensaje = "\nEl nombre no puede estar vacío." },
                new { Condicion = txtcat.Text.Length < 1, Mensaje = "\nLa categoría debe tener al menos 1 caracter." },
                new { Condicion = string.IsNullOrWhiteSpace(txtcat.Text), Mensaje = "\nLa categoría no puede estar vacía." },
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
            }

            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    Conexion conexion = new Conexion();
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "INSERT INTO productos (nombre, categoria, precio, stock) VALUES (@nombre, @categoria, @precio, @stock)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                            cmd.Parameters.AddWithValue("@categoria", txtcat.Text);
                            cmd.Parameters.AddWithValue("@precio", txtprecio.Text);
                            cmd.Parameters.AddWithValue("@stock", txtstock.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtnombre.Clear();
                                txtcat.Clear();
                                txtprecio.Clear();
                                txtstock.Clear();
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

        }
    }
}

