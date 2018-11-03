using System;
using System.Collections.Generic;

namespace GardalandDashboard.Business.API
{
    public class AttractionTimeResponseModel
    {
        public Attractions Attractions { get; set; }
        public string Status { get; set; }
    }

    public partial class Attractions
    {
        public Attraction[] Attraction { get; set; }
    }

    public partial class Attraction
    {
        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                ImagePath = string.Concat("/images/", _Name.Replace(" ", ""), ".png");
            }
        }
        public string DisplayWaitTime { get; set; }
        
        public string ImagePath { get; set; }

    }

}