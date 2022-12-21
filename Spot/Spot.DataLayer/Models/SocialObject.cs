using System;

namespace Spot.DataLayer.Models
{
    public class SocialObject
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string ShirtDescription{ set; get; }
        public string FullDescription { set; get; }
        public string PresenterId { set; get; }
        public string Status { get; set; }
        public string OtherInformation { get; set; }
    }
}