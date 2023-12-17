using System;
using System.Net.Http;
using System.Windows.Forms;

namespace QrCodeGen
{
    public partial class QrCode : Form
    {
        public QrCode()
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Check if the QR code image is available
            if (qrCodeBox1.Image == null)
            {
                MessageBox.Show("No QR code available to save. Generate a QR code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user to choose a location and filename for saving the QR code image
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save QR Code Image";
                saveFileDialog.FileName = "qrcode.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Save the QR code image to the selected file path
                        qrCodeBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("QR code saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    
    }
}
