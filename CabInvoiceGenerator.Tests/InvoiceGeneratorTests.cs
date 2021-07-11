using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenerator.Tests
{
    [TestClass]
    public class InvoiceGeneratorTests
    {
        InvoiceGenerator invoiceGenerator = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            // Arrange
            double distance = 2.0;
            int time = 5;
            double expected = 25;

            // Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            
            // Assert
            Assert.AreEqual(expected, fare);
        }
    }
}
