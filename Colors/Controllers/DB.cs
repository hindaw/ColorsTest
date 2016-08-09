using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Colors.Controllers
{
    public static class DB
    {

        public static List<Colors> Colors = new List<Colors>()
        {
            new Colors(){Id = 1, Name = "Red"},
            new Colors(){Id = 2, Name = "Orange"},
            new Colors(){Id = 3, Name = "Yellow"},
            new Colors(){Id = 4, Name = "Green"},
            new Colors(){Id = 5, Name = "Blue"},
            new Colors(){Id = 6, Name = "Indigo"},
            new Colors(){Id = 7, Name = "Violet"},
        };


        public static List<Votes> VotesList = new List<Votes>()
        {
            new Votes(){City = "Anchorage", Color =5 ,VotesNum=10000},
            new Votes(){City = "Anchorage", Color =3 ,VotesNum=15000},
            new Votes(){City = "Brooklyn", Color = 1 ,VotesNum=100000},
            new Votes(){City = "Brooklyn", Color = 5 ,VotesNum=250000},
            new Votes(){City = "Detroit", Color =1 ,VotesNum=160000},
            new Votes(){City = "Selma", Color = 3 ,VotesNum=15000},
            new Votes(){City = "Selma", Color = 7,VotesNum=5000},
        };



    }

    public class Colors
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Votes
    {
        public string City { get; set; }
        public int Color { get; set; }
        public double VotesNum { get; set; }
    }
}