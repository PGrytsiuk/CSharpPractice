using CSharpPractice.main.arrays_operations;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void FuzzBizzOperation_PrintsExpectedOutput()
        {
            // Arrange
            int[] arr = { 1, 3, 5, 15, 7 };
            string expected =
                "1" + Environment.NewLine +
                "Fuzz" + Environment.NewLine +
                "Bizz" + Environment.NewLine +
                "FuzzBizz" + Environment.NewLine +
                "7" + Environment.NewLine;

            TestContext.WriteLine("Starting FuzzBizzOperation test with input: [{0}]", string.Join(", ", arr));
            TestContext.WriteLine("Expected output:\n{0}", expected.Replace(Environment.NewLine, "\\n\n"));

            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            FuzzBizz.FuzzBizzOperation(arr);

            // Assert
            string actual = sw.ToString();
            TestContext.WriteLine("Actual output:\n{0}", actual.Replace(Environment.NewLine, "\\n\n"));

            Assert.AreEqual(expected, actual, "FuzzBizzOperation output did not match expected output.");
        }
    }
}