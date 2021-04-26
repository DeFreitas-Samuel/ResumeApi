using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Location
    {
        public Location(string address, string postalCode, string city, 
                        string countryCode, string region)
        {
            this.Address = address;
            this.PostalCode = postalCode;
            this.City = city;
            this.CountryCode = countryCode;
            this.Region = region;
        }

        string address;
        string postalCode;
        string city;
        string countryCode;
        string region;

        public string Address { get => address; set => address = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string Region { get => region; set => region = value; }
    }
}
