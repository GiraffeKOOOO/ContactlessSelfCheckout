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

        /// <summary>
        /// This is the constructor form, which takes the basket list form as a reference variable, to be able to maintain state through out the program
        /// </summary>
        /// <param name="formBasketListRef">FormBasketList object that gets passed in to allow for reading of the total from the basket list form</param>
        public FormPay(FormBasketList formBasketListRef)
        {
            formBasketList = formBasketListRef;
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            InitializeComponent();
            basketTotal = formBasketList.basketTotal;
        }

        /// <summary>
        /// This function gets called from the payment method form when the override button is pressed
        /// This runs the ending for this program
        /// </summary>
        public void TotalPaid()
        {
            LoadEnding();
        }

        /// <summary>
        /// This function creates an animation before moving on to the receipt form.
        /// </summary>
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

        /// <summary>
        /// This function hides the current form returning the user to the basket list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
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

        /// <summary>
        /// This function creates a new object for the FormHelp, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
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

        /// <summary>
        /// This function creates a new object for the FormPaymentMethod and passing in the chosen method of payment, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function creates a new object for the FormPaymentMethod and passing in the chosen method of payment, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function creates a new object for the FormPaymentMethod and passing in the chosen method of payment, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function is called when the mouse is clicked, this function shows a little animation of the hand cursor being grasped by simply changing the image and changing it back
        /// </summary>
        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        /// <summary>
        /// This function is used for closing the kinect sensor mouse control application when the form is closed
        /// </summary>
        /// <param name="name">String variable for identifying the process to be terminated</param>
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
