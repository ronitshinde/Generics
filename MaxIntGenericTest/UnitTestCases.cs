using Generics;
namespace MaxIntGenericTest
{
    public class Tests
    {
        FindMaxGeneric<int> intFindMax = new FindMaxGeneric<int>();
        FindMaxGeneric<float> floatFindMax = new FindMaxGeneric<float>();
        FindMaxGeneric<string> stringFindMax = new FindMaxGeneric<string>();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = intFindMax.FindMaximumGeneric(30, 20, 17);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = intFindMax.FindMaximumGeneric(10, 20, 17);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = intFindMax.FindMaximumGeneric(17, 10, 20);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxFirstFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = floatFindMax.FindMaximumGeneric(37.50f, 10.65f, 20.58f);
            Assert.AreEqual(37.50f, result);
        }
        [Test]
        public void GivenMaxSecondFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = floatFindMax.FindMaximumGeneric(37.50f, 50.65f, 20.58f);
            Assert.AreEqual(50.65f, result);
        }
        [Test]
        public void GivenMaxThirdFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = floatFindMax.FindMaximumGeneric(37.50f, 50.65f, 70.58f);
            Assert.AreEqual(70.58f, result);
        }
        [Test]
        public void GivenMaxFirstString_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = stringFindMax.FindMaximumGeneric("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }

    }
}