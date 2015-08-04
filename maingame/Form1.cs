using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maingame
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)//timer class
        {c++;
        if (c == 100)//end of rcursive call
        {
            timer1.Stop();
            this.Hide();//hide this class
            Form2 f2 = new Form2();//creation on new object of next class(level)
            f2.ShowDialog();
        }

        }
    }
}
