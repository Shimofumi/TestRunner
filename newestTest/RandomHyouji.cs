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
        {   //"a+b=c"をどう表記させるか...
            int a = UnityEngine.Random.Range(0, 256);   //ランダムな値がここで入る
            int b = UnityEngine.Random.Range(0, 256);   //0~255
            for (int i = 0; i < 10; i++)
            {
                int c = a + b;      //ここはランダムではない
                UnityEngine.Debug.Log($"{nameof(a)} + {nameof(b)} =");
                UnityEngine.Debug.Log(c);   //文字列結合させたいなあ
            }
            
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
