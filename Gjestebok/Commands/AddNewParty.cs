using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gjestebok.Commands
{
    internal class AddNewParty : ICommand
    {
        public int Id => 1;
        public string Text => "Add new party";

        public void Execute()
        {
            "Type in the name of the person Responsible for the party.".PrintStringToConsole();
            string resName = "Full Name:".RequestUIString();
            Party newParty = new Party(resName);
            bool adding = AddingGuestsUIChoice();

            while (adding)
            {
                newParty.AddGuest(AddNewGuestUI());
                adding = AddingGuestsUIChoice();
            }
        }

        Party AddNewPartyUI()
        {
            "Type in the name of the person Responsible for the party.".PrintStringToConsole();
            string resName = "Full Name:".RequestUIString();
            Party newParty = new Party(resName);
            bool adding = AddingGuestsUIChoice();

            while (adding)
            {
                newParty.AddGuest(AddNewGuestUI());
                adding = AddingGuestsUIChoice();
            }
            return newParty;
        }

        Guest AddNewGuestUI()
        {
            string name = "Full name:".RequestUIString();
            Guest newGuest = new Guest(name);
            return newGuest;
        }

        public bool AddingGuestsUIChoice()
        {
            string answer = "Type 1 to add new guest, type anything else to quit making party: ".RequestUIString();

            return answer == "1";
        }
    }
}
