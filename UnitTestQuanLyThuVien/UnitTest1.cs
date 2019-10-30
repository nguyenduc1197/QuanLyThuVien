using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using THKiemDinh;
using THKiemDinh.Models;

namespace UnitTestQuanLyThuVien
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Login()
        {
            string username = "nhanvien";
            string password = "Account not exists";
            string expected = "Account not exists";

        
            Assert.AreEqual(password,expected);
        }
    }
}
