using Payroll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ValueObjects.ValueObject;
 

namespace Version2.Data.Models
{
    public class DTRDto : Entity
    {

        public int DTRSummaryId { get; set; }
        public DateTime TimeIn { get; private set; }
        public DateTime TimeOut { get; private set; }
        public decimal TotalHours { get; private set; }
        public decimal RegularHours { get; private set; }
        public RateVO Rate { get; set; }
        public decimal TotalOT { get; private set; }
        public decimal Amount { get; private set; }
        public decimal OTAmount { get; set; }
        public decimal Deduction { get; private set; }
        public decimal NetPay { get; private set; }
        public string EmployeeName { get; private set; }
        public string EmployeeId { get; set; }
        public decimal Reghoursperday { get; private set; }
        public bool isChecked { get; set; } = false;  
    }
    public class CreateorEditDTRDto : Entity
    {

        public int DTRSummaryId { get; set; }
        public DateTime TimeIn { get;   set; }
        public DateTime TimeOut { get;   set; }
        public decimal TotalHours { get; private set; }
        public decimal RegularHours { get; private set; }
        public RateVO Rate { get; set; }
        public decimal TotalOT { get; private set; }
        public decimal Amount { get; private set; }
        public decimal OTAmount { get; set; }
        public decimal Deduction { get; private set; }
        public decimal NetPay { get; private set; }
        public string EmployeeName { get; set; }
        public string EmployeeId { get; set; }
        public decimal Reghoursperday { get; private set; }

    }
    public class DTR :Entity
    {
 
        public int DTRSummaryId { get; set; }
        public DateTime TimeIn { get; private set; }
        public DateTime TimeOut {get; private set;}
        public decimal TotalHours { get; private set; }
        public decimal RegularHours { get; private set; }
        public RateVO Rate { get;   set; }
        public decimal TotalOT { get; private set; }
        public decimal Amount { get; private set; }
        public decimal OTAmount { get; set; }
        public decimal Deduction { get; private set; }
        public decimal NetPay { get; private set; }
        public string  EmployeeName{ get;  set; }
        public string EmployeeId { get; set; }
        public decimal Reghoursperday { get; private set; }
        protected DTR()
        { }
        protected DTR(DateTime timeIn, DateTime timeOut, EmployeeDto employee,
            decimal reghoursperday   )
        {
            TimeIn = timeIn;
           
            EmployeeName = employee.EmployeeName;

            Rate = new RateVO(employee.Rate, new Settings(), Occassion.RegularOccassion());
            TimeOut = timeOut;
            Reghoursperday = reghoursperday;
            ComputeTotalHours();
            ComputeOTHours();
            
        }
        public static Result<DTR> Create(DateTime timeIn, DateTime timeOut, EmployeeDto employee)
        {
            if (!isTimeinLessTimeOut(timeIn,timeOut))
                return Result.Failed<DTR>("Timeout is less than timein");
            return Result.Ok(new DTR(timeIn, timeOut, employee, new Settings().hrperday ));
        }
        private static bool isTimeinLessTimeOut(DateTime timein, DateTime timeout)
        {
            if (timein>timeout)
            {
                return false;
            }
            return true;
        }
        private void ComputeTotalHours()
        {
            if (TimeIn == null)
                return;
            if (TimeOut == null)
                return;
            TotalHours = (decimal)TimeOut.Subtract(TimeIn).TotalHours;
            GetRegularHoursOnly();
            ComputeAmount();
        }
        private void GetRegularHoursOnly()
        {
            RegularHours =  TotalHours > Reghoursperday ? Reghoursperday : TotalHours;
        }
        private void ComputeAmount()
        {
            Amount = RegularHours * Rate.RateHr *  Rate.RatePct;
            ComputeNetPay();
        }
        private  void ComputeOTHours()
        {
            TotalOT = 0;
            if (TotalHours >= Reghoursperday)
            {
                TotalOT =(TotalHours - Reghoursperday) ;
                if (TotalOT > 0)
                {
                    TotalOT = ComputeOTMinutes(TotalOT);
                    TotalHours = Reghoursperday + TotalOT;
                }
            } 
            ComputeOTPay();
        }
        void computeminutes(ref decimal finalminute, decimal minutes, int start , int end)
        {
             
            if (minutes > start && minutes <= end)
            {
                finalminute = minutes <= start + 7 ? start : end;
            }
        }
        public decimal ComputeOTMinutes(decimal minutes)
        {
            decimal hr =  Math.Truncate(minutes);   
            decimal min = minutes - Math.Truncate(minutes);
            min = min * 60;
            decimal finalminute = 0;
            computeminutes(ref finalminute, min,  0, 15);
            computeminutes(ref finalminute, min, 15, 30);
            computeminutes(ref finalminute, min, 30, 45);
            computeminutes(ref finalminute, min, 45, 60);
            
            hr = hr + (finalminute / 60);

            return hr;  
        }
        private void ComputeOTPay()
        {
            OTAmount = TotalOT * Rate.RateHr * Rate.RateOTPct;
            ComputeNetPay();
        }
        private void ComputeNetPay()
        { 
            NetPay = Amount + OTAmount - Deduction;
        }
        public void setDeduction(decimal deduction)
        {
            if (deduction <= 0)
                throw new Exception("deduction must not be less than or equal to zero");
            Deduction = deduction;
            ComputeNetPay();
        }
    }
}
