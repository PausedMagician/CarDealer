class Dealer : Person
{
    public Dealer(){
        Cars = new Car_Class[]
        {
            new Car_Class("VW","Passat",2500,0.2f,10,4000),
            new Car_Class("VW","brød",2500,0.2f,15,3500),
            new Car_Class("VW","ikke Passat",2500,0.2f,25,4500)
        };
        Engines_Owned = new Engine[]
        {
            new Engine(75, 128, 6000, 100),
            new Engine(100, 132, 6000, 5000),
            new Engine(128, 128, 8000, 10000)
        };
    }

    public bool buycar() 
    {
        return false;
    }
    public bool sellcar() 
    {
        return false;
    }
    public void menu(int selectedLine)
    {
        Console.SetCursorPosition(0,3);
        Console.WriteLine("Select option:");
        Console.SetCursorPosition(0,6);
        if (selectedLine == 1) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Buy car                                       <");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Buy car");
        }
        if (selectedLine == 2) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sell car                                      <");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sell car");
        }
        if (selectedLine == 3) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exit                                          <");
            Console.ForegroundColor = ConsoleColor.Blue;
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Exit");
        }
        Console.SetCursorPosition(0,48);
    }

    public void menu2(int selectedLine)
    {
        Console.SetCursorPosition(0,3);
        Console.WriteLine("Select option:");
        Console.SetCursorPosition(0,6);
        if (selectedLine == 1) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Buy engine                                       <");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Buy engine");
        }
        if (selectedLine == 2) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sell engine                                      <");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sell engine");
        }
        if (selectedLine == 3) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exit                                          <");
            Console.ForegroundColor = ConsoleColor.Blue;
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Exit");
        }
        Console.SetCursorPosition(0,48);
    }
}