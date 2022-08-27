abstract class Carowner
{
    public Car_Class[] Cars;
    public void listcars(int selectedLine)
    {
        Console.SetCursorPosition(0,3);
        Console.WriteLine("Cars:");
        Console.SetCursorPosition(0,5);
        Console.Write("Brand:");
        Console.SetCursorPosition(10,5);
        Console.Write("Name:");
        Console.SetCursorPosition(30,5);
        Console.Write("Weigth:");
        Console.SetCursorPosition(38,5);
        Console.Write("Aero:");
        Console.SetCursorPosition(44,5);
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
            Console.SetCursorPosition(10,Line);
            Console.Write(stats[1]);
            Console.SetCursorPosition(30,Line);
            Console.Write(stats[2]);
            Console.SetCursorPosition(38,Line);
            Console.Write(stats[3]);
            Console.SetCursorPosition(44,Line);
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
}