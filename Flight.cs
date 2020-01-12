using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examine2
{
    class Flight
    {
        private string flightNumber;
        private string departure;
        private string arrival;
        private DateTime departureTime;
        private DateTime arrivalTime;

        public string FlightNumber => this.flightNumber;

        public string Departure => this.departure;

        private string Arrival => this.arrival;

        public DateTime DepartureTime => this.departureTime;

        public DateTime ArrivalTime => this.arrivalTime;

        public Flight(string number, string dep, string arr, DateTime depTime, DateTime arrTime)
        {
            this.flightNumber = number;
            this.departure = dep;
            this.arrival = arr;
            this.departureTime = depTime;
            this.arrivalTime = arrTime;
        }

        public override string ToString()
        {
            return $"Flight:    num: {this.flightNumber}, dep: {this.departure}, arr: {this.arrival}, dep time: {this.departureTime}, arr time: {this.arrivalTime}";
        }

    }
}
