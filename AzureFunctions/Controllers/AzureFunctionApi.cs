using AzureFunctions.Repository;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using System.Reflection;
using System.Text.Json;


namespace AzureFunctions.Controllers
{
    public class AzureFunctionApi(ILogger<AzureFunctionApi> Log, IWebHostEnvironment env) : Controller
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
                    Delimiter = ";",
                    HeaderValidated = null,
                    MissingFieldFound = null
                };

                using var csv = new CsvReader(stringReader, config);

                List<RainbowInvoiceLine> records = csv.GetRecords<RainbowInvoiceLine>().ToList();


                var path = Path.Combine(
                    env.ContentRootPath,
                    "Data",
                    "matrix.json");

                string json = System.IO.File.ReadAllText(path);
                var aleMapping = JsonSerializer.Deserialize<List<AleServiceMapper>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


                var maxBillInvoices = new List<MaxBillInvoice>();

                foreach (var invRecord in records)
                {
                    var maxBillInvoice = new MaxBillInvoice();
                    {
                        //KZ_NR and TN_NR from CustomerAdditionalReference
                        if (!string.IsNullOrWhiteSpace(invRecord.CustomerAdditionalReference))
                        {
                            var spCustRef = invRecord.CustomerAdditionalReference.Split(" ");
                            if (spCustRef.Length == 2)
                            {
                                maxBillInvoice.Kz_nr = spCustRef[0];
                                maxBillInvoice.Tn_nr = spCustRef[1];
                            }
                            else
                            {
                                maxBillInvoice.Kz_nr = invRecord.CustomerAdditionalReference;
                            }

                            if (invRecord.WplPriceTotal.HasValue)
                            {
                                maxBillInvoice.Amount = invRecord.WplPriceTotal.Value;
                            }
                            
                        }

                        // CSRNote from InvoicePeriod / FreeText from InvoidePeriod and Volume
                        if (!string.IsNullOrWhiteSpace(invRecord.InvoicePeriod))
                        {
                            var invPeriod = invRecord.InvoicePeriod.Split("-");
                            if (invPeriod.Length > 0)
                            {
                                int year = int.Parse(invPeriod[0]);
                                int month = int.Parse(invPeriod[1]);

                                maxBillInvoice.CsrNote = $"Einspielung {month}/{year}";

                                DateTime lastDate = new DateTime(year , month, DateTime.DaysInMonth(year, month));
                                if (invRecord.Volume.HasValue)
                                {
                                    maxBillInvoice.FreeText = $"{invRecord.Volume} Stk. Zeitraum: 1.{month}.{year} bis {lastDate.Day}.{month}.{year}";
                                }
                                else
                                {
                                    maxBillInvoice.FreeText = $"Zeitraum: 1.{month}.{year} bis {lastDate.Day}.{month}.{year}";
                                }
                                    
                            }
                        }

                        // ItemID from PartnerTier1ApplicantNumber
                        if (!string.IsNullOrWhiteSpace(invRecord.AleServiceReference))
                        {
                            var serviceMap = aleMapping.FirstOrDefault(a => a.AleServiceReference.Equals(invRecord.AleServiceReference));
                            maxBillInvoice.ItemId = serviceMap?.A1BillItemId;
                        }
                        
                    }

                    maxBillInvoices.Add(maxBillInvoice);
                }

                return Ok(maxBillInvoices);
            }
            catch (Exception ex)
            {
                Log.LogError($"{MethodBase.GetCurrentMethod()}. Error converting csv to json. {ex.Message}. {ex.InnerException}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
