using CsvHelper.Configuration.Attributes;

namespace AzureFunctions.Repository
{
    public class AleServiceMapper
    {
        [Name("sid")]
        public int Sid { get; set; }

        [Name("aleServiceReference")]
        public string AleServiceReference { get; set; }

        [Name("a1BillItemId")]
        public string A1BillItemId { get; set; }
        
        [Name("rainbiowServiceID")]
        public string RainbiowServiceID { get; set; }

        [Name("rainbowServiceDescription")]
        public string RainbowServiceDescription { get; set; }

        [Name("billText")]
        public string BillText { get; set; }

        [Name("billCycle")]
        public int BillCycle { get; set; }

        [Name("isCategory")]
        public string IsCategory { get; set; }
    }
}
