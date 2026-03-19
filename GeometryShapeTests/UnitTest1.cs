using GheometryShape;

namespace GeometryShapeTests
{
    public class GeometryTests
    {
        [Fact]
        public void Rectangle_Area_CorrectValues_ReturnsExpected()
        {
            var rect = new Rectangle(5, 10);
            Assert.Equal(50, rect.Area());
        }

        [Fact]
        public void Rectangle_Perimeter_CorrectValues_ReturnsExpected()
        {
            var rect = new Rectangle(5, 10);
            Assert.Equal(30, rect.Perimeter());
        }

        [Fact]
        public void Triangle_Perimeter_CorrectValues_ReturnsExpected()
        {
            var tri = new Triangle(1, 4, 5);
            Assert.Equal(12, tri.Perimeter());
        }

        [Fact]
        public void Triangle_Area_CorrectValues_ReturnsExpected()
        {
            var tri = new Triangle(3, 4, 5);
            Assert.Equal(30, tri.Area());
        }
    }
}