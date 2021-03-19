using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ContactlessSelfCheckout
{
    public partial class CallibrationForm : Form
    {
        public CallibrationForm()
        {
            InitializeComponent();
        }

         private FilterInfoCollection CaptureDevices;
         private VideoCaptureDevice videoSource;

        private void CallibrationForm_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices) 
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraDisplayBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CallibrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning == true) 
            {
                videoSource.Stop();
            }
            Application.Exit(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
        }
    }
}
