using ZipInstallment.Model;

namespace ZipInstallment.Provider
{
    public class PaymentPlanProvider
    {
        public PaymentPlanProvider()
        {

        }

        public  async Task<InstallmentDetails> GetPaymentPlanDetails(GetPaymentPlanRequest request)
        {
           
                InstallmentDetails details = new InstallmentDetails();
                decimal installmentAmount = request.AmountToBePaid / request.NumberOfInstallment;
                List<DateTime> installments = new List<DateTime>();
                installments.Add(request.StartDate);
                DateTime currInstallmentDate = request.StartDate;
                for (int i = 1; i < request.NumberOfInstallment; i++)
                {
                    currInstallmentDate = currInstallmentDate.AddDays(14);
                    installments.Add(currInstallmentDate);
                }
                details.InstallmentAmount = installmentAmount;
                details.InstallmentDates = installments;

                return await Task.FromResult(details);


        }
    }
}
