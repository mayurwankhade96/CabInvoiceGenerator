using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenerator.Tests
{
    [TestClass]
    public class InvoiceGeneratorTests
    {
        InvoiceGenerator invoiceGenerator = null;

        /// <summary>
        /// Test case for checking calculate fare function
        /// </summary>
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

        /// <summary>
        /// Test case for checking calculate fare function for multiple rides summary
        /// </summary>
        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            // Arrange
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            // Act
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            // Assert
            Assert.AreEqual(expectedSummary, summary);
        }
    }
}
