using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZipInstallment.Model;
using ZipInstallment.Provider;

namespace ZipInstallment.Test
{
    [TestClass]
    public class PaymentPlanProviderTest
    {
        [TestMethod]
        public void GetPlanDetailsTest()
        {
            var request = new GetPaymentPlanRequest();
            request.AmountToBePaid = 100;
            request.NumberOfInstallment = 4;
            request.StartDate = new DateTime(2020,01,01);
            var paymentPlanProvider = new PaymentPlanProvider();
           var response= paymentPlanProvider.GetPaymentPlanDetails(request).Result;
            Assert.IsNotNull(response);
            Assert.AreEqual(25, response.InstallmentAmount);
        }

    }
}