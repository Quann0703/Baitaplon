using BUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test_Doan1
{
    [TestClass]
    public class test_login
    {
        [TestMethod]
        public void testlogin_Khongnhapmk()
        {
            
            //Arange
            BUS_Taikhoan loginform = new BUS_Taikhoan();
            string username = "abc";
            string password = "";
            string role = "";

            //Act
            bool result = loginform.kiemtratk(username, password,role);

            //Arrange

            Assert.AreEqual(result,true);
        }

        [TestMethod]
        public void TestLogin_KhongNhapTenTaiKhoan()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();
            
            string username = "";
            string password = "abc";
            string role = "";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_KhongNhapTenTaiKhoanMK()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "";
            string password = "";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void TestLogin_Nhapdtksmk()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "user1";
            string password = "";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_Nhapstkdmk()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "user1";
            string password = "";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_Nhapstksmk()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "use1";
            string password = "ahd";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_Nhapdtkmksltk()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "use1";
            string password = "pass1";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void TestLogin_Nhapdungrolegv()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "user1";
            string password = "pass1";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_Nhapdungrolehs()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "user2";
            string password = "pass2";
            string role = "Học sinh";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_Nhapdunggv()
        {
            // Arrange
            BUS_Taikhoan loginform = new BUS_Taikhoan();

            string username = "user4";
            string password = "pass4";
            string role = "Giáo viên";

            // Act
            bool result = loginform.kiemtratk(username, password, role);
            // Assert
            Assert.AreEqual(result, true);
        }
    }
    
}
