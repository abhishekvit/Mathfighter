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
    public partial class Form3 : Form
    {
        int d;
        int c;
        int t4;
        private int l1;
        private int b1;
        private int l2;
        private int b2;
        private int l3;
        private int b3;
        private int _x;
        private int _y;
        private int a;
        private int b;
        private Position _objPosition;
        string str;
        enum Position
        {
            Left, Right, Up, Down
        }
        private string nm;
        public string passvalue
        {
            get { return nm; }
            set { nm = value; }
            
        }
        public Form3()
        {
            _x = 80;
            _y = 480;
            l1 = 80;
            b1 = 80;
            l2 = 150;
            b2 = 80;
            l3 = 220;
            b3 = 80;
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            str = nm;
            c = Convert.ToInt16(nm);
        }
        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            
            label1.Text = a.ToString() + "X" + b.ToString() + "X" + a.ToString();
            int p = a * b * a;
            label2.Text = p.ToString();
            label3.Text = (p + 8).ToString();
            label4.Text = (p + 3).ToString();

            // e.Graphics.FillEllipse(Brushes.Black, _x, _y, 20, 20);
            e.Graphics.DrawImage(new Bitmap("csi.png"), _x, _y);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                _objPosition = Position.Left;
            else if (e.KeyCode == Keys.Right)
                _objPosition = Position.Right;
            else if (e.KeyCode == Keys.Up)
                _objPosition = Position.Up;
            //else if (e.KeyCode == Keys.Down)
            // _objPosition = Position.Down;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

          //  MessageBox.Show(_x.ToString());
       //     MessageBox.Show(_y.ToString());
       //    // MessageBox.Show(_x.ToString());
            if (_objPosition == Position.Right)
            {
                _x += 70;
                _objPosition = Position.Up;
                // Up();
            }
            if (_objPosition == Position.Left)
            {
                _x -= 70;
                _objPosition = Position.Up;
                // Up();
            }

            if (_objPosition == Position.Up)
                // if (_x > 55 && _x < 235 && _y < 80)
                // {
                _y -= 10;
            // }
            //if (_objPosition == Position.Down)
            //_y += 10;
            if (_x < 80)
            {
                //timer1.Stop();
                _x = 90;
                // timer1.Start();

            }
            if (_x > 230)
            {
                //timer1.Stop();
                _x = 220;
                // timer1.Start();

            }




            if (_y == 70)
            {
                // MessageBox.Show(_x.ToString());
               

                    if (_x == 90)
                    {
                        this.Hide();
                        Form4 f4 = new Form4();
                        f4.ShowDialog();

                    }
                    else
                    {
                        // MessageBox.Show(_x.ToString());
                        //this.Close();
                        timer1.Stop();
                        MessageBox.Show("GAME OVER");
                        this.Hide();
                        Form1 f4 = new Form1();
                        f4.ShowDialog();
                        MessageBox.Show(c.ToString());
                        //this.Close();
                    }

                }
                
            
            Invalidate();


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            a = r.Next(0, 50);
            b = r.Next(0, 20);

            t4 = r.Next(2, 4);
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
