using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void WriteMe(out int x) {
            x = 1;
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            byte op1 = 1;
            sbyte op2 = -1;
            var result = op1 & op2;
 
            TextBoxOutput.Text += result.GetType().Name;

        }


    }

    enum Colors1 { 
    B = 1,
    R,
    Y=4,
    P = B | R,
    G = Y | B,
    O = R | Y
    }
 
}
