using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormPaymentMethod : Form
    {
        private readonly FormPay formPay;
        public FormPaymentMethod(FormPay formPayRef, string paymentMethod)
        {
            formPay = formPayRef;
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            ChangeLblTitle(paymentMethod);
            ChangeLblInstruction(paymentMethod);
        }

        private void ChangeLblTitle(string paymentMethod) 
        {
            lblFormTitle.Text = paymentMethod + " payment";
            lblFormTitle.AutoSize = false;
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblFormTitle.Dock = DockStyle.None;
        }
        private void ChangeLblInstruction(string paymentMethod)
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            formPay.Show();
            formPay.Left = this.Left;
            formPay.Top = this.Top;
            this.Hide();
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.back_button_hover;
            btnBack.Refresh();
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.back_button;
            btnBack.Refresh();
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

        private void BtnDone_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            this.Hide();
            formPay.TotalPaid();
        }

        private void FormPaymentMethod_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormPaymentMethod_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPay.Show();
            formPay.Left = this.Left;
            formPay.Top = this.Top;
            this.Hide();
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }
        
    }
}
