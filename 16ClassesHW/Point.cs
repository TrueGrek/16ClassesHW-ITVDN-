using System;
using System.Collections.Generic;
using System.Text;

namespace _16ClassesHW
{
    class Point
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get
            {
                return x;
            }
            set { }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set { }
        }
        public int Z
        {
            get
            {
                return z;
            }
            set { }
        }

        public Point(){}
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
    }
}
