using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Enum;
using Version2.Data.Interface;

namespace ValueObjects.ValueObject
{
    public class Amount_Balance : ValueObject 
    {
        public decimal Amount {get; private set;}
        public decimal Availed { get; private set; }
        public decimal Balance { get; set; }
        private Amount_Balance()
        {

        }
        public Amount_Balance(decimal amt )
        {
            if (amt < 0 )
                amt = 0;
            Amount = amt;
            Balance = amt;
           
        }
 
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Availed;
            yield return Balance;         
        }
    }
}
