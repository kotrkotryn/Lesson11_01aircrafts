using Lesson11_01.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AircraftRepository aircraftRepository = new AircraftRepository();
            AircraftModelRepository aircraftModelRepository = new AircraftModelRepository();
            CompanyRepository companyRepository = new CompanyRepository();
            CountryRepository countryRepository = new CountryRepository();

            ReportGenerator reportGenerator = new ReportGenerator(aircraftRepository,
                                                              aircraftModelRepository,
                                                              companyRepository,
                                                              countryRepository);

            var reportItems = reportGenerator.GenerateReportAircraftInEurope();
            
            foreach(var reportItem in reportItems)
            {
                Console.WriteLine($"Tail number: {reportItem.TailNumber}");
                Console.WriteLine($"Model number: {reportItem.ModelNumber}");
                Console.WriteLine($"Model description: {reportItem.ModelDescription}");
                Console.WriteLine($"Company name: {reportItem.OwnerCompanyName}");
                Console.WriteLine($"Country code: {reportItem.CompanyCountryCode}");
                Console.WriteLine($"Country name: {reportItem.CompanyCountryName}");
            }
        }
    }
}
