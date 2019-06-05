using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

namespace Tests
{

    /// <summary>
    ///  Dictionary クラスの項目
    /// </summary>
    internal class Item
    {
        public string key;
        public string value;
        public Item next;

        public Item(string key, string value, Item next)
        {
            this.key = key;
            this.value = value;
            this.next = next;
        }
    }

    ///<summary>
    ///辞書クラス
    /// </summary>
    /// 添字の型は整数型である必要はない

    class Dictionary
    {
        Item head;
        public Dictionary()
        {
            this.head = new Item(null, null, null);
        }

        public string this[string key]
        {
            set
            {

                for (Item item = this.head.next; item != null; item = item.next) //for文のループ条件は？ item=nullでループ終了
                {
                    UnityEngine.Debug.Log(item.key); //ﾊｧﾊｧ→ﾊｧ→ﾎﾟｶｰﾝ
                    UnityEngine.Debug.Log(item.value);//(;´Д｀)
                    UnityEngine.Debug.Log(item.next); //Tests.Item or Null
                    if (item.key == key)
                    {
                        item.value = value;
                        //UnityEngine.Debug.Log(item.key); //ﾊｧ
                       // UnityEngine.Debug.Log(item.value);//(　ﾟдﾟ)?
                       // UnityEngine.Debug.Log(item.next);   //Null
                        return;
                    }
                }
                this.head.next = new Item(key, value, this.head.next);
                UnityEngine.Debug.Log(key+value+this.head.next);//ﾊｧ(　ﾟдﾟ)?Tests.Item→ﾊｧﾊｧ(;´Д｀)Tests.Item
            }
            get
            {
                //UnityEngine.Debug.Log(item.key); //現在のコンテクストにitemはない
                //UnityEngine.Debug.Log(item.value);//現在のコンテクストにitemはない
                //UnityEngine.Debug.Log(item.next);//現在のコンテクストにitemはない
                for (Item item = this.head.next; item != null; item = item.next)
                {
                    UnityEngine.Debug.Log(item.key); //ﾊｧ
                    UnityEngine.Debug.Log(item.value);//(　ﾟдﾟ)?
                    UnityEngine.Debug.Log(item.next);   //Null
                    if (item.key == key)
                    {
                        UnityEngine.Debug.Log(item.key); //ﾊｧ
                        UnityEngine.Debug.Log(item.value);//(　ﾟдﾟ)?
                        UnityEngine.Debug.Log(item.next);   //Null

                        return item.value;
                    }
                }
                return null;
            }
        }
    }

    class IndexerSample
    {
        [Test]
        public static void Main()
        {
            Dictionary dic = new Dictionary();

            dic["ﾊｧ"] = "(　ﾟдﾟ)?";
            dic["ﾊｧﾊｧ"] = "(;´Д｀)";
            dic["ﾎﾟｶｰﾝ"] = "(　ﾟдﾟ)";
            dic["ｵﾏｴﾓﾅ"] = "(´∀`)";

            UnityEngine.Debug.Log(dic["ﾊｧ"]);
            // Console.Write(dic["ﾊｧﾊｧ"]);
        }
    }

}




