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
            int windowWidth = this.ClientRectangle.Width;
            int windowHeight = this.ClientRectangle.Height;

            // hiding the next button and making the greyed out button visible
            btnNext.Visible = false;
            btnNextGrey.Visible = true;

            // creating the black panel for the error background
            Panel pnlErrorBackground = new Panel
            {
                Size = new Size(windowWidth - 50, 400),
                Name = "pnlErrorBackground",
                BackColor = Color.Black,
                TabIndex = 21
            };
            pnlErrorBackground.Location = new Point((windowWidth - pnlErrorBackground.Size.Width) / 2, (windowHeight - pnlErrorBackground.Height) / 2);
            Controls.Add(pnlErrorBackground);
            pnlErrorBackground.BringToFront();

            // creating the error title label
            Label lblErrorTitle = new Label
            {
                Name = "lblErrorTitle",
                Text = "Error",
                ForeColor = Color.Red,
                BackColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 60),
                AutoSize = true
            };
            lblErrorTitle.Location = new Point((pnlErrorBackground.Location.X + (pnlErrorBackground.Size.Width/2) - (lblErrorTitle.Size.Width / 2)) - 50, pnlErrorBackground.Location.Y);
            Controls.Add(lblErrorTitle);
            lblErrorTitle.BringToFront();

            // creating the error instruction 1st line label
            Label lblErrorInstruction1 = new Label
            {
                Name = "lblErrorInstruction1",
                Text = "Kinect Mouse Control Software was not found.",
                ForeColor = Color.Red,
                BackColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 25),
                AutoSize = true
            };
            lblErrorInstruction1.Location = new Point(pnlErrorBackground.Location.X + 126, (pnlErrorBackground.Location.Y + lblErrorTitle.Size.Height));
            Controls.Add(lblErrorInstruction1);
            lblErrorInstruction1.BringToFront();

            // creating the error instruction 2nd line label
            Label lblErrorInstruction2 = new Label
            {
                Name = "lblErrorInstruction2",
                Text = "Please make sure Kinect Mouse Control Software is installed",
                ForeColor = Color.Red,
                BackColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 25),
                AutoSize = true
            };
            lblErrorInstruction2.Location = new Point(pnlErrorBackground.Location.X + 11, (lblErrorInstruction1.Location.Y + lblErrorInstruction1.Size.Height + 10));
            Controls.Add(lblErrorInstruction2);
            lblErrorInstruction2.BringToFront();

            // creating the error instruction 3rd line label
            Label lblErrorInstruction3 = new Label
            {
                Name = "lblErrorInstruction3",
                Text = "on this machine, and the correct path to the software is",
                ForeColor = Color.Red,
                BackColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 25),
                AutoSize = true
            };
            lblErrorInstruction3.Location = new Point(pnlErrorBackground.Location.X + 60, (lblErrorInstruction2.Location.Y + lblErrorInstruction2.Size.Height + 10));
            Controls.Add(lblErrorInstruction3);
            lblErrorInstruction3.BringToFront();

            // creating the error instruction 4th line label
            Label lblErrorInstruction4 = new Label
            {
                Name = "lblErrorInstruction4",
                Text = "specified in this program, then restart this application.",
                ForeColor = Color.Red,
                BackColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 25),
                AutoSize = true
            };
            lblErrorInstruction4.Location = new Point(pnlErrorBackground.Location.X + 75, (lblErrorInstruction3.Location.Y + lblErrorInstruction3.Size.Height + 10));
            Controls.Add(lblErrorInstruction4);
            lblErrorInstruction4.BringToFront();
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

        private void BtnNext_Click(object sender, EventArgs e)
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

        private void BtnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.Image = Properties.Resources.next_button_hover;
            btnNext.Refresh();
        }

        private void BtnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.Image = Properties.Resources.next_button;
            btnNext.Refresh();
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
