using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangle
{
    public partial class V1 : Form
    {
        
        public V1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point first = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
            Point second = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            Point theard = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            Triangle t = new Triangle(first,second,theard);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = t.Draw(bmp);
        }
    }
}
