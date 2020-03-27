using System;
using System.Collections.Generic;
using System.Text;

namespace turPoeng1.Models
{
  
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Picture { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public List<Idrettslag> Idrettslag { get; set; }
        public List<Friend> Friends { get; set; }
    }
}
