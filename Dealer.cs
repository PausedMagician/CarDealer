class Dealer 
{

    private string Type;

    public Dealer(string _Type){
        this.Type = _Type;
    }

    public Car_Class[] Cars = 
    {
        new Car_Class("VW","Passat",2500,0.2f),
        new Car_Class("VW","brød",2500,0.2f),
        new Car_Class("VW","ikke Passat",2500,0.2f)
    };
    private Engine[] engines = {new Engine(200,200)};

    public bool buycar() 
    {
        return false;
    }
    public bool sellcar() 
    {
        return false;
    }
    public void listcars(int selectedLine)
    {
        Console.Clear();
        Console.SetCursorPosition(0,0);
        Console.WriteLine("Cars in stock:");
        Console.SetCursorPosition(0,2);
        Console.Write("Brand:");
        Console.SetCursorPosition(7,2);
        Console.Write("Name:");
        Console.SetCursorPosition(30,2);
        Console.Write("Weigth:");
        Console.SetCursorPosition(38,2);
        Console.Write("Aero:");
        int Line = 3;
        foreach (Car_Class car in Cars)
        {
            string[] stats = car.getstats();
            if (selectedLine == Line) 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(45,Line);
                Console.Write("<");
            }
            else Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0,Line);
            Console.Write(stats[0]);
            Console.SetCursorPosition(7,Line);
            Console.Write(stats[1]);
            Console.SetCursorPosition(30,Line);
            Console.Write(stats[2]);
            Console.SetCursorPosition(38,Line);
            Console.Write(stats[3]);
            Line++;
        }
        Console.SetCursorPosition(0,46);
        if (selectedLine == 100) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sell car                                     <");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sell car");
        }
        if (selectedLine == 101) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Go back                                      <");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Go back");
        }
        Console.SetCursorPosition(0,48);
    }
    public string listengines()
    {
        return "";
    }
}