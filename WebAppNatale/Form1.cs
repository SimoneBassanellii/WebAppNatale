using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace WebAppNatale
{
    public partial class Form1 : Form
    {

        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            MySqlConnection connection = new MySqlConnection();
            string connectionString = "Server=localhost;Database=my_sdkfz181;UID=root;Password=;";
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                MessageBox.Show("Connessione al database riuscita!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore di connessione: " + ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }
        }

    

    private void Loginbutton_Click(object sender, EventArgs e)
    {
        string username = UsernameLogin.Text; // Assumendo che ci sia un TextBox per l'username
        string password = PasswordLogin.Text; // Assumendo che ci sia un TextBox per la password

        // Hash della password
        string hashedPassword = HashPassword(password);

        string query = "SELECT COUNT(*) FROM prognat_amministratore WHERE username=@username AND password=@password";
        using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=my_sdkfz181;UID=root;Password=;"))
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", hashedPassword);

            try
            {
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Login riuscito!");
                    Home homeForm = new Home(); // Assumendo che ci sia un form chiamato Home
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username o password errati.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il login: " + ex.Message);
            }
        }
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

        private void Registrazione_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrazione registrazioneForm = new Registrazione();
            Registrazione.Show();
            this.Hide();

        }
    }
}
