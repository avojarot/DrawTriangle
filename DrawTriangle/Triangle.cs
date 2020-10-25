using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawTriangle
{
    class Triangle
    {
        Point[] points;
       
        
        public Triangle(Point first, Point second, Point theard)
        {
            this.points = new Point[3] {first,second,theard};
        }

        public Bitmap Draw(Bitmap map)
        {
            Graphics graph = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Red);
            pen.Width += 2;
            graph.DrawPolygon(pen, points);
            return map;
        }
    }
}
