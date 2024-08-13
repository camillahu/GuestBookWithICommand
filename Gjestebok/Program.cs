
using GuestBook;
using GuestBook.Commands;

Book currentBook = new Book(DateTime.Now.ToString("dd/MM/YYYY"));


List<ICommand?> commands =
[
    new AddNewParty(),
    new SearchForParty(),
    new SeeAllParties(),
    new SeeAllPartiesWithNames(),
    new Exit(),
];

MainMenu();
void MainMenu()
{
    bool mainMenuRunning = true;
    $"Welcome to today's book ({currentBook.DateString})".PrintStringToConsole();

    while (mainMenuRunning)
    {
        ViewCommands();
        ICommand? choice = ChooseOption();
        choice?.Execute(currentBook); //vits i å gjøre alt nullable?
        mainMenuRunning = true;
    }
}

ICommand? ChooseOption()
{
    ICommand? command = null;
    
    int input = "What do you want to do? ".RequestInt();
    command = commands.FirstOrDefault(c => c.Id == input);
    
    return command;
    }

void ViewCommands()
{
    foreach (ICommand? cmd in commands)
    {
        $"{cmd.Id}. {cmd.Text} ".PrintStringToConsole();
    }
}

