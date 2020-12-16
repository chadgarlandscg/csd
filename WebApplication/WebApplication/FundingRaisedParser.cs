using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace WebApplication
{
    public class FundingRaisedParser
    {

        public IEnumerable<FundingRaised> GetRecords()
        {
            List<FundingRaised> records = new List<FundingRaised>();
            using (TextReader reader = File.OpenText(@"/Users/bart/Downloads/Work.csv"))
            {
                CsvReader csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.CurrentCulture));
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    FundingRaised record = csv.GetRecord<FundingRaised>();
                    records.Add(record);
                }
            }

            return records;
        }
    }
}
