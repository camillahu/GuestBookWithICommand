
using Gjestebok;
using Gjestebok.Commands;

Book currentBook = new Book(DateTime.Now.ToString("dd/MM/YYY"));
bool mainMenuRunning = true;

List <ICommand> commands =
[
    new AddNewParty()

];

MainMenu();
void MainMenu()
{
    $"Welcome to today's book ({currentBook.DateString})".PrintStringToConsole();

    while (mainMenuRunning)
    {
        ViewCommands();
    }
}

IEnumerable<ICommand> ChooseOption()
{
    int input = "What do you want to do?".RequestUIInt();
    IEnumerable<ICommand> command = commands.Where(c => c.Id == input);
    return command;

    "1. Add new party \n2. Search for party \n3. See all parties \n4. See all parties with names".PrintStringToConsole();
    string menuChoice = "Choose an option:".RequestUIString();
    switch (menuChoice)
    {
        case "1":
            currentBook.AddParty(AddNewPartyUI());
            mainMenuRunning = true;
            break;
        case "2":
            currentBook.FindParty();
            mainMenuRunning = true;
            break;
        case "3": currentBook.PrintBookList();
            mainMenuRunning = true;
            break;
        case "4": currentBook.PrintDetailedBookList();
            mainMenuRunning = true;
            break;
        default: Environment.Exit(1);
            break;
    }
}


void ViewCommands()
{
    foreach (ICommand cmd in commands)
    {
        $"{cmd.Id}. {cmd.Text} ".PrintStringToConsole();
    }
}

