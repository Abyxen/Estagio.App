using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using MySql.Data.MySqlClient;
using System.Data;
namespace Estagio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Choose one of the tables");
            }
            else if (comboBox1.SelectedItem.ToString() == "User_id")
            {
                string connectionString = "server=localhost;port=3307;user=root;password=aeap2025;database=estagio";

                string query = "SELECT * FROM user_id";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (comboBox1.SelectedItem.ToString() == "User_Location")
            {
                string connectionString = "server=localhost;port=3307;user=root;password=aeap2025;database=estagio";

                string query = "SELECT * FROM user_location";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
