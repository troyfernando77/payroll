using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
 

namespace Version2.Data.Models
{
    public class CreateorEditDTRHeadDTO : Entity
    {
        public DateTime Startdate { get; set; }
        public DateTime Cutoffdate { get; set; }
    }
    public class DTRHeadDTO
    {
        public int Id { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Cutoffdate { get; set; }
        public string Cutoff { get; set; }
        public decimal TotalAmount { get; set; }
        public List<DTR> Dtrs { get; set; } = new List<DTR>();
    }
    public class DTRHead : Entity
    {
        public DateTime Startdate { get; set; }
        public DateTime Cutoffdate { get; set; }
        public string Cutoff { get; set; }
        public decimal TotalAmount { get; set; }
        public List<DTR> Dtrs { get; set; } = new List<DTR>();
        protected DTRHead(int id, DateTime startdate, DateTime cutoffdate)
        {
            if (cutoffdate <= startdate)
                throw new Exception("Cutoff is less than startdate");
            Id = id;
            Startdate = startdate;
            Cutoffdate = cutoffdate;
            Cutoff = $"{startdate.ToShortDateString()} - {cutoffdate.ToShortDateString()}";
        }
        public static  Result<DTRHead> Create(int id, DateTime startdate, DateTime cutoffdate)
        {
            if (cutoffdate <= startdate)
                return Result.Failed<DTRHead>("Invalid Date Range");
            var dtrhead=  new DTRHead(id, startdate, cutoffdate);
            return Result.Ok(dtrhead);
        }
        public void ComputeAmount()
        {
            TotalAmount = Dtrs.Sum(m => m.NetPay);
        }

        public  Result<DTR> SearchDTR(string employeename, DateTime datetimein)
        {
            if (employeename == null)
                return Result.Failed<DTR>("employee is null");

            var dtr = Dtrs.Where(m => m.EmployeeName == employeename && m.TimeIn.Date == datetimein.Date);
            if (dtr.Count() == 0)
                return Result.Failed<DTR>("employee is not found");
            return Result.Ok(dtr.First());
        }

        public Result Add(DTR dtr)
        {
            try
            {
                var result = SearchDTR(dtr.EmployeeName, dtr.TimeIn);

                if (result.isOk )
                    return Result.Failed("TimeRecord alerady exist");

                Dtrs.Add(dtr);
            } 
            catch (Exception err)
            {
                return Result.Failed(err.Message);
            }
            return Result.Ok();
        }
        public int RemoveDTR(int dtrid)
        {
            return Dtrs.RemoveAll(m => m.Id == dtrid);

        }
    }
}
