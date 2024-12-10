using IgnatovLab1lib;


namespace IgnatovLab1test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            int x = 2;
            int y = -2;
            int a = 5;
            double zf1 = z1.Zfunc1(x, y, a);
            Assert.AreEqual(83.8, zf1);
            int x2 = 2;
            int y2 = 4;
            int a2 = 7;
            double zf2 = z2.Zfunc2(x2, y2, a2);
            Assert.AreEqual(12, zf2);

        }
    }
}
