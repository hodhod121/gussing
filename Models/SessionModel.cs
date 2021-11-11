using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber.Models
{
    public class SessionModel
    {
        public int random { get; set; }

        public SessionModel(int random)
        {
            this.random = random;
        }
    }
}
