using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        //さまざまなラーメンの情報をプログラムで管理し、それを文字列にして表示したくなりました。
        //ラメーンの情報の追加削除検索がほしくなりそう、配列だと追加は簡単、削除はモニョる、検索はたぶん無理ゾ
        //まずをラーメンclassを作成だとNullReferenceException : Object reference not set to an instance of an object
        //ぬる参照例外　：　オブイェクト　参照　not set to an instance(インスタンス、実体) of an object
        //つまりこのエラー文だけではﾅﾆﾓﾜｶﾗﾅｲ    FillRamenDetail()とShow()でNullReferenceExceptionがあるらしい
        //クラスのインスタンス作ってないという事と、構造体の配列作ってほにゃほにゃする事とかで混乱中
        //（当然のように構造体ならセーフ）
        //は？調べるけど聞いたほうが早そう
        public struct Ramen //structならｾｰﾌというかヒューマンの時と全く同じなんだよなあ...
        {
            public int Price;  //型これでよいか
            public double Calorie, Sodium;
            public string Name;

        }


        // [Test]
        public Ramen[] CreateRamenArray()
        {//class時はここ配列の長さ短くするミスで、Method has non-void return value, but no result is expectedってなってた
         //いや特に意味もなく[Test]を置いていたからだと思う？
         //[Test]コメントアウトで普通にSystem.IndexOutOfRangeException : Index was outside the bounds of the array.だ大丈夫
            return new Ramen[6];
        }
        public void FillRamenDetail(Ramen[] answer)
        {//語彙ェ...
         //Name "***"(string), Calorie **.*kcal(double), Price ***円(int), Sodium **.*g(double)でゆっくり増やしていってね
            answer[0].Name = "SoySauce";         //Null参照例外     
            answer[0].Calorie = 334;
            answer[0].Price = 810;
            answer[0].Sodium = 2.5;
            answer[1].Name = "Salt";
            answer[1].Calorie = 398;
            answer[1].Price = 893;
            answer[1].Sodium = 3.777;
            answer[2].Name = "Tsukemen";
            answer[2].Calorie = 377;
            answer[2].Price = 801;
            answer[2].Sodium = 4.2;
            answer[3].Name = "Rameeen";
            answer[3].Calorie = 364;
            answer[3].Price = 890;
            answer[3].Sodium = 0.16;
            answer[4].Name = "Miso";
            answer[4].Calorie = 312;
            answer[4].Price = 806;
            answer[4].Sodium = 2.13;
            answer[5].Name = "KaraMisoRamen";
            answer[5].Calorie = 314;
            answer[5].Price = 1592;
            answer[5].Sodium = 6.53;

        }

        public string ToRamenDetailString(Ramen food)
        {
            //@:逐語的識別子の文字
            //$:挿入文字列の文字
            //単位をここで決め打ちしてるけどいいのかこれで、でもほかのうまいやり方知らぬ
            return $"なまえ : {food.Name} \nカロリー : {food.Calorie} kcal\n値段 : {food.Price} \n塩分量 : {food.Sodium} g なのじゃ";
        }

        [Test]
        public void Show()
        {
            Ramen[] array = CreateRamenArray();
            FillRamenDetail(array);                                 //Null参照例外
            //述部を作るか否や？格納したいだけならもうできているし、Umm;
            //供述部作るよ！格納したいだけならExcelでも使えってそれいちばんいわれてるから
            for (int i = 0; i < array.Length; i++)
            {
                UnityEngine.Debug.Log(ToRamenDetailString(array[i]));
            }
        }
        //まだだけどインスタンス作成終了とする。
        //   private string ToHumanDetailString(Human person){
        //       return $"名前 : {person.Name} くん\nおもさ";
        //  }



        // public void Show()
        //  {
        //      Human[] array = CreateHumanArray();
        ////       for (int i = 0; i < array.Length; i++)
        //       {
        //           UnityEngine.Debug.Log(ToHumanDetailString(array[i]));
        //       }
        //   }


        // A Test behaves as an ordinary method
        //    [Test]
        //   public void NewTestScriptSimplePasses()
        //   {

        //   }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
