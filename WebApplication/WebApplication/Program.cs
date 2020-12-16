using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> options = new Dictionary<string, string>();
            options.Add("company_name", "Facebook");
            options.Add("round", "a");
            var parser = new FundingRaisedParser();
            var parsed = parser.GetRecords();

            List<FundingRaised> results = new List<FundingRaised>();

            if (options.TryGetValue("company_name", out var companyName))
            {
                foreach (var item in parsed)
                {
                    if (item.company_name == companyName)
                    {
                        results.Add(item);
                    }
                }
            }
        }

















        public static void Calculate()
        {
            try
            {
                var input = "22 7 /";
                var vals = input.Split(' ');

                var v1 = Convert.ToDecimal(vals.ElementAtOrDefault(0));
                var v2 = Convert.ToDecimal(vals.ElementAtOrDefault(1));
                var o = vals.ElementAtOrDefault(2);

                var calculator = new Calculator();

                Console.WriteLine(calculator.Calculate(v1, v2, o));

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
