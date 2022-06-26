using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekolayzerbarlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        Random rand= new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height = rand.Next(150);
            panel2.Height = rand.Next(150);
            panel3.Height = rand.Next(150);
            panel4.Height = rand.Next(150);
            panel5.Height = rand.Next(150);
            panel6.Height = rand.Next(150);
            panel7.Height = rand.Next(150);
            panel8.Height = rand.Next(150);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Black;
            

        }
    }
}
