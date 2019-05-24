//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{

    /// <summary>
    ///  2次元の点を表す構造体
    /// </summary>
    public struct Point
    {
        public double x;    // x 座標
        public double y;    // y 座標

        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }

    /// <summary>
    /// 2次元上の3点を表す構造体
    /// </summary>
    public struct Triangle
    {
        public Point a;
        public Point b;
        public Point c;
        
    }

    /// <summary>
    /// 三角形の面積を求める。
    /// </summary>
    /// <returns>面積</returns>

    public double GetArea()
    { }
    class StructSample
    {
        static void Main()
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.x = 100;
            p1.y = 0;

            p2.x = 400;
            p2.y = 400;

            Console.Write("{0}と{1}の間の距離は{2}", p1, p2, Distance(p1, p2));
        }

        /// <summary>
        /// 2点間の距離を求める
        /// </summary>

        static double Distance(Point p1, Point p2)
        {
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

       

        


}





