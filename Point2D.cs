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
        public string Class { get; set; } // Sporto Saka 

        public string Pozicija { get; set; }
        public string Idd { get; set; }


        public Point2D(double x, double y, string @class, string @position)
        {
            X = x;
            Y = y;
            Class = @class;
            Pozicija = @position;
        }

        public Point2D(string @Id, double x, double y, string @class, string @position)
        {
            X = x;
            Y = y;
            Class = @class;
            Pozicija = @position;
            Idd = @Id;
        }

        public double DistanceSquare(Point2D other, Form1 form, string sportoSaka)
        {

            var xx = X - other.X;
            var yy = Y - other.Y;


            if(other.X == 185)
            {
             //  form.listBox1.Items.Clear();
               //form.listBox3.Items.Clear();

                form.listBox1.Items.Add(Math.Sqrt(((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y))));
                form.listBox3.Items.Add("Math.Sqrt(((" + other.X + "-" + X + ") * (" + +other.X + "-" + X + ") + (" + other.Y + "- " + Y + ") * (" + other.Y + "-" + Y + ")))");
            }
            else 
            {
               // form.listBox2.Items.Clear();
               // form.listBox5.Items.Clear();

                form.listBox2.Items.Add(Math.Sqrt(((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y))));
                form.listBox3.Items.Add("Math.Sqrt(((" + other.X + "-" + X + ") * (" + +other.X + "-" + X + ") + (" + other.Y + "- " + Y + ") * (" + other.Y + "-" + Y + ")))");
            }

            return xx * xx + yy * yy;
        }


    }
}
