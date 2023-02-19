using QRCodeDecoderLibrary;
using QRCoder;
using System.Drawing.Imaging;

namespace QRGenerator
{
    public partial class Form1 : Form
    {

        public string iconPath = "";
        public Color darkColor = Color.Black;
        public Color lightColor = Color.White;
        public Color logoBGColor = Color.White;

        public Form1()
        {
            InitializeComponent();
            btnLogoBGColor.BackColor = logoBGColor;
            buttonDarkColor.BackColor = darkColor;
            buttonLightColor.BackColor = lightColor;
            comboBoxWifiType.DataSource = Enum.GetValues(typeof(PayloadGenerator.WiFi.Authentication)).Cast<PayloadGenerator.WiFi.Authentication>();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var qrCodeResult = this.generateQRCode(out Bitmap? qrCodeImage);
            if (qrCodeResult == true && qrCodeImage != null)
            {
                pictureBoxPreview.Image = qrCodeImage;
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

       

        private bool generateQRCode(out Bitmap? image)
        {
            string payload = "";
            switch(tabControlType.SelectedTab.Name)
            {
                case "tabPageText":
                    payload = txtBxPayload.Text;
                    if(string.IsNullOrEmpty(payload)) { 
                        MessageBox.Show("Must input text to generate code", "Missing Text");
                        image = null;
                        return false;
                    }
                    break;
                case "tabPageWiFi":
                    if (string.IsNullOrEmpty(textBoxSSID.Text) || string.IsNullOrEmpty(textBoxPass.Text))
                    {
                        MessageBox.Show("Must input wifi ssid and pass to generate code", "Missing WiFi Details");
                        image = null;
                        return false;
                    }
                    PayloadGenerator.WiFi wifiPayLoad = new PayloadGenerator.WiFi(textBoxSSID.Text, textBoxPass.Text, (PayloadGenerator.WiFi.Authentication)comboBoxWifiType.SelectedItem, checkBoxHiddenSSID.Checked);
                    payload = wifiPayLoad.ToString();
                    break;
                default:
                    payload = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                    break;
            }
  
               
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeDate = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeDate);
            Bitmap qrImage = null;
            if (checkBoxIncludeImage.Checked && !string.IsNullOrEmpty(iconPath) && File.Exists(iconPath))
            {
                Bitmap iconBitmap = new Bitmap(iconPath);
                qrImage = qrCode.GetGraphic(50, this.darkColor, this.lightColor, icon: iconBitmap, iconSizePercent: ((int)numericUpDownLogoSize.Value), iconBorderWidth: (int)numericUpDownBorderWidth.Value, iconBackgroundColor: this.logoBGColor, drawQuietZones: checkBoxQuietZone.Checked);
            }
            else qrImage = qrCode.GetGraphic(20, this.darkColor, this.lightColor, checkBoxQuietZone.Checked);
            var res =  this.ValidateQRCode(qrImage);
            if (res == true)
            {
                image = qrImage;
                return true;
            }
            else
            {
                MessageBox.Show("Validating the QR Code Failed");
                image= null;
                return false;
            }

        }

        private bool ValidateQRCode(Bitmap qrcode)
        {
            QRDecoder decoder = new QRDecoder();
            var result= decoder.ImageDecoder(qrcode);
            if (result != null)
            {
                return true;
            }
            else return false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIncludeImage.Checked)
                btnLoadImage.Enabled = true;
            else btnLoadImage.Enabled = false;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();

            openImage.Filter = "*.BMP | *.*";

            openImage.DefaultExt = ".BMP"; // Default file extension 

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                string fileName = openImage.FileName;
                this.iconPath = fileName;
                pictureBoxImagePreview.ImageLocation = fileName;
                pictureBoxImagePreview.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxImagePreview.Load();
            }
        }

        private void btnLogoBGColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLogoBGColor.ShowDialog() == DialogResult.OK)
                this.logoBGColor = colorDialogLogoBGColor.Color;
            btnLogoBGColor.BackColor = this.logoBGColor;
        }

        private void buttonDarkColor_Click(object sender, EventArgs e)
        {
            if (colorDialogDarkColor.ShowDialog() == DialogResult.OK)
                this.darkColor = colorDialogDarkColor.Color;
            buttonDarkColor.BackColor = this.darkColor;
        }

        private void buttonLightColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLightColor.ShowDialog() == DialogResult.OK)
                this.lightColor = colorDialogLightColor.Color;
            buttonLightColor.BackColor = this.lightColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter ="*.BMP | *.*";
            saveFileDialog.Title = "Save QR Code";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var qrCodeResult = this.generateQRCode(out Bitmap? qrCodeImage);
                if (qrCodeResult == true && qrCodeImage != null)
                {
                    pictureBoxPreview.Image = qrCodeImage;
                    pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    qrCodeImage!.Save(saveFileDialog.FileName);
                    if (File.Exists(saveFileDialog.FileName))
                        MessageBox.Show("File Saved Successfully");
                }
            }
        }
    }
}