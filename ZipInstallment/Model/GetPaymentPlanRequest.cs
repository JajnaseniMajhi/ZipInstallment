namespace ZipInstallment.Model
{

    /// <summary>
    ///  Request object to get the payment plan
    /// </summary>
    public class GetPaymentPlanRequest
    {
        public decimal AmountToBePaid { get; set; }

        public DateTime StartDate { get; set; }

        public int NumberOfInstallment { get; set; }
    }
}
