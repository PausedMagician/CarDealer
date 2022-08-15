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
            case "Triangle":
                break;
            default:
                return;
        }
    }
    
    location(25, 10, "Dealership", "Square");



    Console.SetCursorPosition(0, 47);
}



Dealer car_Dealer = new Dealer("Cars"); //This class you need to create yourself!


while(true){
    Map(new Person());

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Write an action [buy, sell, exit]\n");

    string input = Console.ReadLine();
    switch (input)
    {
        case "buy":
            //Car myNewCar = dealer.buy(...);
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
