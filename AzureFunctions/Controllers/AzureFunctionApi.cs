using AzureFunctions.Repository;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using System.Reflection;

namespace AzureFunctions.Controllers
{
    public class AzureFunctionApi(ILogger<AzureFunctionApi> Log) : Controller
    {
        [HttpPost("CsvToJson")]
        [Authorize]
        public async Task<IActionResult> CsvToJson()
        {
            try
            {
                Log.LogInformation($"{MethodBase.GetCurrentMethod()}. Start converting csv to json.");
                using var reader = new StreamReader(Request.Body);
                string csvText = await reader.ReadToEndAsync();

                if (string.IsNullOrWhiteSpace(csvText))
                {
                    return BadRequest("CSV body is empty");
                }

                using var stringReader = new StringReader(csvText);

                var config = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    Delimiter = ";"
                };

                using var csv = new CsvReader(stringReader, config);

                List<RainbowInvoiceLine> records = csv.GetRecords<RainbowInvoiceLine>().ToList();

                var maxBillInvoices = new List<MaxBillInvoice>();

                foreach (var invRecord in records)
                {
                    var maxBillInvoice = new MaxBillInvoice
                    {
                        Volume = invRecord.Volume,
                        InvoiceName = invRecord.InvoiceReference
                    };

                    maxBillInvoices.Add(maxBillInvoice);
                }

                return Ok(maxBillInvoices);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
