using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCountTests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void Test1()
        {
            string[] input = FileIO.ReadLines("../../Tests/test1.in");
            var t = new WordCount(input);
            FileIO.WriteToFile("../../Tests/test1.out", t.ShowResult());
        }
        [TestMethod]
        public void Test2()
        {
            string input = FileIO.ReadAll("../../Tests/test2.in");
            var t = new WordCount(input);
            FileIO.WriteToFile("../../Tests/test2.out", t.ShowResult());
        }
        [TestMethod]
        public void Test3()
        {
            string[] input = FileIO.ReadLines("../../Tests/test3.in");
            var t = new WordCount(input);
            FileIO.WriteToFile("../../Tests/test3.out", t.ShowResult());
        }
        [TestMethod]
        public void Test4()
        {
            string input = FileIO.ReadAll("../../Tests/test4.in");
            var t = new WordCount(input);
            FileIO.WriteToFile("../../Tests/test4.out", t.ShowResult());
        }

        [TestMethod]
        public void Test5()
        {
            string[] input = FileIO.ReadLines("../../Tests/test1.in");
            var t1 = new WordCount(input);
            var t2 = new WordCount(input);
            Assert.IsTrue(t1.WordCountMap.IsEqual(t2.WordCountMap));
        }
    }
}
