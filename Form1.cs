using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BannerLuminoso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        private void lbBenvindo_Click(object sender, EventArgs e)
        {

        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lbBenvindo.Location = new Point(40, 120);
                lbBenvindo.ForeColor = Color.Red;
                num++;
            }
            else if (num == 1)
            {
                lbBenvindo.Location = new Point(120, 367);
                lbBenvindo.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                lbBenvindo.Location = new Point(30, 250);
                lbBenvindo.ForeColor = Color.White;
                num = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
