using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static M_app.MarvelApi.Marvel;
using M_app.Models;

namespace M_app.MarvelApi
{
    public class CharacterDataWrapper
    {

        public int Code { get; set; }


        public string Status { get; set; }


        public string Copyright { get; set; }


        public string AttributionText { get; set; }


        public string AttributionHTML { get; set; }


        public CharacterDataContainer Data { get; set; }

        public string Etag { get; set; }
    }

    public class CharacterDataContainer
    {


        public int Offset { get; set; }

        public int Limit { get; set; }


        public int Total { get; set; }

        public int Count { get; set; }


        public List<Character> Results { get; set; }
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modified { get; set; }
        public string ResourceURI { get; set; }
        public List<MarvelUrl> Urls { get; set; }
        public MarvelImage Thumbnail { get; set; }
        public User usuario { get; set; }


    }

    public class CharacterList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<CharacterSummary> Items { get; set; }
    }

    public class CharacterSummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
