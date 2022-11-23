using System;
using Version2.Data.Enum;

namespace Version2.Data.Interface
{
    public interface IOccassion
    {
        DateTime OccassionDate { get; set; }
        string OccassionName { get; set; }
        decimal RatePct { get; set; }
        decimal RateOTPct { get; set; }
        OccassionCategory Category { get; set; }
    }
}
