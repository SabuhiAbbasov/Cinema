using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public int price = 0;
        public List<Button> btns = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }
        int left = 50;
        int top = 100;
        int count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                if (i == 6)
                {
                    left = 50;
                    top = 150;
                }
                else if (i == 12)
                {
                    left = 50;
                    top = 200;
                }
                else if (i == 18)
                {
                    left = 50;
                    top = 250;
                }
                else if (i == 24) 
                {
                    left = 50;
                    top = 300;
                }
                
                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 30;
                btn.Left = left;
                btn.Top = top;
                btn.Text = count.ToString();
                Controls.Add(btn);
                left += 70;
                count++;

                btn.Click += new System.EventHandler(this.btn_Click);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSlateGray;
            price=0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button myBtn = sender as Button;
            myBtn.BackColor = Color.Red;
            btns.Add(myBtn);
            price += 6;
            foreach (var item in btns)
            {

                item.Click += new System.EventHandler(this.btnRepeatClick);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ($"Cəmi qiyməti: {price} $");
            foreach (var item in btns)
            {
                item.BackColor = Color.Green;
            }
        }

        private void btnRepeatClick(object sender, EventArgs e)
        {
            foreach (var item in btns)
            {
                label2.Text = "Bu yerlər artıq buron olunub: " + item.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            Form1 myDecel = new Form1(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
