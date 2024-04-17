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

namespace Library_Management_System2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            book bookObj = new book();
            bookObj.book_id = ID_textbox.Text;
            bookObj.book_name = Name_textbox.Text;
            bookObj.author_name = Author_textBox.Text;
            bookObj.book_type = typecomboBox1.Text;
            bookObj.language = Lang_textBox.Text;
            bookObj.publisher = Publisher_textBox.Text;
            bookObj.price = Price_textBox.Text;
            bookObj.date = dateTimePicker1.Text;
            databaseConnection DatabaseConnectionObj = new databaseConnection();
            string query = "insert into book values('" + bookObj.book_id + "','" + bookObj.book_name + "','" +bookObj.author_name 
                + "','" + bookObj.book_type + "','" + bookObj.language +  "','" + bookObj.publisher + "','"
                + bookObj.price + "','" + bookObj.date + "' )";
            DatabaseConnectionObj.ExecuteSqlCommandAndCloseConnection(query, DatabaseConnectionObj.GetConnectionObj());
            MessageBox.Show("Data saved successfully.........");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            databaseConnection databaseConnectionObj = new databaseConnection();
            string query = "(select * from book)";
            databaseConnectionObj.ExecuteSqlCommandAndCloseConnection(query,
                databaseConnectionObj.GetConnectionObj());
            SqlDataAdapter dAdapter = new SqlDataAdapter(query, databaseConnectionObj.GetConnectionString());
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
