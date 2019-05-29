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
        public Point(double x, double y)    //Point()コンストラクター newを用いてインスタンス作成時に実行される
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString() //ValueType.ToString()とのオーバーロード
        {
            return "(" + x + "," + y + ")";
        }
    }
    //-------------------------------------------------
    /// <summary>
    /// 2次元上の3点を表す構造体
    /// </summary>
    public class Triangle
    {
        public Point a;
        public Point b;
        public Point c;
        /// <summary>
        /// 3つの頂点の座標を与えて初期化
        /// </summary>
        /// <param name="a">頂点A</param>
        /// <param name="b">頂点B</param>
        /// <param name="c">頂点C</param>
        public Triangle(Point a, Point b, Point c)  //Triangle()←コンストラクター
        {                                         //newされた時に呼び出される関数
            this.a = a;
            this.b = b;
            this.c = c;
        }
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
    //--------------------------------------------------------
    class TestGetArea
    {
        static void Main()      //以下スーパー解説タイム
        {

            Triangle t;         //インスタンスを格納するための変数を定義
            Point a, b, c;
            a = new Point(0, 0);
            b = new Point(1919, 14);
            c = new Point(45, 11);
            t = new Triangle(a, b, c);
            //Triangle t;
            //t = new Triangle(new Point(0, 0), new Point(1919, 14), new Point(45, 11));
            //これは↑↑のように書き直せる
            //インスタンスを格納する変数a,b,c、インスタンスを格納する変数t
            //んでパッと見a,b,cが目で見えなくて、インスタンス格納する変数ドコー？って混乱してたのね
            //ILレベルだと変数見えるよー、C#では隠れるらしい
            //  https://sharplab.io/
            //にコード張り付ければ見えるんじゃないかな？

            Console.Write("{0}\n", t.GetArea());
            //そしてUnityTestRunner上ではビルドしてステップ実行はできないのかな？
        }
    }

}





