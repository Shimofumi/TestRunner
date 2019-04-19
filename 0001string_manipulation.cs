using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {

            //文字列操作と表示の基礎入門

            // Use the Assert class to test conditions
            string str = "ほげー";
            str += "ふにゃー";
            // UnityEngine.Debug.Log(Str); これミス,C#では変数名はケースセンシティブ
            UnityEngine.Debug.Log(str);

            string str0 = @"ほんげええ
ふにゃあああ";
            UnityEngine.Debug.Log(str0);
            //@""文字列は改行含めそのまんま文字列にできます
            //$""はCのsprintf相当



            int a = 10;
            double z = -52.7;
            string str1 = "数値";
            string str2 = $"{str0} : {a}\n{z}";
            UnityEngine.Debug.Log(str2);

            //int32.cs開いてみる
            //そこに string ToString()がある
            // ToStringを使うとあらゆる型のあらゆる値が文字列型で表現されちまうんだ！
            // Debug.Logの引数にはstring型のみを渡す癖を身に着けないと後々苦労する
            // UnityEngine.Debug.Log(-1145141919.ToString());これミス
            UnityEngine.Debug.Log((-1145141919).ToString());
            // こうすべし

        }

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
