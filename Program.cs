using System.Diagnostics;
using System.Net;
using System.IO;

Console.SetBufferSize(180, 50);
Console.SetWindowSize(180, 50);
Console.Title = "Car Dealer The Game";

Map map = new Map();

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
var cheat = 0;
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
    Thread.Sleep(5);
}
car_Dealer.Cars = new_thingymagic.ToArray();

while(true){
    Console.Clear();
    info(player, day);
    map.Draw(player);

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
                                        buying = false;
                                        if (selected == 100) {selected = 3; break;}
                                        car_Dealer.buycar(selected, player);
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
                                        selling = false;
                                        selected = 3;
                                        if (selected == 100) break;
                                        car_Dealer.sellcar(selected, player);
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
        case "shit game":
        case "fucking game":
        case "dumb game":
        case "fuck you":
        case "you bitch":
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
        case "cheat":
            if (cheat==10) {
                cheat=0;
                for (var i = 0; i < 10; i++)
                {
                    player.Money += 1000000000;
                }
                Console.Clear();
                var text_10 = "Please just leave...";
                Console.SetCursorPosition(85-text_10.Length/2, 25);
                Console.Write(text_10);
                Thread.Sleep(750);
                day--;
                break;
            }
            cheat+=1;
            player.Money -= 1000000000;
            Console.Clear();
            string text = "Oh my, you broke it!";
            switch (cheat)
            {
                case 1:
                    text = "you can't do that!";
                    break;
                case 2:
                    text = "nice try...!?";
                    break;
                case 3:
                    text = "nice try...?";
                    break;
                case 4:
                    text = "please stop?";
                    break;
                case 5:
                    text = "please...?";
                    break;
                case 6:
                    text = ":(";
                    break;
                case 7:
                    text = "this...";
                    break;
                case 8:
                    text = "Why are you doing this?";
                    break;
                case 9:
                    text = "...";
                    break;
                case 10:
                    text = "I... give up...";
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(85-text.Length/2, 25);
            Console.Write(text);
            Thread.Sleep(2500);
            day--;
            break;
        default:
            day--;
            break;
    }
    day++;
}
