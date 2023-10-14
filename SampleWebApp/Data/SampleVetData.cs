using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;

namespace SampleWebApp.Data
{
    public  class SampleVetData
    {

        public List<VetDataModel> GetAllVetData()
        {
            return new List<VetDataModel> {

                new VetDataModel()
                {
                    HospitalId =1,
                    HopitalName = "4 PAWS ANIMAL HOSPITAL",
                    Address = "14516 N. 19TH STREET",
                    City = "TAMPA",
                    State = "FL",
                    ZipCode =33613,
                    ContactNumber = 8138772485
            },

                new VetDataModel()
                {
                    HospitalId =2,
                    HopitalName = "ABBOTT ANIMAL HOSPITAL",
                    Address = "5237 EHRLICH RD",
                    City = "TAMPA",
                    State = "FL",
                    ZipCode =33624,
                    ContactNumber = 8139637297
            },
            new VetDataModel()
                {
                    HospitalId =3,
                    HopitalName = "ABRAAM ANIMAL HOSPITAL",
                    Address = "4909 EHRLICH RD",
                    City = "TAMPA",
                    State = "FL",
                    ZipCode =33624,
                    ContactNumber = 8139617770
            },
                new VetDataModel()
                {
                    HospitalId =4,
                    HopitalName = "AFFORDABLE PET HOSPITAL",
                    Address = "10028 CROSS CREEK BLVD",
                    City = "TAMPA",
                    State = "FL",
                    ZipCode =33647,
                    ContactNumber = 8139919898
            },

            new VetDataModel()
                        {
                            HospitalId =5,
                            HopitalName = "ABC VETERINARY HOSPITAL UPTOWN",
                            Address = "4054 NORMAL ST",
                            City = "San Diego",
                            State = "CA",
                            ZipCode =92103,
                            ContactNumber = 6192996020
                    },
                new VetDataModel()
                            {
                                HospitalId =6,
                                HopitalName = "ALL DAY PET HOSPITAL",
                                Address = "10175 RANCHO CARMEL DR 128",
                                City = "San Diego",
                                State = "CA",
                                ZipCode =92128,
                                ContactNumber = 8587167440
                        },

                new VetDataModel()
                            {
                                HospitalId =7,
                                HopitalName = "ANIMAL DERMATOLOGY CLINIC",
                                Address = "5610 KEARNY MESA RD STE B1",
                                City = "San Diego",
                                State = "CA",
                                ZipCode =92111,
                                ContactNumber = 8585609393
                        },

                new VetDataModel() {
                HospitalId =8,
                                HopitalName = "ABORN PET CLINIC",
                                Address = "2525 ABORN RD",
                                City = "SAN JOSE",
                                State = "CA",
                                ZipCode =95121,
                                ContactNumber = 4082704600
                },
                new VetDataModel() {
                HospitalId =9,
                                HopitalName = "ACACIA PET CLINIC",
                                Address = "4486 PEARL AVE",
                                City = "SAN JOSE",
                                State = "CA",
                                ZipCode =95136,
                                ContactNumber = 4082646354
                },
                new VetDataModel() {
                HospitalId =10,
                                HopitalName = "AKAL-ANIMAL CLINIC",
                                Address = "1710 BERRYESSA RD # 106",
                                City = "SAN JOSE",
                                State = "CA",
                                ZipCode =95133,
                                ContactNumber = 4082542525
                },
                new VetDataModel() {
                HospitalId =11,
                                HopitalName = "ALMADEN ANIMAL CLINIC",
                                Address = "6055 MERIDIAN AVE STE 10",
                                City = "SAN JOSE",
                                State = "CA",
                                ZipCode =95120,
                                ContactNumber = 4089278387
                },
                new VetDataModel() {
                HospitalId =11,
                                HopitalName = "ALMADEN LOUNGE",
                                Address = "1160 BLOSSOM HILL RD",
                                City = "SAN JOSE",
                                State = "CA",
                                ZipCode =95118,
                                ContactNumber = 4082314034
                },
                new VetDataModel() {
                HospitalId =11,
                                HopitalName = "ALUM ROCK ANIMAL HOSPITAL",
                                Address = "2810 ALUM ROCK AVE",
                                City = "SAN JOSE",
                                State = "CA",
                                ZipCode =95127,
                                ContactNumber = 4082582735
                }

            };
        }
        public List<VetDataModel> GetVetDataByZip(int zipCode)
        {
          return  GetAllVetData().Where(x => x.ZipCode == zipCode).ToList();
        }

        public List<VetDataModel> GetVetDataByLocation(string state, string city)
        {
            return GetAllVetData().Where(x => x.State == state && x.City.ToLower() == city.ToLower()).ToList();
        }

    }

    public class VetDataModel
    {
        public int HospitalId { get; set; }
        public string HopitalName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public long ContactNumber { get; set; }

    }


}