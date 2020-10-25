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
    public partial class V2 : Form
    {
        private object current = null;
        Triangle t;
        public V2()
        {
            InitializeComponent();
            REdraw();


        }

        private void V2_MouseMove(object sender, MouseEventArgs e)
        {
            if (current != null)
            {
                current.GetType()
                     .GetProperty("Location")
                     .SetValue(current, new Point(Cursor.Position.X-100, Cursor.Position.Y-100));
                REdraw();
            }
          

        }

        private void Tr_3_MouseDown(object sender, MouseEventArgs e)
        {
            current = sender;
           
            
           
        }
        private void REdraw()
        {
            t = new Triangle(button1.Location, button2.Location, button3.Location);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = t.Draw(bmp);
        }

        private void Tr_3_MouseUp(object sender, MouseEventArgs e)
        {
            current = null;
           
        }

       
    }
}
