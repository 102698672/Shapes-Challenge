using System;
using System.Drawing;

namespace shapes_challenge
{
    public class Shape
    {
        public Color Colour;
    }

    public class Quadrilateral : Shape
    {
        public int GrossWeight;

        public Quadrilateral(int side1length, int side2length, int side3length, int side4length)
        {
            int s1 = side1length;
            int s2 = side2length;
            int s3 = side3length;
            int s4 = side4length;
        }

        public void GetPerimetre()
        {

        }
    }
}
 