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
    public partial class Form2 : Form
    {
        int c = 0;
        // MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=mukabhisrk;database=login");
        int t4;//random number for option
        private int l1;//parameters of lenghth and breadth of the pipes
        private int b1;
        private int l2;
        private int b2;
        private int l3;
        private int b3;
        private int _x;//x position(pixel) for the car 
        private int _y;//y position(pixel) for the car
        private int a;//values of the question
        private int b;
        private Position _objPosition;
        enum Position//enum defined for the the movement of the car
        {
            Left, Right, Up, Down
        }
        public Form2()//constructor
        {
            _x = 80;//initial definitions of the above parameters
            _y = 480;
            l1 = 80;
            b1 = 80;
            l2 = 150;
            b2 = 80;
            l3 = 220;
            b3 = 80;
            InitializeComponent();
            _objPosition = Position.Up;//movement of the car

            
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = a.ToString() + "X" + b.ToString();
            if (t4 == 2)//cheking the option of the right option placement
            {
                label2.Text = (a * b).ToString();
                label3.Text = (a * b - 10).ToString();
                label4.Text = (a * b + 15).ToString();
            }
            if (t4 == 3)
            {
                label3.Text = (a * b).ToString();
                label2.Text = (a * b - 11).ToString();
                label4.Text = (a * b + 13).ToString();
            }
            if (t4 == 4)
            {
                label4.Text = (a * b).ToString();
                label3.Text = (a * b - 19).ToString();
                label2.Text = (a * b + 14).ToString();
            }

            // e.Graphics.FillEllipse(Brushes.Black, _x, _y, 20, 20);
            e.Graphics.DrawImage(new Bitmap("csi.png"), _x, _y);
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
         //   MessageBox.Show(_x.ToString());
         //   MessageBox.Show(_y.ToString());
            if (_objPosition == Position.Right)//right movement function
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
            if (_x < 60)
            {
                //timer1.Stop();
                _x = 70;
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
                if (t4 == 2)
                {
                   

                    if (_x==80)
                    {
                        //int c=Convert.ToInt32("select score from login.login");
                      c++;
                       // c.ToString;
                        this.Hide();
                        Form3 f4 = new Form3();
                        f4.passvalue = c.ToString(); 
                        f4.ShowDialog();
                    //    c++;
                       
                    }
                    else
                    {
                       // MessageBox.Show(_x.ToString());
                        //this.Close();
                        timer1.Stop();
                        MessageBox.Show("GAME OVER");
                        MessageBox.Show("YOUR SCORE IS " + c.ToString());
                        this.Hide();
                        Form1 f4 = new Form1();
                        f4.ShowDialog();
                        //this.Close();
                    }

                }
                if (t4 == 3)
                {
                    if (_x ==150)
                    {
                        c++;
                        this.Hide();
                        Form3 f4 = new Form3();
                        f4.passvalue = c.ToString(); 
                        f4.ShowDialog();
                        
                    }
                    else
                    {timer1.Stop();
                        MessageBox.Show("GAME OVER");
                        MessageBox.Show("YOUR SCORE IS " + c.ToString());
                        this.Hide();
                        Form1 f4 = new Form1();
                        f4.ShowDialog();
                        //this.Close();
                    }
                }
                if (t4 == 4)
                {
                  //  MessageBox.Show(_x.ToString());
                    if (_x==220)
                    {
                        c++;
                        this.Hide();
                        Form3 f4 = new Form3();
                        f4.passvalue = c.ToString(); 
                        f4.ShowDialog();
                      //  c++;
                    }
                    else
                    {
                       // MessageBox.Show(_x.ToString());
                        timer1.Stop();
                        MessageBox.Show("GAME OVER");
                        MessageBox.Show("YOUR SCORE IS " + c.ToString());
                        this.Hide();
                        Form1 f4 = new Form1();
                        f4.ShowDialog();
                        
                        // this.Close();
                    }
                }

            }
            Invalidate();
            

        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            a = r.Next(0, 20);
            b = r.Next(0, 20);

            t4 = r.Next(2, 4);
            timer2.Stop();
            //int c="
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
