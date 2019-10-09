using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Model
{
    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
        public List<Summoner> Favorites { get; set; }
        public List<Team> Teams { get; set; }
    }
}
