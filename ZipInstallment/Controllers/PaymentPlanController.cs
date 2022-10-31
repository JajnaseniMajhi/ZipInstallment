using Microsoft.AspNetCore.Mvc;
using ZipInstallment.Model;
using ZipInstallment.Provider;

namespace ZipInstallment.Controllers
{
    public class PaymentPlanController : ControllerBase
    {
        //Inject dependent services here
        public PaymentPlanController()
        {

        }
        [HttpPost("GetPaymentPlan")]
        public async Task<GetPaymentPlanResponse> GetPaymentPlan([FromBody] GetPaymentPlanRequest request)
        {
            GetPaymentPlanResponse response = new GetPaymentPlanResponse();
            try
            {
                var paymentPlanProvider = new PaymentPlanProvider();
                response.Data= await paymentPlanProvider.GetPaymentPlanDetails(request);
            }
            catch(Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        
    }
}
