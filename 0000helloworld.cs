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
            // Use the Assert class to test conditions
//環境構築の際にしたこと
//UnityHub入れた、VS入ってた、勝った
//Allow 'unsafe' Codeにチェックを入れます
//Assembly Definition References のUse GUIDsにチェックを入れます
//「Burst」「Collections」「Jobs」「Mathematics」をインスコ
//テストコードなしでTestRunnerを走らせて死んだ
//	https://ufcpp.net/study/csharp/
//ここを教えてもらい今日はここまで

	    Debug.Log("ちかれたよパトラッシュ");
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
