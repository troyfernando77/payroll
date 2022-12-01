using System;
using System.Collections.Generic;
using System.Text;
using Version2.Data.Enum;
using Version2.Data.Interface;

namespace Version2.Data.Models
{
    public class GetTransYear
    {
        public int? Id { get; set; }
       
    }
    public class TransYear : Entity, IEntity
    {
        public int Year { get; set; }
        public Status Status { get; set; }
    }
    public class TransYearDto : Entity 
    {
        public int Year { get; set; }
        public Status Status { get; set; }
    }
    public class CreateorEditTransYearDto : Entity 
    {
        public int Year { get; set; }
        public Status Status { get; set; }
    }
}
