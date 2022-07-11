using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Crud_forms
{
    public partial class Form1 : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=123;USER ID=pruebaUsuario;");
        public Form1()
        {
            InitializeComponent();
        }
        private void Load_Click(object sender, EventArgs e)
        {
            UpdateDb();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            ModDb();
            UpdateDb();
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            InsertDb();
            UpdateDb();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteDb();
            UpdateDb();
        }


        private void UpdateDb()
        {
            try
            {
                ora.Open();

                OracleCommand command = new OracleCommand("seleccionarpersonas", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("registros", OracleType.Cursor).Direction = System.Data.ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgPERSONAS.DataSource = dt;
                MessageBox.Show("Tabla actualizada");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");

                throw;
            }

            txtID.Text = "";
            txtContrasenia.Text = "";
            txtNombre.Text = "";


            ora.Close();
        }

        private void DeleteDb()
        {
            try
            {
                ora.Open();
                OracleCommand command = new OracleCommand("eliminar", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idp", OracleType.Number).Value = txtID.Text;
                command.ExecuteNonQuery();

                MessageBox.Show("Dato eliminado");

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");
            }
            ora.Close();
        }

        private void InsertDb()
        {
            try
            {
                ora.Open();

                OracleCommand command = new OracleCommand("insertar", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                command.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasenia.Text;
                OracleDataAdapter adapter = new OracleDataAdapter();
                command.ExecuteNonQuery();
                MessageBox.Show("Dato insertado en la tabla");

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");
            }
            ora.Close();
        }

        private void ModDb()
        {
            try
            {
                ora.Open();

                OracleCommand command = new OracleCommand("actualizar", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                command.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasenia.Text;
                command.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtID.Text);
                OracleDataAdapter adapter = new OracleDataAdapter();
                command.ExecuteNonQuery();
                MessageBox.Show("Datoo actualizado");

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");
            }
            ora.Close();
        }

        #region NotActive

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgPERSONAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
