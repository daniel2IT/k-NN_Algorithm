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
        public double Amzius { get; set; }
        public string Zaidejas { get; set; }


        public Point2D(double x, double y, string @class, string @position, string @zaidejas)
        {
            X = x;
            Y = y;
            Class = @class;
            Pozicija = @position;
            Zaidejas = @zaidejas;
        }

        public Point2D(string @zaidejas, double x, double y, string @class, string @position, double @amzius)
        {
            X = x;
            Y = y;
            Class = @class;
            Pozicija = @position;
            Amzius = @amzius;
            Zaidejas = @zaidejas;
        }

        public double DistanceSquare(Point2D other, Form1 form, string sportoSaka)
        {

            var xx = X - other.X;
            var yy = Y - other.Y;


        
             //  form.listBox1.Items.Clear();
               //form.listBox3.Items.Clear();

                form.listBox1.Items.Add(Math.Sqrt(((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y))));
                form.listBox3.Items.Add("Math.Sqrt(((" + other.X + "-" + X + ") * (" + +other.X + "-" + X + ") + (" + other.Y + "- " + Y + ") * (" + other.Y + "-" + Y + ")))");


            return xx * xx + yy * yy;
        }


    }
}
