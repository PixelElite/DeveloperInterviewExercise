using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileDataTest
{
    [TestClass]
    public class FileManagerTest
    {
        readonly FileManager _fileManager = new FileManager();

        // Get version detail Success test
        [TestMethod]
        public void GetDetailsTest_Version()
        {
            Assert.IsNotNull(_fileManager.GetDetails("/v", "C:/test.txt"));
        }

        // Get Size detail Success test
        [TestMethod]
        public void GetDetailsTest_Size()
        {
            Assert.IsNotNull(_fileManager.GetDetails("/s", "C:/test.txt"));
        }

        // Get detail negative test with invalid command
        [TestMethod]
        [ExpectedException(typeof(Exception),"Invalid Command.")]
        public void GetDetailsTest_InvalidCommand()
        {
            Assert.IsNull(_fileManager.GetDetails("-a", "C:/test.txt"));
        }
    }
}
