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

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        private void FormPay_Click(object sender, EventArgs e)
        {
            CursorAnimate();
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

        private void FormPay_Load(object sender, EventArgs e)
        {
            lblTotalSum.Text = "£ " + basketTotal.ToString();
            lblToPaySum.Text = "£ " + basketTotal.ToString();
            lblToPay.ForeColor = Color.Red;
            lblToPaySum.ForeColor = Color.Red;
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

        private void BtnCash_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this, "Cash");
            formPaymentMethod.Show();
            formPaymentMethod.Left = this.Left;
            formPaymentMethod.Top = this.Top;
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this, "Card");
            formPaymentMethod.Show();
            formPaymentMethod.Left = this.Left;
            formPaymentMethod.Top = this.Top;
        }

        private void BtnCoupon_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this, "Coupon");
            formPaymentMethod.Show();
            formPaymentMethod.Left = this.Left;
            formPaymentMethod.Top = this.Top;
        }

        public void TotalPaid() 
        {
            lblToPay.ForeColor = Color.Green;
            lblToPaySum.ForeColor = Color.Green;
            lblToPaySum.Text = "£ 0";
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
            FormEnding formEnding = new FormEnding();
            formEnding.Show();
            formEnding.Left = this.Left;
            formEnding.Top = this.Top;

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
        private void FormPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }
    }
}
