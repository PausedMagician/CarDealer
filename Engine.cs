class Engine
{
    public int Horsepower;
    public int Torque;
    public int price;

    public Engine(int HP, int TQ, int _price){
        this.Horsepower = HP;
        this.Torque = TQ;
        this.price = _price;
    }
    public string[] getstats()
    {
        String[] output = {Horsepower.ToString(),Torque.ToString(),price.ToString()};
        return output;
    }
}