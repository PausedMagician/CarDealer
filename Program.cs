Console.SetBufferSize(180, 50);
Console.SetWindowSize(180, 50);
Console.Title = "Car Dealer The Game";

void Map(Person _person)
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

    Console.SetCursorPosition(0, 47);
}




#region Classes In The Making
Dealer car_Dealer = new Dealer("Cars"); //This class you need to create yourself!

// Engines

Person player = new Person();
#endregion

while(true){
    Map(player);

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Write an action [buy, sell, exit]\n");

    string input = Console.ReadLine();
    input = input.ToLower();
    switch (input)
    {
        case "buy":
            //Car myNewCar = dealer.buy(...);
            break;
        case "shop":
            int selected = 3;
            while (true)
            {
            car_Dealer.listcars(selected);
            ConsoleKey inputKey = Console.ReadKey().Key;
            switch(inputKey){
                case ConsoleKey.DownArrow:
                    if(selected < car_Dealer.Cars.Length+2){
                        selected +=1;
                    }else if(selected == car_Dealer.Cars.Length+2){
                        selected = 100;
                    }else if (selected == 100){
                        selected = 101;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if(selected > 3 && selected < 100){
                        selected -=1;
                    }else if(selected == 100){
                        selected = car_Dealer.Cars.Length+2;
                    }else if (selected == 101){
                        selected = 100;
                    }
                    break;
                default:
                    break;
            }
            }
            break;
        case "coord":
            string coord = Console.ReadLine();
            string[] spliited = coord.Split(" ");
            Console.WriteLine(spliited[0]);
            Console.WriteLine(spliited[1]);
            player.Coordinates[0] = int.Parse(spliited[0]);
            player.Coordinates[1] = int.Parse(spliited[1]);
            Console.Write(player.Coordinates[0]);
            Console.Write(player.Coordinates[1]);
            Console.ReadKey();
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
    }
    Console.Clear();
}
