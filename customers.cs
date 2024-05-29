using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CsharpApi
{
    public partial class customers : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public customers()
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private void txtIsActive_TextChanged(object sender, EventArgs e)
        {
            // Implement event handler if needed
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            // Ensure no required field is empty
            if (string.IsNullOrWhiteSpace(txtCusname.Text) ||
                string.IsNullOrWhiteSpace(txtCusNum.Text) ||
                string.IsNullOrWhiteSpace(txtlocation.Text) ||
                string.IsNullOrWhiteSpace(txtpayment.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            var customerData = new
            {
                CustomerName = txtCusname.Text,
                ContactNumber = txtCusNum.Text,
                Location = txtlocation.Text,
                Payment = txtpayment.Text,
                Email = txtemail.Text
            };

            string jsonCustomerData = JsonConvert.SerializeObject(customerData);
            HttpContent customerContent = new StringContent(jsonCustomerData, Encoding.UTF8, "application/json");

            try
            {
                // Post data to add customer
                HttpResponseMessage customerResponse = await client.PostAsync("http://localhost/phpapi/api.php", customerContent);
                customerResponse.EnsureSuccessStatusCode();
                string customerResponseBody = await customerResponse.Content.ReadAsStringAsync();
                txtOutput.Text = customerResponseBody;

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