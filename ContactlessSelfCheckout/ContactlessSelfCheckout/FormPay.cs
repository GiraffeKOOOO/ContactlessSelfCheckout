using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormPay : Form
    {
        private readonly FormBasketList formBasketList;
        private decimal basketTotal;

        public FormPay(FormBasketList formBasketListRef)
        {
            formBasketList = formBasketListRef;
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            InitializeComponent();
            basketTotal = formBasketList.basketTotal;
        }

        public void TotalPaid()
        {
            LoadEnding();
        }

        private void LoadEnding()
        {
            string path = Application.StartupPath;
            string imagePath = Path.GetFullPath(Path.Combine(path, @"..\..\media\loading2.gif"));

            PictureBox loadingGif = new PictureBox
            {
                Width = 100,
                Height = 100,
                Image = Image.FromFile(imagePath),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(loadingGif);
            loadingGif.Left = 460;
            loadingGif.Top = 500;

            this.Hide();
            FormReceipt formReceipt = new FormReceipt();
            formReceipt.Show();
            formReceipt.Left = this.Left;
            formReceipt.Top = this.Top;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function hides the current form returning the user to the basket list
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
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

        private void BtnCash_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this, "Cash");
            formPaymentMethod.Show();
            formPaymentMethod.Left = this.Left;
            formPaymentMethod.Top = this.Top;
            this.Hide();
        }

        private void BtnCash_MouseEnter(object sender, EventArgs e)
        {
            btnCash.Image = Properties.Resources.cash_button_hover;
            btnCash.Refresh();
        }

        private void BtnCash_MouseLeave(object sender, EventArgs e)
        {
            btnCash.Image = Properties.Resources.cash_button;
            btnCash.Refresh();
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this, "Card");
            formPaymentMethod.Show();
            formPaymentMethod.Left = this.Left;
            formPaymentMethod.Top = this.Top;
            this.Hide();
        }

        private void BtnCard_MouseEnter(object sender, EventArgs e)
        {
            btnCard.Image = Properties.Resources.card_button_hover;
            btnCard.Refresh();
        }

        private void BtnCard_MouseLeave(object sender, EventArgs e)
        {
            btnCard.Image = Properties.Resources.card_button;
            btnCard.Refresh();
        }

        private void BtnCoupon_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this, "Coupon");
            formPaymentMethod.Show();
            formPaymentMethod.Left = this.Left;
            formPaymentMethod.Top = this.Top;
            this.Hide();
        }

        private void BtnCoupon_MouseEnter(object sender, EventArgs e)
        {
            btnCoupon.Image = Properties.Resources.coupon_button_hover;
            btnCoupon.Refresh();
        }

        private void BtnCoupon_MouseLeave(object sender, EventArgs e)
        {
            btnCoupon.Image = Properties.Resources.coupon_button;
            btnCoupon.Refresh();
        }

        private void FormPay_Load(object sender, EventArgs e)
        {
            lblTotalSum.Text = "£ " + basketTotal.ToString();
            lblTotalSum.Location = new Point ((pnlTitleBackground.Size.Width - lblTotalSum.Size.Width) / 2, lblTotal.Location.Y + lblTotal.Size.Height + 10);
            Console.WriteLine(pnlTitleBackground.Size.Width);
            Console.WriteLine(lblTotalSum.Size.Width);
            Console.WriteLine(pnlTitleBackground.Size.Width - lblTotalSum.Size.Width);
            Console.WriteLine((pnlTitleBackground.Size.Width - lblTotalSum.Size.Width) / 2);
        }

        private void FormPay_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
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
        
    }
}
