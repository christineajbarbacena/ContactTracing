using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
using AForge.Video;
using AForge;
using System.IO;
using AForge.Video.DirectShow;
using IronBarCode.Logging;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace ContactTracingApp
{
    public partial class Form4 : Form
    {

        BackgroundWorker bgworker;
        FilterInfoCollection filterinfocoll;
        VideoCaptureDevice vcdevice;

        public Form4()
        {
            InitializeComponent();
            bgworker = new BackgroundWorker();
            bgworker.DoWork += bgworker_DoWork;
        }

        void bgworker_DoWork(object sender, DoWorkEventArgs e)

        {
            QRCodeDecoder decoder = new QRCodeDecoder();

            try
            {
                MessageBox.Show(decoder.Decode(new QRCodeBitmapImage ((Bitmap)pbImageScan.Image)));
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            filterinfocoll = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterinfocoll)
                cbcamera.Items.Add(filterinfo.Name);
            cbcamera.SelectedIndex = 0;
            bttnstop.Enabled = false;
        }

        private void bttnstart_Click(object sender, EventArgs e)
        {
            vcdevice = new VideoCaptureDevice(filterinfocoll[cbcamera.SelectedIndex].MonikerString);
            vcdevice.NewFrame += vcdevice_NewFrame;

            try
            {
                vcdevice.Start();
                timer.Start();
                bttnstart.Enabled = false;
                bttnstop.Enabled = false;
            }
            catch (Exception)
            {
                vcdevice.Stop();
                MessageBox.Show("Error Found");
            }
        }

       private void vcdevice_NewFrame(object sender,AForge.Video.NewFrameEventArgs eventArgs)

        {
            pbImageScan.Image = (Bitmap)eventArgs.Frame.Clone();

        }//end of new framme

        private void timer_Tick(object sender, EventArgs e)

        {
            if (pbImageScan.Image != null && !bgworker.IsBusy)
                bgworker.RunWorkerAsync();
        }

        private void bttnstop_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                vcdevice.Stop();
                bttnstart.Enabled = true;
                bttnstop.Enabled = false;
            }
            catch(Exception)
            {
                vcdevice.Stop();
                MessageBox.Show("Error");
            }
        }

     
    }
}
