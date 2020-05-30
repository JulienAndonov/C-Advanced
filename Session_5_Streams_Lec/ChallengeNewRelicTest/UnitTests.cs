using NUnit.Framework;
using NewRelicChallenge;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System;

namespace NewRelicChallenge.Tests
{
    [TestFixture]
    public class Tests
    {
        private ProcessEngine processEngine1 = new ProcessEngine();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestInvalidFileLocation()
        {
            Assert.Throws<FileNotFoundException>(() => processEngine1.Run(new string[] { "notExistingFIle.txt" }));
        }


        [Test]
        public void TestUnitTest1ContainsCertainValueForAtThePresent()
        {
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char systemDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
            string[] listOfFiles = new string[] { "Test.txt" };
            Dictionary<string, int> currentList = new Dictionary<string, int>();
            string currentFile = currentDirectory + systemDirectorySeparatorChar + listOfFiles[0];
            currentList = processEngine1.ProcessStream(File.OpenText(currentFile), currentList);
            Assert.That(() => currentList["at the present"] == 33);
        }


        [Test]
        public void TestUnitTest1ContainsCertainValueForOfTheSame()
        {
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char systemDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
            string[] listOfFiles = new string[] { "Test.txt" };
            Dictionary<string, int> currentList = new Dictionary<string, int>();
            string currentFile = currentDirectory + systemDirectorySeparatorChar + listOfFiles[0];
            currentList = processEngine1.ProcessStream(File.OpenText(currentFile), currentList);
            Assert.That(() => currentList["of the same"] == 320);
        }


        [Test]
        public void TestUnitTest1AndTest2ContainsCertainValueForInTheCase()
        {
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char systemDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
            string[] listOfFiles = new string[] { "Test.txt","Test2.txt"};
            Dictionary<string, int> currentList = new Dictionary<string, int>();
            string currentFile = currentDirectory + systemDirectorySeparatorChar + listOfFiles[0];
            currentList = processEngine1.ProcessStream(File.OpenText(currentFile), currentList);
            Assert.That(() => currentList["in the case"] == 134);
        }
    }
}