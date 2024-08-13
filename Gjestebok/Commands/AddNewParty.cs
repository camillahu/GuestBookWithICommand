using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Commands
{
    internal class AddNewParty : ICommand
    {
        public int Id => 1;
        public string Text => "Add new party";

        public void Execute(Book currentBook)
        {
            "Type in the name of the person Responsible for the party.".PrintStringToConsole();
            string resName = "Full Name:".RequestString();
            Party newParty = new Party(resName);
            bool adding = AddingGuestsChoice();

            while (adding)
            {
                newParty.AddGuest(AddNewGuest());
                adding = AddingGuestsChoice();
            }

            currentBook.AddParty(newParty);
        }

        Guest AddNewGuest()
        {
            string name = "Full name:".RequestString();
            Guest newGuest = new Guest(name);
            return newGuest;
        }

        public bool AddingGuestsChoice()
        {
            string answer = "Type 1 to add new guest, type anything else to quit making party: ".RequestString();

            return answer == "1";
        }
    }
}
