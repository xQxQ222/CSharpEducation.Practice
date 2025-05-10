using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task6
{
    public static class PointExtension
    {
        public static double GetDistanceTo(this Point point1, Point point2) 
        {
            return Math.Sqrt(Math.Pow(point2.x - point1.x,2) + Math.Pow(point2.y - point1.y, 2));
        }
    }
}
