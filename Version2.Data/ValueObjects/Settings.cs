using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Interface;
using Version2.Data.Enum;
namespace Payroll.Model
{
    public class Settings : ISettings
    {
        public decimal maxrate { get => 1500M; }
        public decimal hrperday { get => 10; }
    }
 
 
    public class Occassion : IOccassion
    {
        public int Id { get; set; }
        public DateTime OccassionDate { get; set; }
        public string OccassionName { get; set; }
        public decimal RatePct { get; set; }
        public decimal RateOTPct { get; set; }
        public OccassionCategory Category { get; set; }
        public Occassion(DateTime occassiondate, string occassion, decimal ratepct, 
            decimal otratepct, OccassionCategory category)
        {
            OccassionDate = occassiondate;
            OccassionName = occassion;
            RatePct = ratepct;
            RateOTPct = otratepct;
            Category = category;
        }
        protected Occassion()
        {

        }
        public static Occassion RegularOccassion()
        {
            return new Occassion(DateTime.Parse("1/1/1900"), "REGULAR", 1, 1, OccassionCategory.REGULAR);
        }
       

    }
}