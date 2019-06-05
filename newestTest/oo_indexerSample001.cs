using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// 添字の下限と上限を指定できる配列
    /// </summary>
    class BoundArray
    {
        int[] array;        //変数宣言？
        int llower;  //配列添字の下限   変数宣言？

        public BoundArray(int lower,int upper)  //コンストラクタ newされたときに呼び出される
        {                           //インスタンスの初期化用のコード
            this.llower = lower;
            array = new int[upper - lower + 1];
        }

        public int this[int i]
        {
            set { this.array[i - llower] = value; }
            get { return this.array[i - llower]; }
        }
       
    }
 class Program
    {
        static void Main()
        {
            BoundArray a = new BoundArray(1, 9);
            for (int i = 1; i <= 9; ++i)
                a[i] = i;   //シンタックスシュガー？
            for(int i = 1; i <= 9; ++i)
            {
                System.Console.Write("a[{0}] = {1}\n", i, a[i]);
            }
        }
    }
}
