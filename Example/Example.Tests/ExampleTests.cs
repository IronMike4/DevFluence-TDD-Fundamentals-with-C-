using NUnit.Framework;

namespace Example.Tests
{
    [TestFixture]
    public class ExampleProdCodeTests
    {
        // {MethodName}_Give{Scenario}_Should{ExpectedResult}
        [Test]
        public void HelloWorld_GivenDefault_ShouldReturnHelloWorld()
        {
            // Arrange
            var expected = "Hello World";
            var sut = new ExampleProdCode();

            // Act 
            var actual = sut.HelloWorld();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GoodMorningWorld_GivenDefault_ShouldReturnHelloWorld()
        {
            // Arrange
            var expected = "Hello World";
            var sut = new ExampleProdCode();

            // Act 
            var actual = sut.GoodMorningWorld(
                );

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
