using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Complex
    {
        //実装は外部から隠蔽しておく
        private double re;  //実部
        private double im;  //虚部

        //実部を取り出す
        public double Re() { return this.re; }

        //実部を書き換え
        public void Re(double x) { this.re = x; }

        //虚部を取り出す
        public double Im() { return this.im; }

        //虚部を書き換え
        public void Im(double y) { this.im = y; }

        //絶対値を取り出す
        public double Abs()
        {
            return Math.Sqrt(re * re + im * im);    //Math.Sqrtは平方根を求める
        }

    }
    //-------------------------------------------------------
    class ConcealSample
    {
        static void Main()
        {
            Complex c = new Complex();
            c.Re(4);
            c.Im(3);
            Console.Write("|c| = {0}", c.Abs());
        }
    }

}
