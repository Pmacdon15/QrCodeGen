using System;
using System.Net.Http;
using System.Windows.Forms;

namespace QrCodeGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               
        private async void buttonGen_Click(object sender, EventArgs e)
        {
            // Get the text value from userInputBox
            string userInput = userInputBox.Text;

            // Construct the API URL with the user input
            string qrCodeUrl = $"https://api.qrserver.com/v1/create-qr-code/?size=150x150&data={userInput}";

            // Use HttpClient to make the API request
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send a GET request to the API
                    HttpResponseMessage response = await client.GetAsync(qrCodeUrl);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Get the response content as a byte array
                        byte[] imageData = await response.Content.ReadAsByteArrayAsync();

                        // Create a MemoryStream from the byte array
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                        {
                            // Set the image in qrCodeBox1
                            qrCodeBox1.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Handle the case when the API request is not successful
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


    }
}
