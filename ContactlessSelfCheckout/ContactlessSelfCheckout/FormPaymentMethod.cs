using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormPaymentMethod : Form
    {
        private readonly FormPay parent;
        public FormPaymentMethod(FormPay _parent, string paymentMethod)
        {
            parent = _parent;
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            ChangeLblTitle(paymentMethod);
            ChangeInstruction(paymentMethod);
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        private void ChangeLblTitle(string paymentMethod) 
        {
            lblFormTitle.Text = paymentMethod + " payment";
            lblFormTitle.AutoSize = false;
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblFormTitle.Dock = DockStyle.None;
        }
        private void ChangeInstruction(string paymentMethod)
        {
            string path = Application.StartupPath;

            switch (paymentMethod)
            {
                case "Cash":
                    lblInstruction.Text = "Please insert notes and coins in to the correct slot";
                    string cashPath = Path.GetFullPath(Path.Combine(path, @"..\..\media\cash.png"));
                    imgPaymentType.Image = Image.FromFile(cashPath);
                    break;
                case "Card":
                    lblInstruction.Text = "Please insert the card in to the card reader and follow the instructions on the card reader";
                    string cardPath = Path.GetFullPath(Path.Combine(path, @"..\..\media\card.png"));
                    imgPaymentType.Image = Image.FromFile(cardPath);
                    break;
                case "Coupon":
                    lblInstruction.Text = "Please scan the coupon using the scanner below";
                    string couponPath = Path.GetFullPath(Path.Combine(path, @"..\..\media\coupon.png"));
                    imgPaymentType.Image = Image.FromFile(couponPath);
                    break;
                default:
                    lblInstruction.Text = "No method selected";
                    break;
            }
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            this.Hide();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            this.Hide();
            parent.TotalPaid();
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
        private void FormPaymentMethod_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }
    }
}
