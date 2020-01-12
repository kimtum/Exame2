using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examine2
{
    class Ticket
    {
        private Flight flight;
        private Passenger passenger;

        public Flight _Flight => this.flight;

        public Passenger _Passenger => this.passenger;

        public Ticket(Flight flight, Passenger passenger) 
        {
            this.flight = flight;
            this.passenger = passenger;
        }

        public override string ToString()
        {
            return $"Ticket:    {this.passenger}\n{this.flight}";
        }

    }
}
