//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{

    public class Complex
    {
        public double re;
        public double im;

        //絶対値を返す
        public double Abs()

        {
            return System.Math.Sqrt(re * re + im * im);

        }
        //文字列化する
        public override string ToString()
        {
            if (im > 0)
                return re.ToString() + "+i" + im.ToString();
            if (im < 0)
                return re.ToString() + "-1" + (-im).ToString();
            return re.ToString();
        }
    }
 //------------------------------------------------------------------------
        class ClassSample
        {
            
            static void Main()
            {
                Complex z = new Complex();
                z.re = GetDouble("実部を入力してください：");
                z.im = GetDouble("虚部を入力してください：");
                System.Console.Write(
                    "|{0}|=|{1}|", z, z.Abs());
            }
            public static double GetDouble(string message)
            {
                double x;
                while (true)
                {
                    try
                    {
                        //入力を促すメッセージを表示して、値を入力してもらう
                        System.Console.Write(message);
                        x = double.Parse(System.Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        System.Console.Write(
                            "ooops : 正しい値が入力されませんでした\n入力しなおして\n"
                        );
                        continue;
                    }
                    break;
                }
                return x;
            }
        }

    }



