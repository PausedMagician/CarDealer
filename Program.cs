using System.Diagnostics;
using System.Net;
using System.IO;

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
    location(75, 9, "Mechanic", "Square");

    Console.SetCursorPosition(0, 47);
}

void info(Person _person, int day)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.SetCursorPosition(0,0);
    Console.WriteLine();
    Console.WriteLine("####################################################################################################################################################################################");
    Console.SetCursorPosition(0,0);
    Console.Write(" Day: ");
    Console.Write(day.ToString());
    Console.SetCursorPosition(100,0);
    Console.Write("Car: ");
    Console.Write(_person.Cars[0].getname());
    Console.SetCursorPosition(150,0);
    Console.Write("Money: ");
    Console.Write(_person.Money.ToString());
}

void writeToScreen(string variable){
    Console.Clear();
    Console.SetCursorPosition(90-variable.Length, 25);
    Console.Write(variable);
}

#region Classes In The Making
Dealer car_Dealer = new Dealer();
Dealer engine_Dealer = new Dealer();


// Engines

Person player = new Person();
#endregion

var day = 0;
int selected;
bool shopping;


List<Car_Class> new_thingymagic = car_Dealer.Cars.ToList();

foreach (string file in Directory.EnumerateFiles("../CarDealer/Cars", "*.txt"))
{
    string contents = File.ReadAllText(file);
    writeToScreen("Loading cars...");
    Console.SetCursorPosition(90-file.Length, 26);
    Console.Write(file);
    Console.SetCursorPosition(90-contents.Length, 27);
    Console.WriteLine(contents);
    string[] thesplit = contents.Split(", ");
    Car_Class somecar = new Car_Class(thesplit[0], thesplit[1], int.Parse(thesplit[2]), float.Parse(thesplit[3]), int.Parse(thesplit[4]), int.Parse(thesplit[5]));
    new_thingymagic.Add(somecar);
    Thread.Sleep(500);
}
car_Dealer.Cars = new_thingymagic.ToArray();

while(true){
    Console.Clear();
    info(player, day);
    Map(player);

    Console.ForegroundColor = ConsoleColor.Blue;
    // Console.Write("Write an action [buy, sell, exit]\n");
    Console.Write("Choose where to go\n");
    
    string input = Console.ReadLine() ?? throw new NullReferenceException();
    if (input == "") continue;
    input = input.ToLower();
    switch (input)
    {
        case "mechanic":
            break;
        case "engine":
        case "store":
        case "engine store":
            selected = 1;
            shopping = true;
            while (shopping)
            {
                Console.Clear();
                info(player,day);
                engine_Dealer.menu2(selected);
                ConsoleKey inputKey = Console.ReadKey().Key;
                switch (inputKey)
                {
                    case ConsoleKey.DownArrow:
                        if (selected < 3)
                        {
                            selected++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (selected > 1)
                        {
                            selected--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (selected == 1)
                        {
                            selected = 0;
                            bool buying = true;
                            while (buying)
                            {
                                Console.Clear();
                                info(player,day);
                                engine_Dealer.listengines(selected);
                                inputKey = Console.ReadKey().Key;
                                switch(inputKey){
                                    case ConsoleKey.DownArrow:
                                        if(selected < engine_Dealer.Engines_Owned.Length-1){
                                            selected++;
                                        }else if(selected == engine_Dealer.Engines_Owned.Length-1){
                                            selected = 100;
                                        }
                                        break;
                                    case ConsoleKey.UpArrow:
                                        if(selected > 0 && selected < 100){
                                            selected--;
                                        }else if(selected == 100){
                                            selected = engine_Dealer.Engines_Owned.Length-1;
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                        //BUY ENGINE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        buying = false;
                                        selected = 3;
                                        break;
                                    default:
                                        break;
                                }   
                            }
                        } else if (selected == 2)
                        {
                            selected = 0;
                            bool selling = true;
                            while (selling)
                            {
                                Console.Clear();
                                info(player,day);
                                player.listengines(selected);
                                inputKey = Console.ReadKey().Key;
                                switch(inputKey){
                                    case ConsoleKey.DownArrow:
                                        if(selected < player.Engines_Owned.Length-1){
                                            selected++;
                                        }else if(selected == player.Engines_Owned.Length-1){
                                            selected = 100;
                                        }
                                        break;
                                    case ConsoleKey.UpArrow:
                                        if(selected > 0 && selected < 100){
                                            selected--;
                                        }else if(selected == 100){
                                            selected = player.Engines_Owned.Length-1;
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                        // SELL ENGINE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        selling = false;
                                        selected = 3;
                                        break;
                                    default:
                                        break;
                                }   
                            }
                        } else if (selected == 3)
                        {
                            shopping = false;
                            break ;
                        }
                        break;
                    default:
                        break;
                }            
            }
            day --;
            break;
        case "car":
        case "dealer":
        case "cardealer":
        case "dealership":
            selected = 1;
            shopping = true;
            while (shopping)
            {
                Console.Clear();
                info(player,day);
                car_Dealer.menu(selected);
                ConsoleKey inputKey = Console.ReadKey().Key;
                switch (inputKey)
                {
                    case ConsoleKey.DownArrow:
                        if (selected < 3)
                        {
                            selected++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (selected > 1)
                        {
                            selected--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (selected == 1)
                        {
                            selected = 0;
                            bool buying = true;
                            while (buying)
                            {
                                Console.Clear();
                                info(player,day);
                                car_Dealer.listcars(selected);
                                inputKey = Console.ReadKey().Key;
                                switch(inputKey){
                                    case ConsoleKey.DownArrow:
                                        if(selected < car_Dealer.Cars.Length-1){
                                            selected++;
                                        }else if(selected == car_Dealer.Cars.Length-1){
                                            selected = 100;
                                        }
                                        break;
                                    case ConsoleKey.UpArrow:
                                        if(selected > 0 && selected < 100){
                                            selected--;
                                        }else if(selected == 100){
                                            selected = car_Dealer.Cars.Length-1;
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                        car_Dealer.buycar(selected,player);
                                        buying = false;
                                        selected = 3;
                                        break;
                                    default:
                                        break;
                                }   
                            }
                        } else if (selected == 2)
                        {
                            selected = 0;
                            bool selling = true;
                            while (selling)
                            {
                                Console.Clear();
                                info(player,day);
                                player.listcars(selected);
                                inputKey = Console.ReadKey().Key;
                                switch(inputKey){
                                    case ConsoleKey.DownArrow:
                                        if(selected < player.Cars.Length-1){
                                            selected++;
                                        }else if(selected == player.Cars.Length-1){
                                            selected = 100;
                                        }
                                        break;
                                    case ConsoleKey.UpArrow:
                                        if(selected > 0 && selected < 100){
                                            selected--;
                                        }else if(selected == 100){
                                            selected = player.Cars.Length-1;
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                        // SELL CAR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        selling = false;
                                        selected = 3;
                                        break;
                                    default:
                                        break;
                                }   
                            }
                        } else if (selected == 3)
                        {
                            shopping = false;
                            break ;
                        }
                        break;
                    default:
                        break;
                }            
            }
            day --;
            break;
        // case "coord":
        //     string coord = Console.ReadLine();
        //     string[] spliited = coord.Split(" ");
        //     Console.WriteLine(spliited[0]);
        //     Console.WriteLine(spliited[1]);
        //     player.Coordinates[0] = int.Parse(spliited[0]);
        //     player.Coordinates[1] = int.Parse(spliited[1]);
        //     Console.Write(player.Coordinates[0]);
        //     Console.Write(player.Coordinates[1]);
        //     Console.ReadKey();
        //     break;
        case "work":
            player.Money += 100;
            break;
        case "streetrace":
        case "race":
            // for (int distance = 0;;distance++)
            // {
            //     int start = distance%6;
            //     for (int i = 48+start; i > start; i--)
            //     {
            //         if (i%6>2) Console.WriteLine("      #                  #");
            //         else Console.WriteLine("                          ");
            //     }
            //     System.Threading.Thread.Sleep(50);
            // }
            player.Money += player.Cars[0].getspeed();
            break;
        case "carshow":
        case "show":
            player.Money += player.Cars[0].getappeal()*10; // +brand
            break;
        case "drag":
        case "dragstrip":
            player.Money += player.Cars[0].getacceleration();
            break;
        case "inventory":
        case "inv":
            Console.Clear();
            info(player,day);
            player.listcars(100);
            Console.ReadKey();
            day--;
            break;
        case "exit":
            System.Environment.Exit(5318008);
            break;
        case "bad game":
            Console.Clear();
            Console.SetCursorPosition(85, 25);
            Console.Write("Not cool...");
            Thread.Sleep(2500);
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostEntry(host);
            for (var y = 0; y < ip.AddressList.Length; y++)
            {
                var printlist = ip.AddressList[y].ToString().ToCharArray();
                for (var i = 0; i < printlist.Length; i++)
                {
                    Console.SetCursorPosition(85+i-(printlist.Length/3), 26+y);
                    Console.Write(printlist[i]);
                    Thread.Sleep(250);
                }
            }
            Thread.Sleep(2500);
            // Process.Start("shutdown","/s /t 0");
            System.Environment.Exit(404);
            break;
        default:
            day--;
            break;
    }
    day++;
}
