using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D032310348_test_
{
    public partial class formStock : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public formStock()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348(test)\\D032310348(test)\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void formStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.admiralBookstore.Stock);
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348(test)\\D032310348(test)\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Stock";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Stock");

                dataGridViewStock.DataSource = dataSet.Tables["Stock"];
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxStock.Text) || string.IsNullOrEmpty(textBoxAuthor.Text) ||
                string.IsNullOrEmpty(textBoxISBN.Text) || string.IsNullOrEmpty(textBoxQuantity.Text) ||
                dateRecordedDateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            textBoxStock.Clear();
            textBoxAuthor.Clear();
            textBoxISBN.Clear();
            textBoxQuantity.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Stock (StockID, AuthorID, [ISBN-13], QuantityInStock, DateRecorded) VALUES (@StockID, @AuthorID, @ISBN13, @QuantityInStock, @DateRecorded)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", textBoxStock.Text);
                    command.Parameters.AddWithValue("@AuthorID", textBoxAuthor.Text);
                    command.Parameters.AddWithValue("@ISBN13", textBoxISBN.Text);
                    command.Parameters.AddWithValue("@QuantityInStock", textBoxQuantity.Text);
                    command.Parameters.AddWithValue("@DateRecorded", dateRecordedDateTimePicker.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "UPDATE Stock SET AuthorID = @AuthorID, [ISBN-13] = @ISBN13, QuantityInStock = @QuantityInStock, DateRecorded = @DateRecorded WHERE StockID = @StockID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", textBoxStock.Text);
                    command.Parameters.AddWithValue("@AuthorID", textBoxAuthor.Text);
                    command.Parameters.AddWithValue("@ISBN13", textBoxISBN.Text);
                    command.Parameters.AddWithValue("@QuantityInStock", textBoxQuantity.Text);
                    command.Parameters.AddWithValue("@DateRecorded", dateRecordedDateTimePicker.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxStock.Text))
            {
                string query = "DELETE FROM Stock WHERE StockID = @StockID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", textBoxStock.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please enter a StockID to delete.");
            }
        }

        private void btnBookS_Click(object sender, EventArgs e)
        {
            formBook fBook = new formBook();
            fBook.Show();
            this.Hide();
        }

        private void btnAuthorS_Click(object sender, EventArgs e)
        {
            formAuthor fAuthor = new formAuthor();
            fAuthor.Show();
            this.Hide();
        }
    }
}
