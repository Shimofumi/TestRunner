using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// jagged array を使った行列
    /// rectangular array のように[i, j]という添字で要素の読み書きが可能
    /// </summary>
    /// rectangular 長方形の
    class Matrix
    {
        int[][] array;  //実装は隠蔽したい

        public Matrix(int rows, int cols)       //コンストラクタ
        {
            this.array = new int[rows][];       //配列の実態を用意
            for(int i=0; i<rows; ++i)
            {
                this.array[i] = new int[cols];  //
            }
        }

        public int this[int i, int j]           //プロパティインデクサー 複数も可能
        {
            set { this.array[i][j] = value; }       //set 値の変更時に
            get { return this.array[i][j]; }        //get 値の取得時に
        }
    }
    class IndexerSample
    {
        static void Main()
        {
            Matrix a = new Matrix(4, 4);    //このnewは？　インスタンスを格納する変数aとインスタンスの作成初期化のnew

            for(int i = 0; i < 4; ++i)
            {
                for(int j = 0; j < 4; ++j)
                {
                    a[i, j] = (i + 1) * (j + 3);    //iが半固定値でループして+1されまたループして,
                }
            }

            for(int i = 0; i < 4; ++i)
            {
                for(int j = 0; j < 4; ++j)
                {
                    Console.Write("{0,4}", a[i, j]);
                    
                }
                Console.Write("\n");
            }
            

            
        }
    }
}
