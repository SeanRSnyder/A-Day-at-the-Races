using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    public class Bet:Greyhound
    {
       
        public decimal Amount;
        public string Dog;
        public Guy Bettor;
        public decimal odds;
        public decimal DBodds;
       

        public string GetDescription()
        {
            if (Amount == 0)
                return Bettor.Name + "hasn't placed a bet";
            else
                return Bettor.Name + " placed a bet of " + Amount + " dollars on " + Dog;
        }
     
        public decimal PayOut(string Winner)
        {
            if (Winner == Dog)
                return Amount * odds;
            else
                return (0 - Amount);
        }
    }
}
