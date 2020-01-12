using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examine2
{
    class Passenger
    {
        private string name;
        private string company;
        private int bonusPoint;

        public string Name => this.name;

        public string Company => this.company;

        public int BonusPoint => this.bonusPoint;

        public Passenger(string name, string company = "", int bonus = 0)
        {
            this.name = name;
            this.company = company;
            this.bonusPoint = bonus;
        }

        public override string ToString()
        {
            return $"Passenger:     name: {this.name}, company: {this.company}, bonus: {this.bonusPoint}";
        }
    }
}
