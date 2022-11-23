using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Enum;
using Version2.Data.Interface;

namespace ValueObjects.ValueObject
{
    public class RateVO : ValueObject , IOccassion
    {
        public decimal Rate {get; private set;}
        public decimal RateHr { get; private set; }
        public DateTime OccassionDate { get; set; }
        public string OccassionName { get; set; }
        public decimal RatePct { get;set; }
        public decimal RateOTPct { get; set; }
        public OccassionCategory Category { get; set; }
        private RateVO()
        {

        }
        public RateVO(decimal rate, ISettings isettings, IOccassion occassion)
        {
            if (rate < 0 )
                rate = 0;
            if (rate > isettings.maxrate)
                throw new InvalidOperationException($"Rate must be below {isettings.maxrate}");
            Rate = rate;
            RateHr = rate / isettings.hrperday;
            RatePct = occassion.RatePct;
            RateOTPct = occassion.RateOTPct;
            OccassionName = occassion.OccassionName;
            OccassionDate = occassion.OccassionDate;
            Category = occassion.Category;
        }
 
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Rate;
            yield return RateHr;
            yield return RatePct;
            yield return RateOTPct;
            yield return OccassionDate;
            yield return OccassionName;
            yield return Category;
         
        }
    }
}
