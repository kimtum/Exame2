using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examine2
{
    class BoardingPass
    {
        static private int maxBonus;
        static private int avgBonus;
        static List<int> bonusList = new List<int>();
        static private int threshold;
        private Flight flight;
        private Passenger passenger;
        private int gate;
        private SeatArea seatArea = SeatArea.econom; 
        
        public Flight _Flight => this.flight;

        public Passenger _Passenger => this.passenger;

        public int Gate => this.gate;

        public SeatArea _SeatArea => this.seatArea;

        public BoardingPass(Passenger passenger, Flight flight)
        {
            this.flight = flight;
            this.passenger = passenger;
            Random rand = new Random();
            this.gate = rand.Next(1, 4);
            bonusList.Add(this.passenger.BonusPoint);
            if (this.passenger.BonusPoint > maxBonus)
                maxBonus = this.passenger.BonusPoint;
            foreach (int b in bonusList)
            {
                avgBonus += b;
            }
            avgBonus = avgBonus / bonusList.Count;
            threshold = avgBonus + ((maxBonus - avgBonus) / 4);
            if (this.passenger.BonusPoint > threshold)
                this.seatArea = SeatArea.business;
        }

            public override string ToString()
        {
            return $"BoardingPass:      {this.passenger}\n{this.flight}\nGate: {this.gate}, Seat area: {this.seatArea}";
        }
    
    }

    enum SeatArea 
    {
        econom,
        business,
    }
}
