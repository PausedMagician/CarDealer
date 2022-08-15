

Dealer dealer = new Dealer(); //This class you need to create yourself!
while(true){
    Console.WriteLine("Write an action [buy, sell, exit]");
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
}