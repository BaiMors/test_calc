using test_calc;

namespace unittests_calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMySum()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { -1, 3, 5, -0.344, 4230.42 };
            double excepted = 4237.076;
            double actual = calcs.MySum(doubles);
            Assert.IsTrue(actual == excepted);
        }

        [TestMethod]
        public void TestMyDiff()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { -0.000, 939, -1.437, -0.08209, 34 };
            double excepted = -971.48091;
            double actual = calcs.MyDiff(doubles);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestMyMult()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { -3, -9.5, -1 };
            double excepted = 28.5;
            double actual = calcs.MyMult(doubles);
            Assert.AreNotEqual(excepted, actual);
        }

        [TestMethod]
        public void TestMyDiv()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { -64.6, 459, 543 };
            double excepted = 0;
            double actual = calcs.MyDiv(doubles);
            Assert.IsFalse(excepted == actual);
        }

        [TestMethod]
        public void TestMyDeg()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 2, 2.5 };
            Type excepted = typeof(double);
            double actual = calcs.MyDeg(doubles);
            Assert.IsInstanceOfType(actual, excepted);
        }

        [TestMethod]
        public void TestMyRoot()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 258, 2 };
            Type excepted = typeof(int);
            double actual = calcs.MyRoot(doubles);
            Assert.IsNotInstanceOfType(actual, excepted);
        }

        [TestMethod]
        public void TestMyProc()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 14, 0 };
            double actual = calcs.MyProc(doubles);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestMyLog()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 7, 4 };
            double excepted = 1.40368;
            double actual = Math.Round(calcs.MyLog(doubles), 5);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestMySin()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 2005 };
            double excepted = 0.61618;
            double actual = Math.Round(calcs.MySin(doubles), 5);
            Assert.IsTrue(excepted == actual);
        }

        [TestMethod]
        public void TestMyCot()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 24 };
            double excepted = 0;
            double actual = Math.Round(calcs.MyCot(doubles), 5);
            Assert.IsFalse(excepted == actual);
        }

        [TestMethod]
        public void TestMyDiv2()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { -1, 0.2, 0, 89, 3.5 };
            Assert.ThrowsException<Exception>(() => calcs.MyDiv(doubles));
        }

        [TestMethod]
        public void TestMyDeg2()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { -1, 0.2 };
            Assert.ThrowsException<Exception>(() => calcs.MyDeg(doubles));
        }

        [TestMethod]
        public void TestMyRoot2()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 11, 4 };
            Assert.ThrowsException<Exception>(() => calcs.MyRoot(doubles));
        }

        [TestMethod]
        public void TestMyLog2()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 5, 1 };
            Assert.ThrowsException<Exception>(() => calcs.MyLog(doubles));
        }

        [TestMethod]
        public void TestMyCot2()
        {
            Calculations calcs = new Calculations();
            List<double> doubles = new() { 0 };
            Assert.ThrowsException<Exception>(() => calcs.MyCot(doubles));
        }
    }
}