using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Sample
    {
        //メンバ変数の定義ここから↓
        private int x;
        private int y;
        //メンバ変数の定義ここまで↑

        //メソッドの定義ここから↓
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void Set(int a, int b)
        {
            x = a;
            y = b;
        }
        //メソッドの定義ここまで
    }

    public class Complex
    {
        public double re;   //実部を記憶しておく（外部からの読み出し・書き換えも可能）
        public double im;   //虚部を記憶しておく（外部からの読み出し・書き換えも可能）
        public double Abs()
        {
            return System.Math.Sqrt(re * re + im * im);
        }
        [Test]
        public static void main()
        {   //mathが使えない
            Complex z;          //インスタンスを格納させるための変数を定義
            z = new Complex();  // new を使ってインスタンスを生成
            z.re =3;            //実部の値を変更
            z.im =4;            //虚部の値を変更
            double abs = z.Abs();// z の絶対値を取得

            UnityEngine.Debug.Log($"abs = {abs}\n");

            //int n =5;
            //string s="abcde";
            //int[] array = new int[]{1,2,3,4,5};
            //Complex z = new Complex();
        }
    }


}

