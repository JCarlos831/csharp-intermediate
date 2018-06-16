using System;
using Xunit;
using Xunit.Sdk;

namespace Testability.UnitTests
{
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION
        [Fact]
        [AssertActualExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment();
            };
            
            orderProcessor.Process(order);
        }

        [Fact]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            
            orderProcessor.Process(order);
            
            Assert.(order.IsShipped)
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}