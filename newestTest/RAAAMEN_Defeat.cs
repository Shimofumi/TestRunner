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
        public class Ramen //structならｾｰﾌというかヒューマンの時と全く同じなんだよなあ...
        {

            public int Price;
            public double Calorie, Sodium;
            public string Name;
            public void CreateSaltRamenInstance()
            {   //なまえここでええんか？

                //Ramen Salt = new Ramen();
                //Ramen Tsukemen = new Ramen();
                //Ramen Rameeen = new Ramen();
                //Ramen Miso = new Ramen();
                //Ramen KaraMisoRamenn = new Ramen();

                Ramen SoySauce = new Ramen();
                SoySauce.Name = "醤油ラーメン";         //インスタンスの意義を理解できてるか怪しい
                SoySauce.Calorie = 334;
                SoySauce.Sodium = 4.2;
                SoySauce.Price = 810;

            }
            public void CreateShioRamenInstance()
            {
                Ramen Shio = new Ramen();
                this.Name = "しおラーメン";
                this.Calorie = 398;
                this.Sodium = 3.777;
                this.Price = 893;

            }
            public void CreateTsukemenInstance()
            {
                Ramen Tsukemen = new Ramen();
                this.Name = "つけめん";
                this.Calorie = 377;
                this.Price = 801;
                this.Sodium = 4.2;
            }
            public void CreateRameeenInstance()
            {
                Ramen Rameeen = new Ramen();
                this.Name = "ラメーン";
                this.Calorie = 364;
                this.Price = 890;
                this.Sodium = 0.16;
            }
            public void CreateMisoRamenInstance()
            {
                Ramen Miso = new Ramen();
                this.Name = "みそラーメン";
                this.Calorie = 312;
                this.Price = 806;
                this.Sodium = 2.13;
            }
            public void CreateKaraMisoRamenInstance()
            {
                Ramen KaraMisoRamen = new Ramen();
                this.Name = "からみそラーメン";
                this.Calorie = 314;
                this.Price = 1592;
                this.Sodium = 6.53;
            }
        }

        //どうやって文字列で表示させるつもりなんですかね...?

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


        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
