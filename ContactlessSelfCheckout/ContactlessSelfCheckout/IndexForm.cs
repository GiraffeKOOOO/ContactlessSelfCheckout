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
    public partial class IndexForm : Form
    {
        string path = @"C:\Users\pstep\Desktop\test.txt";
        public IndexForm()
        {
            InitializeComponent();
            Console.WriteLine("hello world");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("p");
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello my name is Jeff");
                    sw.WriteLine("Homer SImpson");
                }
            }
            else {
                using (StreamReader sr = File.OpenText(path)) {
                    string fileInput;
                    while ( (fileInput = sr.ReadLine()) != null ) {
                        Console.WriteLine(fileInput);
                    }
                }
            }
        }
    }
}
