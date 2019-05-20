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
            for(int  i = 0;i<10;i++){
            int a = UnityEngine.Random.Range(0, 256);//ランダムな値として0~255を決め打ちした
            int b = UnityEngine.Random.Range(0, 256);
            //int c = a+b;
            UnityEngine.Debug.Log($"{i+1}度め！！a+b={a+b}！！");
            //UnityEngine.Debug.Log(c);
            }
            // Use the Assert class to test conditions
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
