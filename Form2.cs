using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_learning
{
    public partial class Form2 : Form
    {
        // Declare fields here
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public Form2()
        {
            InitializeComponent();
            // Connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=e_learning";
            connection = new MySqlConnection(connectionString);
            PopulateComboBox();  // Populate ComboBox with table names
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void PopulateComboBox()
        {
            cbTableList.Items.Add("Users");
            cbTableList.Items.Add("Courses");
            cbTableList.Items.Add("Payments");
            cbTableList.Items.Add("Assessments");
            cbTableList.Items.Add("Messages");
        }
        // Event: When a table is selected from the ComboBox
        private void cbTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbTableList.SelectedItem.ToString();

            // Load data into DataGridView
            LoadTableData(selectedTable);
        }

        private void ConfigureAdapter(string tableName)
        {
            string selectQuery = $"SELECT * FROM {tableName}";
            adapter = new MySqlDataAdapter(selectQuery, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            adapter.UpdateCommand = builder.GetUpdateCommand(); // Generate dynamic update command
            adapter.InsertCommand = builder.GetInsertCommand(); // Generate dynamic insert command
            adapter.DeleteCommand = builder.GetDeleteCommand(); // Generate dynamic delete command
        }

        private void LoadTableData(string tableName)
        {
            try
            {
                ConfigureAdapter(tableName); // Ensure commands are configured for the adapter

                table = new DataTable();
                adapter.Fill(table); // Fill the DataTable with data from the selected table
                dataGridView2.DataSource = table; // Bind the DataTable to the DataGridView
                MessageBox.Show($"Rows loaded: {table.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event: Save changes to the database
        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            try
            {
                /// Ensure all changes are committed to the DataTable
                dataGridView2.EndEdit();

                // Check if any changes exist in the DataTable
                DataTable changes = table.GetChanges();
                if (changes == null || changes.Rows.Count == 0)
                {
                    MessageBox.Show("No changes to save.");
                    return;
                }

                // Save changes back to the database
                adapter.Update(table);
                table.AcceptChanges(); // Mark rows as unchanged after a successful update
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
            {
            // Create a new instance of Form1
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                form1.ReloadData(); // Call a method in Form1 to reload data
                form1.Show();       // Show Form1
                this.Hide();        // Hide Form2
            }
        }
    }
}
