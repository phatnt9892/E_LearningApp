using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_learning
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=e_learning";
            connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = @"SELECT u.UserID, u.Name, u.Email, 
                                        c.CourseID, c.Title AS CourseName, 
                                        i.Name AS InstructorName, i.Email AS InstructorEmail, 
                                        c.Price, a.Type AS FinalExam, 
                                        p.Amount AS PaymentAmount, p.PaymentDate, p.PaymentStatus
								 FROM users u
                                 LEFT JOIN payments p ON u.UserID = p.UserID
                                 LEFT JOIN courses c ON p.CourseID = c.CourseID
                                 LEFT JOIN assessments a ON c.CourseID = a.CourseID
                                 LEFT JOIN users i ON c.InstructorID = i.UserID
                                 WHERE u.Role = 'Student'"
                ;

                adapter = new MySqlDataAdapter(query, connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Code to handle cell click event
            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}");
        }
        public void ReloadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Users"; // Adjust for the table to reload
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table; // Assuming 'dataGridView1' displays data in Form1
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Opens Form2
            this.Hide();  // Hides Form1
        }
    }
}
