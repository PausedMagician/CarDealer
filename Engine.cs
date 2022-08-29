class Engine
{
    public int Horsepower;
    public int Torque;
    public int price;
    public int maxRPM;

    public Engine(int HP, int TQ, int _max_RPM, int _price){
        this.Horsepower = HP;
        this.Torque = TQ;
        this.price = _price;
        this.maxRPM = _max_RPM;
    }
    public string[] getstats()
    {
        String[] output = {Horsepower.ToString(),Torque.ToString(),maxRPM.ToString(),price.ToString()};
        return output;
    }
}