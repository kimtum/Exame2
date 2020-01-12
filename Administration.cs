using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examine2
{
    class Administration
    {
        static Ticket CreateTicket(string name, string number, string dep, string arr, DateTime depTime, DateTime arrTime, 
            int bonus, string company)
        {
            Passenger passenger = new Passenger(name, company, bonus);
            Flight flight = new Flight(number, dep, arr, depTime, arrTime);
            Ticket ticket = new Ticket(flight, passenger);
            return ticket;
        }

        static BoardingPass TicketToBoartPass(Ticket ticket)
        {
            BoardingPass boardPass = new BoardingPass(ticket._Passenger, ticket._Flight);
            return boardPass;
        }

        static HashSet<BoardingPass> TicketListToBoardPassLIst(HashSet<Ticket> tickets)
        {
            HashSet<BoardingPass> boardings = new HashSet<BoardingPass>();
            foreach (Ticket ticket in tickets)
                boardings.Add(TicketToBoartPass(ticket));
            return boardings;
        }

        static void Print<T>(T item) 
        {
            Console.WriteLine(item);
        }

        

    }
}
