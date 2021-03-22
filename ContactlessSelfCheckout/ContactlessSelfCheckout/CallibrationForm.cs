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
            {
                VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
                {
                    comboBox1.Items.Add(VideoCaptureDevice.Name);
                }
                comboBox1.SelectedIndex = 0;
            }
        }

        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;

        private void btnRestart_Click(object sender, EventArgs e)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[0].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            imgCameraDisplay.Image = video;

        }

        private void CallibrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalVideo.IsRunning == true) 
            {
                FinalVideo.Stop();
            }
            Application.Exit(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinalVideo.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
