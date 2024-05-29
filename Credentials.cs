using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CsharpApi
{
    public partial class Credentials : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Credentials()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Clear();
                HttpResponseMessage response = await client.GetAsync("http://localhost/phpapi/api.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput.Text = responseBody;
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("HTTP Error: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            // Ensure no required field is empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text) ||
                string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtIsActive.Text) ||
                string.IsNullOrWhiteSpace(txtposition.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Validate and convert isActive to boolean
            if (!bool.TryParse(txtIsActive.Text, out bool isActive))
            {
                MessageBox.Show("Invalid input for isActive. Please enter true or false.");
                return;
            }

            var userData = new
            {
                username = txtUsername.Text,
                password = txtpassword.Text,
                name = txtname.Text,
                email = txtEmail.Text,
                isActive = isActive,
                position = txtposition.Text
            };

            string json = JsonConvert.SerializeObject(userData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/phpapi/api.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput.Text = responseBody;
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("HTTP Error: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void Credentials_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private void ClearUserData()
        {
            // Clear content of text boxes
            txtUsername.Clear();
            txtpassword.Clear();
            txtname.Clear();
            txtEmail.Clear();
            txtIsActive.Clear();
            txtposition.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearUserData();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtIsActive_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customers form2 = new customers();

            // Show Form2
            form2.Show();

            // Optionally, close or hide Form1
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Credentials form = new Credentials();

            // Show Form2
            form.Show();

            // Optionally, close or hide Form1
            this.Hide();
        }
    }
}
