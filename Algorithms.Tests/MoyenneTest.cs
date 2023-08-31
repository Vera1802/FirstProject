using Algorithms;

namespace Algorithms.Tests;


[TestClass]
public class MoyenneTest
{
    [TestMethod]
    public void CalculateMoyenne()
        {
            List<double> lst = new List<double> { 5, 10, 6 };
            double expectedMoyenne = 7;

            double actualMoyenne = Moyenne.CalculateMoyenne(lst);

            Assert.AreEqual(expectedMoyenne, actualMoyenne, 0.001, "Le calcul de la moyenne est incorrect.");
        }
}