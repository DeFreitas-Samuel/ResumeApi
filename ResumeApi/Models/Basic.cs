using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Basic
    {
        string name;
        string label;
        string picture;
        string email;
        string phone;
        string website;
        string summary;
        Location location;
        List<Profile> profiles = new List<Profile>();

        public Basic(string name, string label, string picture, string email, string phone, string website, string summary, string address, string postalCode, string city,
                        string countryCode, string region, string network, string username, string url)
        {
            this.Name = name;
            this.Label = label;
            this.Picture = picture;
            this.Email = email;
            this.Phone = phone;
            this.Website = website;
            this.Summary = summary;
            Location = new Location(address, postalCode, city, countryCode, region);
            Profile profile = new Profile(network, username, url);
            profiles.Add(profile);
        }

        public string Name { get => name; set => name = value; }
        public string Label { get => label; set => label = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Website { get => website; set => website = value; }
        public string Summary { get => summary; set => summary = value; }
        public Location Location { get => location; set => location = value; }
        public List<Profile> Profiles { get => profiles; set => profiles = value; }
    }
}
