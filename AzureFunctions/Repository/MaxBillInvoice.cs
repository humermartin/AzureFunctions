namespace AzureFunctions.Repository
{
    public class MaxBillInvoice
    {
        public int Request_Id { get; set; }
        public DateTime Request_Ts { get; set; }

        public string Requesting_System{ get; set; }

        public string AccountNo { get; set; }

        public string Tn_VerhaeltnisId { get; set; }

        public string Country_nr { get; set; }

        public string Kz_nr { get; set; }

        public string Tn_nr { get; set; }

        public decimal Amount { get; set; }

        public string? ItemId { get; set; }

        public string ChangeTypeId { get; set; }

        public string FreeText { get; set; }

        public string CsrNote{ get; set; }
    }
}
