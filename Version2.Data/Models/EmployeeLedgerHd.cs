using System;
using System.Collections.Generic;
using System.Text;
using ValueObjects.ValueObject;
using Version2.Data.Interface;

namespace Version2.Data.Models
{
    public class EmployeeLedgerHd : Entity, IEntity
    {
         public int EmployeeId { get; set; }
         public int Year { get; set; }
        public Amount_Balance Medicines { get; set; }
        public Amount_Balance ConsultationLabDiagnostic { get; set; }
        public Amount_Balance Hospitalization { get; set; }


    }
}
