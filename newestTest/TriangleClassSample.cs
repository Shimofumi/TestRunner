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
    public class Triangle
    {
        public Point a;
        public Point b;
        public Point c;

        /// <summary>
        /// 三角形の面積を求める。
        /// </summary>
        /// <returns>面積</returns>

            ///原点と直線の距離（原点と直線ABの垂線は高さであり、直線ABはb(x1,y1),c(x2,y2)を通るとする的な奴）
        public double GetArea()
        {
            double abx, aby, acx, acy;
            abx = b.x - a.x;
            aby = b.y - a.y;
            acx = c.x - a.x;
            acy = c.y - a.y;

            return 0.5 * Math.Abs(abx * acy - aby * acx);
        }
    }

    class TestGetArea
    {
        static void Main()
        {
           
            Triangle t;         //インスタンスを格納するための変数を定義
            t = new Triangle(); //new キーワードでインスタンスを作成して、用意した変数に格納する
            t.a.x = 0;
            t.a.y = 0;
            t.b.x = 1919;
            t.b.y = 14;
            t.c.x = 45;
            t.c.y = 11;
            Console.Write("{0}\n", t.GetArea());

        }
    }

    class StructSample
    {
        static void Main3777()//ここの名前クソ（直球）なので変えるべき
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
}





