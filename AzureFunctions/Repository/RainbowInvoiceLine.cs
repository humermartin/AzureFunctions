using CsvHelper.Configuration.Attributes;

namespace AzureFunctions.Repository
{
    public class RainbowInvoiceLine
    {
        [Name("invoiceLine")]
        public int InvoiceLine { get; set; }

        [Name("invoiceCreationDate")]
        public DateTime InvoiceCreationDate { get; set; }

        [Name("invoicePeriod")]
        public string InvoicePeriod { get; set; }

        [Name("invoiceReference")]
        public string InvoiceReference { get; set; }

        [Name("exportReference")]
        public string ExportReference { get; set; }

        [Name("bp1TCRDId")]
        public string Bp1TCRDId { get; set; }

        [Name("bp1TApplicantNumber")]
        public string Bp1TApplicantNumber { get; set; }

        [Name("bp1TApplicantName")]
        public string Bp1TApplicantName { get; set; }

        [Name("bp2TCRDId")]
        public string Bp2TCRDId { get; set; }

        [Name("bp2TApplicantNumber1")]
        public string Bp2TApplicantNumber1 { get; set; }

        [Name("bp2TApplicantNumber2")]
        public string Bp2TApplicantNumber2 { get; set; }

        [Name("bp2TApplicantName")]
        public string Bp2TApplicantName { get; set; }

        [Name("endCustomerCompanyId")]
        public string EndCustomerCompanyId { get; set; }

        [Name("endCustomerCompanyId1ByBp")]
        public string EndCustomerCompanyId1ByBp { get; set; }

        [Name("endCustomerCompanyId2ByBp")]
        public string EndCustomerCompanyId2ByBp { get; set; }

        [Name("endCustomerCompanyName")]
        public string EndCustomerCompanyName { get; set; }

        [Name("aleServiceReference")]
        public string AleServiceReference { get; set; }

        [Name("rainbowServiceId")]
        public string RainbowServiceId { get; set; }

        [Name("rainbowServiceDescription")]
        public string RainbowServiceDescription { get; set; }

        [Name("subscriptionReference")]
        public string SubscriptionReference { get; set; }

        [Name("empty1")]
        public string Empty1 { get; set; }

        [Name("empty2")]
        public string Empty2 { get; set; }

        [Name("empty3")]
        public string Empty3 { get; set; }

        [Name("empty4")]
        public string Empty4 { get; set; }

        [Name("unit")]
        public string Unit { get; set; }

        [Name("volume")]
        public string Volume { get; set; }

        [Name("wplPricePerUnit")]
        public string WplPricePerUnit { get; set; }

        [Name("wplPriceTotal")]
        public string WplPriceTotal { get; set; }

        [Name("categoryCode")]
        public string CategoryCode { get; set; }

        [Name("bp1TDiscountValue")]
        public string Bp1TDiscountValue { get; set; }

        [Name("bp1TNetUnitValue")]
        public string Bp1TNetUnitValue { get; set; }

        [Name("bp1TNetTotalValue")]
        public string Bp1TNetTotalValue { get; set; }

        [Name("bp2TDiscountValue")]
        public string Bp2TDiscountValue { get; set; }

        [Name("bp2TNetUnitValue")]
        public string Bp2TNetUnitValue { get; set; }

        [Name("bp2TNetTotalValue")]
        public string Bp2TNetTotalValue { get; set; }

        [Name("endCustomerDiscountValue")]
        public string EndCustomerDiscountValue { get; set; }

        [Name("endCustomerNetUnitValue")]
        public string EndCustomerNetUnitValue { get; set; }

        [Name("endCustomerNetTotalValue")]
        public string EndCustomerNetTotalValue { get; set; }

        [Name("currency")]
        public string Currency { get; set; }
    }
}
