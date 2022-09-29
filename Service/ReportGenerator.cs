using Lesson11_01.Models;
using Lesson11_01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Service
{
    internal class ReportGenerator
    {
        AircraftRepository _aircraftRepository;        //tai nėra modelis, bet su _ indikuojam, kad naudojam tuos modelius ar repozitorijas
        AircraftModelRepository _aircraftModelRepository;
        CompanyRepository _companyRepository;
        CountryRepository _countryRepository;

        public ReportGenerator(AircraftRepository aircraftRepository, 
                               AircraftModelRepository aircraftModelRepository, 
                               CompanyRepository companyRepository, 
                               CountryRepository countryRepository)     //konstruktorius, per kurį paduodame visas repozitorijas
        {
            _aircraftRepository = aircraftRepository;            //priskiriame reikšmes ir nuo čia naudosime su _
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
        }
        public List<ReportItem> GenerateReportAircraftInEurope()     //metodas su ataskaitomis
        {
            var listAircraftInEurope = new List<Aircraft>();
            var listAircraft = _aircraftRepository.Retrieve();
            

            foreach(var aircraft in listAircraft)
            {
                 
                Country aircraftCountry = _countryRepository.Retrieve(aircraft.CountryId);
                if (aircraftCountry.CountryInEurope)                                       //jis bus true
                {
                    listAircraftInEurope.Add(aircraft);
                    Console.WriteLine(_countryRepository.Retrieve(aircraft.CountryId).CountryName);    //istraukia countryName is listAircraftInEurope
                    //klaida buvo - Console.WriteLine(_countryRepository.Retrieve(_aircraftRepository.Retrieve(countryId).CountryName).CountryInEurope);
                }

            }

            List<ReportItem> reportItems = new List<ReportItem>();
            foreach (var aircraft in listAircraftInEurope)
            {
                ReportItem reportItem = new ReportItem();
                reportItem.TailNumber = aircraft.TailNumber;
                reportItem.ModelNumber = _aircraftModelRepository.Retrieve(aircraft.ModelId).Id;
                reportItem.ModelDescription = _aircraftModelRepository.Retrieve(aircraft.ModelId).ModelDescription;
                reportItem.OwnerCompanyName = _companyRepository.Retrieve(aircraft.CountryId).CompanyName;
                reportItem.CompanyCountryCode = _countryRepository.Retrieve(_companyRepository.Retrieve(aircraft.CountryId).CountryId).CountryCode;
                reportItem.CompanyCountryName = _countryRepository.Retrieve(_companyRepository.Retrieve(aircraft.CountryId).CountryId).CountryName;

                reportItems.Add(reportItem);

            }
            return reportItems;
        }
    }
}
