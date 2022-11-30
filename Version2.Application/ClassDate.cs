using System;
using System.Collections.Generic;
using System.Text;
using Version2.Data.Models;

namespace Version2.Application
{
    public static class ClassDate
    {
        public static DateTime GetDate(DateTime date, string time)
        {
            DateTime dt = DateTime.Now;
            try
            {
                dt = DateTime.Parse(date.ToShortDateString() + " " + time);
            }
            catch 
            {
                
            }
            return dt;
        }
    }
}
