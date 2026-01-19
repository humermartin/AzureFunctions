using CsvHelper.Configuration.Attributes;

namespace AzureFunctions.Repository
{
    public class RainbowInvoiceLine
    {
        [Name("invoiceLine")]
        public int? InvoiceLine { get; set; }

        [Name("invoiceCreationDate")]
        public DateTime? InvoiceCreationDate { get; set; }

        [Name("invoicePeriod")]
        public string InvoicePeriod { get; set; }

        [Name("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [Name("fileName")]
        public string FileName { get; set; }

        [Name("partnerTier1TechnicalId")]
        public string  PartnerTier1TechnicalId { get; set; }

        [Name("partnerTier1CRDId")]
        public int? PartnerTier1CRDId { get; set; }

        [Name("partnerTier1ApplicantNumber")]
        public int? PartnerTier1ApplicantNumber { get; set; }

        [Name("partnerTier1ApplicantName")]
        public string PartnerTier1ApplicantName { get; set; }

        [Name("partnerTier2TechnicalId")]
        public string PartnerTier2TechnicalId { get; set; }

        [Name("partnerTier2CRDId")]
        public string PartnerTier2CRDId { get; set; }

        [Name("partnerTier2Reference")]
        public string PartnerTier2Reference { get; set; }

        [Name("partnerTier2AdditionalReference")]
        public string PartnerTier2AdditionalReference { get; set; }

        [Name("partnerTier2Name")]
        public string PartnerTier2Name { get; set; }

        [Name("customerTechnicalId")]
        public string CustomerTechnicalId { get; set; }

        [Name("customerReference")]
        public string CustomerReference { get; set; }

        [Name("customerAdditionalReference")]
        public string CustomerAdditionalReference { get; set; }

        [Name("customerName")]
        public string CustomerName { get; set; }

        [Name("subscriptionNumber")]
        public string SubscriptionNumber { get; set; }

        [Name("purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        [Name("additionalPurchaseOrderNumber")]
        public string AdditionalPurchaseOrderNumber { get; set; }

        [Name("aleServiceReference")]
        public string AleServiceReference { get; set; }

        [Name("rainbowServiceId")]
        public string RainbowServiceId { get; set; }

        [Name("rainbowServiceDescription")]
        public string RainbowServiceDescription { get; set; }

        [Name("priceListReference")]
        public string PriceListReference { get; set; }

        [Name("commercialProgram")]
        public string CommercialProgram { get; set; }

        [Name("unProratedWplPricePerUnit")]
        public decimal? UnProratedWplPricePerUnit { get; set; }

        [Name("contractAutoRenew")]
        public string ContractAutoRenew { get; set; }

        [Name("contractRenewDate")]
        public DateTime? ContractRenewDate { get; set; }

        [Name("unit")]
        public string Unit { get; set; }

        [Name("volume")]
        public int? Volume { get; set; }

        [Name("wplPricePerUnit")]
        public decimal? WplPricePerUnit { get; set; }

        [Name("wplPriceTotal")]
        public decimal? WplPriceTotal { get; set; }

        [Name("categoryCode")]
        public string CategoryCode { get; set; }

        [Name("partnerTier1DiscountValue")]
        public decimal? PartnerTier1DiscountValue { get; set; }

        [Name("partnerTier1NetUnitValue")]
        public decimal? PartnerTier1NetUnitValue { get; set; }

        [Name("partnerTier1NetTotalValue")]
        public decimal? PartnerTier1NetTotalValue { get; set; }

        [Name("partnerTier2DiscountValue")]
        public decimal? PartnerTier2DiscountValue { get; set; }

        [Name("partnerTier2NetUnitValue")]
        public decimal? PartnerTier2NetUnitValue { get; set; }

        [Name("partnerTier2NetTotalValue")]
        public decimal? PartnerTier2NetTotalValue { get; set; }

        [Name("customerDiscountValue")]
        public decimal? CustomerDiscountValue { get; set; }

        [Name("customerNetUnitValue")]
        public decimal? CustomerNetUnitValue { get; set; }

        [Name("customerNetTotalValue")]
        public decimal? CustomerNetTotalValue { get; set; }

        [Name("currency")]
        public string Currency { get; set; }

        [Name("subscriptionCreationDate")]
        public DateTime? SubscriptionCreationDate { get; set; }

        [Name("subscriptionLastRenewalDate")]
        public DateTime? SubscriptionLastRenewalDate { get; set; }

        [Name("businessCountry")]
        public string BusinessCountry { get; set; }

    }
}
