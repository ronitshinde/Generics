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
    }
}