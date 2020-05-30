using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace NewRelicChallenge
{
    [TestFixture]
    public class Tests
    {
        private ProcessEngine processEngine1;
        public void Setup()
        {
        }

        [Test]
        public void TestNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => processEngine1.Run(new string[] { "notExistingFIle.txt" }));
        }


        [Test]
        public void TestFileCannotBeFound()
        {
            processEngine1 = new ProcessEngine();
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char systemDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
            string file = "notExistingFile.txt";
            string fileFullPath = currentDirectory + systemDirectorySeparatorChar + file;
            Assert.That(() => processEngine1.Run(new string[]{file}),Throws.Nothing,$"Could not find file {fileFullPath}");
        }

        [Test]
        public void TestUnitTest1ContainsCertainValueForAtThePresent()
        {
            processEngine1 = new ProcessEngine();
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
            processEngine1 = new ProcessEngine();
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
            processEngine1 = new ProcessEngine();
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char systemDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
            string[] listOfFiles = new string[] { "Test.txt", "Test2.txt" };
            Dictionary<string, int> sequences = new Dictionary<string, int>();
            string currentFile = currentDirectory + systemDirectorySeparatorChar + listOfFiles[0];
            foreach (var file in listOfFiles)
            {
                currentFile = currentDirectory + systemDirectorySeparatorChar + file;
                sequences = processEngine1.ProcessStream(File.OpenText(currentFile), sequences);


            }
            Assert.That(() => sequences["in the case"] == 134);
        }
    }
}