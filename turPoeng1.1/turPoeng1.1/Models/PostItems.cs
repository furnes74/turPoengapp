using System;
using System.Collections.Generic;
using System.Text;

namespace turPoeng1.Models
{
    public class PostItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PostHeight { get; set; }
        //Calcuated value
        public int PostAirDistanceFromLocation { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int DefaultPoints { get; set; }
    }
    public class Idrettslag
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Friend
    {
        public int friendId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string picture { get; set; }
        public List<Idrettslag> idrettslag { get; set; }
    }


}
