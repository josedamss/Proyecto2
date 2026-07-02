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
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        

        private void btnmodi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id_seleccionado = dataGridView1.CurrentRow.Cells["id_clientes"].Value.ToString();
                Conexion conexion = new Conexion();
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql_modificar = "UPDATE clientes SET nombre = @nombre, telefono = @telefono, correo = @correo, direccion = @direccion WHERE id_clientes = @id";
                    MySqlCommand comando = new MySqlCommand(sql_modificar, conn);
                    comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    comando.Parameters.AddWithValue("@telefono", txtcell.Text);
                    comando.Parameters.AddWithValue("@correo", txtcorreo.Text);
                    comando.Parameters.AddWithValue("@direccion", txtdirecc.Text);
                    comando.Parameters.AddWithValue("@id", id_seleccionado);
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registro modificado correctamente.");
                    mostrardatos();

                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla primero.");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string error = "";

            var validaciones = new[]
            {
                new { Condicion = txtnombre.Text.Length < 3, Mensaje = "\nEl nombre debe tener al menos 3 caracteres." },
                new { Condicion = string.IsNullOrWhiteSpace(txtnombre.Text), Mensaje = "\nEl nombre no puede estar vacío." },
                new { Condicion = txtcell.Text.Length < 8, Mensaje = "\nEl celular debe tener al menos 8 dígitos." },
                new { Condicion = string.IsNullOrWhiteSpace(txtcell.Text), Mensaje = "\nEl celular no puede estar vacío." },
                new { Condicion = string.IsNullOrWhiteSpace(txtcorreo.Text), Mensaje = "\nEl correo no puede estar vacío." },
                new { Condicion = string.IsNullOrWhiteSpace(txtdirecc.Text), Mensaje = "\nLa dirección no puede estar vacía." },


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

            if (error == "")
            {

                try
                {
                    Conexion conexion = new Conexion();
                    using (MySqlConnection conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "INSERT INTO clientes (nombre, telefono, correo, direccion) VALUES (@nombre, @telefono, @correo, @direccion)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                            cmd.Parameters.AddWithValue("@direccion", txtdirecc.Text);
                            cmd.Parameters.AddWithValue("@telefono", txtcell.Text);
                            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente guardado correctamente.");
                                txtnombre.Clear();
                                txtdirecc.Clear();
                                txtcell.Clear();
                                txtcorreo.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el cliente.");
                            }
                            conn.Close();


                        }
                    }
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                mostrardatos();

            }
            else
            {
                MessageBox.Show("Errores encontrados: " + error);
            }
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_clientes"].Value);
                try
                {
                    Conexion conexion = new Conexion();
                    using (MySqlConnection conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "DELETE FROM clientes WHERE id_clientes = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idCliente);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente eliminado correctamente.");
                                mostrardatos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el cliente.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            mostrardatos();
        }

        private void txtbuscarcliente_KeyUp(object sender, KeyEventArgs e)
        {
            mostrardatos(txtbuscarcliente.Text);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            
            string texto = txtnombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                lberrornombre.Text = "El nombre no puede estar vacío.";
                lberrornombre.Visible = true;
            }
            
            else if (texto.Length < 3)
            {
                lberrornombre.Text = "Debe tener al menos 3 caracteres.";
                lberrornombre.Visible = true;
            }
            
            else
            {
                lberrornombre.Visible = false;
            }
        }

        private void txtcell_TextChanged(object sender, EventArgs e)
        {
            string texto = txtcell.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                lberrorcell.Text = "El Celular no puede estar vacio.";
                lberrorcell.Visible = true;
            }
            else if (texto.Length < 8)
            {
                lberrorcell.Text = "Debe tener al menos 8 digitos.";
                lberrorcell.Visible = true;

            }
            else 
            { 
                lberrorcell.Visible = false; 
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            string texto = txtcorreo.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                lberrorcorreo.Text = "Escriba su dominio, ejemplo: abc@gmail.com";
                lberrorcorreo.Visible = true;
            }
            else
            {
                lberrorcorreo.Visible= false;
            }

        }

        private void txtdirecc_TextChanged(object sender, EventArgs e)
        {
            string texto = txtdirecc.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                lberrordirecc.Text = "La direccion no puede estar vacia";
                lberrordirecc.Visible = true;

            }
            else if (texto.Length < 10)
            {
                lberrordirecc.Text = "Ingrese al menos 10 caracteres";
                lberrordirecc.Visible = true;
            }
            else
            {
                lberrordirecc.Visible = false;
            }
        }

        private void mostrardatos(string buscar = "")
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT
                        id_clientes,
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
                        dataGridView1.DataSource = tabla;
                    }
                }
                conn.Close();
            }
        }
    }
}
