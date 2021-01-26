using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Neighbors
{
    public class Point2D
    {

        public double X { get; set; }
        public double Y { get; set; }
        public string Class { get; set; }

        public Point2D(double x, double y, string @class)
        {
            X = x;
            Y = y;
            Class = @class;
        }

        public double DistanceSquare(Point2D other, Form1 form)
        {
            var xx = X - other.X;
            var yy = Y - other.Y;


            if(other.X == 1)
            {
                form.listBox1.Items.Add(Math.Sqrt(((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y))));
                form.listBox3.Items.Add("Math.Sqrt(((" + other.X + "-" + X + ") * (" + +other.X + "-" + X + ") + (" + other.Y + "- " + Y + ") * (" + other.Y + "-" + Y + ")))");
            }
            else
            {
             
                form.listBox2.Items.Add(Math.Sqrt(((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y))));
                form.listBox5.Items.Add("Math.Sqrt(((" + other.X + "-" + X + ") * (" + +other.X + "-" + X + ") + (" + other.Y + "- " + Y + ") * (" + other.Y + "-" + Y + ")))");
            }
          


            return xx * xx + yy * yy;
        }


    }
}
