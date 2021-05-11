using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ContactlessSelfCheckout
{
    public partial class FormCallibration : Form
    {
        private KinectSensor mySensor = null;
        private MultiSourceFrameReader myReader = null;

        public FormCallibration()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");

            if (!IsProcessOpen("KinectV2MouseControl"))
            {
                try
                {
                    Process kinectMouseControls = new Process();
                    kinectMouseControls.StartInfo.FileName = @"G:\VisualStudioRepos\kinectv2mousecontrol\src\KinectV2MouseControl\bin\Debug\KinectV2MouseControl.exe";
                    //kinectMouseControls.StartInfo.FileName = @"E:\VisualStudioRepos\kinectv2mousecontrol\src\KinectV2MouseControl\bin\Debug\KinectV2MouseControl.exe";
                    kinectMouseControls.Start();
                }
                catch (Exception kinectMouseControlNotFound)
                {
                    Console.WriteLine(kinectMouseControlNotFound.Message);
                    NoKinectControls();
                }
                
            }
        }

        private void NoKinectControls() 
        {
            /*
            // hide the current titles and labels
            lblScreenTitle.Visible = false;

            lblInstruction1.Visible = false;
            lblInstructions5.Visible = false;
            /*

            // add a panel, error title, and 2 error descriptions
            /*
            pnlErrorBackground.Visible = true;
            lblErrorMessage1.Visible = true;
            lblErrorMessage2.Visible = true;
            */
        }

        private bool IsProcessOpen(string name)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void CloseProcess(string name)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(name))
                {
                    process.Kill();
                }
            }
        }

        private void FormCallibration_Load(object sender, EventArgs e)
        {
            mySensor = KinectSensor.GetDefault();

            if (mySensor != null)
            {
                mySensor.Open();
            }
            else
            {
                Console.WriteLine("no kinect found");
            }

            myReader = mySensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color);
            myReader.MultiSourceFrameArrived += MyReader_MultiSourceFrameArrived;
        }

        private void MyReader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            var reference = e.FrameReference.AcquireFrame();

            using (var frame = reference.ColorFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    var width = frame.FrameDescription.Width;
                    var height = frame.FrameDescription.Height;
                    var data = new byte[width * height * 32 / 8];
                    frame.CopyConvertedFrameDataToArray(data, ColorImageFormat.Bgra);

                    var bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);

                    Marshal.Copy(data, 0, bitmapData.Scan0, data.Length);
                    bitmap.UnlockBits(bitmapData);
                    imgCameraDisplay.Image = bitmap;
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            CursorAnimate();

            mySensor.Close();
            myReader.Dispose();

            // This function creates a new object for the FormBasketList, hides the current form, and shows the new form
            FormStartScreen formStartScreen = new FormStartScreen();
            formStartScreen.Show();
            formStartScreen.Left = this.Left;
            formStartScreen.Top = this.Top;
            this.Hide();
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.start_button_hover;
            btnStart.Refresh();
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.start_button;
            btnStart.Refresh();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
        }

        private void BtnHelp_MouseEnter(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.help_button_hover;
            btnHelp.Refresh();
        }

        private void BtnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.help_button;
            btnHelp.Refresh();
        }

        private void FormCallibration_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormCallibration_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

    }
}
