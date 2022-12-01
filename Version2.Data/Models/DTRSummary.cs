using Payroll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ValueObjects.ValueObject;
using Version2.Data.Interface;

namespace Version2.Data.Models
{
    public class DTRSummaryDto : Entity
    {
        public int DTRHeadId { get; set; }
        public string EmployeeId { get; set; }
        public decimal Amount { get; private set; } = 0;
    }
    public class CreateorEditDTRSummaryDto : Entity
    {

        public int DTRHeadId { get; set; }
        public string EmployeeId { get; set; }
        public decimal Amount { get; set; } = 0;

    }
    public class DTRSummary : Entity  , IEntity
    {
        public int DTRHeadId { get; set; } = 0;
        public string EmployeeId { get; set; }
        public decimal Amount { get; set; } = 0;
        public List<DTR> dTRs { get; set; }
        protected DTRSummary(int dTRHeadId, string employeeId)
        {
            if (dTRHeadId<=0)
                throw new Exception("Parent Id required");

            if (string.IsNullOrEmpty(employeeId))
                throw new Exception("Employee Id required");

            DTRHeadId = dTRHeadId;
            EmployeeId = employeeId;
        }
        public static Result<DTRSummary> Create(int dTRHeadId, string employeeId)
        {

            var dtrhead = new DTRSummary(dTRHeadId, employeeId);
            return Result.Ok(dtrhead);
        }
        public void GetTotal()
        {
            Amount = dTRs.Sum(m => m.NetPay);
        }
    }
}
