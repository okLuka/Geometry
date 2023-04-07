using Geometry;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            double Cexpected = 36;

            double v = Class1.TriangleArea(x, y , z);

            Assert.Equal(v, Cexpected);

            bool d = Class1.IsRightTriangle(x, y, z);
            Assert.True(d);

            double x1 = 3;
            double Texpected = 28.2743;

            double c = Class1.CircleArea(x1);

            Assert.Equal(c, Texpected);
        }
    }
}
