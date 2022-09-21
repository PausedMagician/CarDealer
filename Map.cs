class Map
{
    public void Draw(Person _person)
    {
        void location(int x, int y, string name, string shape){
            int _x = x-(name.Length/2);
            Console.SetCursorPosition(_x, y-1);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write(name);
            switch (shape)
            {
                #region Square
                case "Square":
                    for (var y_S = y; y_S < y+5; y_S++)
                    {
                        for (var x_S = _x; x_S < _x+10; x_S++)
                        {
                            Console.SetCursorPosition(x_S, y_S);
                            Console.Write("*");
                        }
                    }
                    break;
                #endregion
                #region Rectangle
                case "Rectangle":
                    for (var y_S = y; y_S < y+3; y_S++)
                    {
                        for (var x_S = _x; x_S < _x+15; x_S++)
                        {
                            Console.SetCursorPosition(x_S, y_S);
                            Console.Write("*");
                        }
                    }
                    break;
                #endregion
                #region Triangle
                case "Triangle":
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    for (int i = -1; i < 2; i++)
                    {
                        Console.SetCursorPosition(x+i, y+1);
                        Console.Write("*");
                    }
                    for (int i = -2; i < 3; i++)
                    {
                        Console.SetCursorPosition(x+i, y+2);
                        Console.Write("*");
                    }
                    for (int i = -3; i < 4; i++)
                    {
                        Console.SetCursorPosition(x+i, y+3);
                        Console.Write("*");
                    }
                    break;
                #endregion
                default:
                    return;
            }
        }
        
        location(25, 10, "Dealership", "Square");
        location(14, 11,"Engine Store", "Triangle");
        location(110, 7, "Dragstrip", "Rectangle");
        location(40, 30, "Carshow", "Triangle");
        location(140, 35, "Work", "Triangle");
        location(90, 25, "Streetrace", "Rectangle");
        location(75, 9, "Mechanic", "Square");

        Console.SetCursorPosition(0, 47);
    }
}