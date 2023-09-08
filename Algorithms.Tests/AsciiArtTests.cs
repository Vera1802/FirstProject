using Algorithms;

namespace Algorithms.Tests;


[TestClass]
public class AsciiArtTests
{
    [TestMethod]
    public void CreateStaircase()
        {
            AsciiArt asciiArt = new AsciiArt();
            string staircase = asciiArt.CreateStaircase(2, 3);
            Assert.AreEqual(28, staircase.Length);
        }
}