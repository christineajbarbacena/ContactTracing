using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace ContactTracingApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            StreamReader text = new StreamReader(@"C:\Users\barbacena\Desktop\ContactTracingResponses\generatedqr.txt");
            string response = text.ReadToEnd();
            txtboxresponses.Text = response.ToString();

        }


        private void bttnsave_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\barbacena\Desktop\ContactTracingResponses";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = dir;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*gif";
            if (dialog.ShowDialog() == DialogResult.OK)

            {
                pbqrcode.Image.Save(dialog.FileName);
            }
            MessageBox.Show("Image Saved");
        }


        private void bttnGenerate_Click(object sender, EventArgs e)
        { 
            string qrtext = txtboxresponses.Text;
            txtboxresponses.Text = qrtext.ToString();

            pbqrcode.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrbarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pbqrcode.Image = qrbarcode.Draw(qrtext, 5);
            
        }

     
    }
}
