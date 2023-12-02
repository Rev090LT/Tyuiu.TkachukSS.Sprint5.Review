using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TkachukSS.Sprint5.Review.Task7.V24.Lib;
namespace Tyuiu.TkachukSS.Sprint5.Review.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Hardwired\source\repos\Tyuiu.TkachukSS.Sprint5.Review\Tyuiu.TkachukSS.Sprint5.Review.Task7.V24\bin\Debug\OutPutDataFileTask7V24.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
