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


namespace ContactTracingApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice devicecapture;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cbcamera.Items.Add(device.Name);
            cbcamera.SelectedIndex = 0;
        }

        private void bttnstart_Click(object sender, EventArgs e)
        {
            devicecapture = new VideoCaptureDevice(filterInfoCollection[cbcamera.SelectedIndex].MonikerString);
            devicecapture.NewFrame += devicecapture_NewFrame;
            devicecapture.Start();

        }

        private void devicecapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            pbImageScan.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (pbImageScan.Image != null)

            {

            }
        }//end of timer

     
    }
}
