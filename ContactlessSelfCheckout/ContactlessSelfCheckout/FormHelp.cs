using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormHelp : Form
    {
        private readonly string switchFormTitle;
        public FormHelp(string formTitle)
        {
            InitializeComponent();
            // override the class string variable for the switch from the previous screen
            switchFormTitle = formTitle;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // switch for returning to the previous screen, takes in the string variable from the screen on which the help button was called, and uses the string as the cases
            switch (switchFormTitle) 
            {
                case "Start":
                    FormStartScreen formStartScreen = new FormStartScreen();
                    formStartScreen.Show();
                    this.Hide();
                    break;
                case "OwnBag":
                    FormOwnBag formOwnBag = new FormOwnBag();
                    formOwnBag.Show();
                    this.Hide();
                    break;
                case "BasketList":
                    FormBasketList formBasketList = new FormBasketList();
                    formBasketList.Show();
                    this.Hide();
                    break;
                case "Vegetables":
                    FormVegetables formVegetables= new FormVegetables();
                    formVegetables.Show();
                    this.Hide();
                    break;
                default:
                    Console.Write("No screen title provided");
                    break;
            }
        }
    }
}
