namespace ZipInstallment.Model
{
    public class GetPaymentPlanResponse
    {
        public InstallmentDetails Data { get; set; }

        public bool IsSuccessful { get; set; }

        public string ErrorMessage { get; set; }

        
    }
}
