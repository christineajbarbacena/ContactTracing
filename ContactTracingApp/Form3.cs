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

        }


        private void bttnGenerate_Click(object sender, EventArgs e)
        {

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picboxGenerateQr.Image = qrcode.Draw(txtboxresponses.Text,300);

        }

     
    }
}
