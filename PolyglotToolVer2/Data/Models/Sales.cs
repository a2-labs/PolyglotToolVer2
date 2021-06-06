using System;
namespace PolyglotToolVer2.Data.Models
{
    public class Sales
    {
        public bool check {get;set;}
        public string kwd { get; set; }
        public DateTime date { get; set; }
        public string document { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public double total { get; set; }
        public string payment { get; set; }
        public string voucher { get; set; }
        public string AddressPel { get; set; }
        public string CityPel { get; set; }
        public string ZipPel { get; set; }
        public string TelPel { get; set; }
        public string notes { get; set; }
    }
}
