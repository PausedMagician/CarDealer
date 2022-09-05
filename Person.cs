class Person
{
    // public Car_Class[] Cars_Owned = {};
    public Engine[] Engines_Owned = {};
    public int Money = 0;
    // public int[] Coordinates = {25, 10};

    public void Inventory(){
        
    }
    public Person() {
        Cars = new Car_Class[] {new Car_Class("Cineort","3C",2500,0.2f,10,1500)};
    }
    public Car_Class[] Cars;
    public void listcars(int selectedLine)
    {
        Console.SetCursorPosition(0,3);
        Console.WriteLine("Cars("+Cars.Length+"):");
        Console.SetCursorPosition(0,5);
        Console.Write("Brand:");
        Console.SetCursorPosition(15,5);
        Console.Write("Name:");
        Console.SetCursorPosition(40,5);
        Console.Write("Weigth:");
        Console.SetCursorPosition(48,5);
        Console.Write("Aero:");
        Console.SetCursorPosition(55,5);
        Console.Write("Price:");
        int Line = 6;
        foreach (Car_Class car in Cars)
        {
            string[] stats = car.getstats();
            if (selectedLine+6 == Line) 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(56,Line);
                Console.Write("<");
            }
            else Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0,Line);
            Console.Write(stats[0]);
            Console.SetCursorPosition(15,Line);
            Console.Write(stats[1]);
            Console.SetCursorPosition(40,Line);
            Console.Write(stats[2]);
            Console.SetCursorPosition(48,Line);
            Console.Write(stats[3]);
            Console.SetCursorPosition(55,Line);
            Console.Write(stats[4]);
            Line++;
        }
        if (selectedLine == 100) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(56,47);
            Console.Write("<");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.SetCursorPosition(0,47);
        Console.WriteLine("Go back");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(0,48);
    }

    public void listengines(int selectedLine)
    {
        Console.SetCursorPosition(0,3);
        Console.WriteLine("Engines("+Engines_Owned.Length+"):");
        Console.SetCursorPosition(0,5);
        Console.Write("Horespower:");
        Console.SetCursorPosition(14,5);
        Console.Write("Torque:");
        Console.SetCursorPosition(24,5);
        Console.Write("Max RPM:");
        Console.SetCursorPosition(34,5);
        Console.Write("Price:");
        int Line = 6;
        foreach (Engine engine in Engines_Owned)
        {
            string[] stats = engine.getstats();
            if (selectedLine+6 == Line) 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(56,Line);
                Console.Write("<");
            }
            else Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0,Line);
            Console.Write(stats[0]);
            Console.SetCursorPosition(14,Line);
            Console.Write(stats[1]);
            Console.SetCursorPosition(24,Line);
            Console.Write(stats[2]);
            Console.SetCursorPosition(34,Line);
            Console.Write(stats[3]);
            Line++;
        }
        if (selectedLine == 100) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(56,47);
            Console.Write("<");
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.SetCursorPosition(0,47);
        Console.WriteLine("Go back");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(0,48);
    }


}