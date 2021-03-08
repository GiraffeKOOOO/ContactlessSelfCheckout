using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactlessSelfCheckout
{
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            InitializeComponent();
            Console.WriteLine("hello world");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start button pressed");
        }

        private void ownBagButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Own bag button pressed");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Help button pressed");
        }
    }
}
