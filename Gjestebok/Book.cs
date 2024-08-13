using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class Book
    {
        public List<Party> parties { get; set; } = [];
        public string DateString { get; set; }

        public Book(string date)
        {
            DateString = date;
        }

        public void AddParty(Party newParty)
        {
            parties.Add(newParty);
        }

        public void FindParty(string name)
        {
            var match = parties.Where(party => party.ReservationName.Split(' ').Any(part => part.StartsWith(name, StringComparison.OrdinalIgnoreCase)));
            foreach (Party m in match)
            {
                m.PrintNameAndGuestNum();
            } 
        }

        public void PrintBookList()
        {
            foreach (Party p in parties)
            {
                p.PrintNameAndGuestNum();
            }
        }

        public void PrintDetailedBookList()
        {
            foreach (Party p in parties)
            {
                p.PrintAllGuests();
            }
        }
    }
};

