using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Profile
    {
        public Profile(string network, string username, string url)
        {
            this.Network = network;
            this.Username = username;
            this.Url = url;
        }

        string network;
        string username;
        string url;

        public string Network { get => network; set => network = value; }
        public string Username { get => username; set => username = value; }
        public string Url { get => url; set => url = value; }
    }
}
