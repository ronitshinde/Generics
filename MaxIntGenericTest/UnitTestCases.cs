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
    }
}