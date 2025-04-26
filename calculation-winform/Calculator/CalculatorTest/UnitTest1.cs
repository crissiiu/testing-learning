using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Calculator;

namespace CalculatorTest
{
    [TestClass] //Dinh nghia mot lop test: chua cac phuong thuc de test cho mot project nao do
    public class UnitTest1
    {
        private Calculation _calculation; //Dinh nghia mot bien de chua doi tuong Calculation

        public TestContext TestContext { get; set; } //Dinh nghia mot bien de chua thong tin ve test context

        //Tao phuong thuc khoi tao
        [TestInitialize]
        public void Initialize()
        {
            _calculation = new Calculation(5, 3); //Khoi tao doi tuong Calculation voi a = 5, b = 3
        }


        [TestMethod] //TestMethod: Dinh nghia mot phuong thuc test, se co nhieu testcase
        public void TestAddOperator()
        {
            //Testcase 1: a = 5, b = 3, expected = 8
            int expected = 8; //Ket qua mong doi
            Calculation calculation = new Calculation(5, 3);

            int actual = calculation.Execute("add"); //Thuc thi phep cong
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubOperator() 
        { 
            int expected = 2; //Ket qua mong doi
            Calculation calculation = new Calculation(5, 3);

            int actual = calculation.Execute("subtract"); //Thuc thi phep tru
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMulOperator()
        {
            int expected = 15; //Ket qua mong doi
            Calculation calculation = new Calculation(5, 3);
            
            int actual = calculation.Execute("multiply"); //Thuc thi phep nhan
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivOperator()
        {
            int expected = 1;
            Calculation calculation = new Calculation(5,3);

            int actual = calculation.Execute("divide"); //Thuc thi phep chia
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))] //Khi thuc thi phep chia cho 0, se phat sinh exception DivideByZeroException
        public void TestDivOperatorByZero()
        {
            _calculation = new Calculation(5, 0);
            _calculation.Execute("divide");
        }


        //Lien ket TestData voi pj
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv","TestData#csv", DataAccessMethod.Sequential)]//Dang lien ket (Doc tu du lieu nao), 
        public void TestWithDataSource()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());

            expected = int.Parse(TestContext.DataRow[2].ToString());

            _calculation = new Calculation(a, b);

            actual = _calculation.Execute("add");
            Assert.AreEqual(expected, actual);

        }
    }
}
