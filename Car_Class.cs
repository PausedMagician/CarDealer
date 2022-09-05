class Car_Class {

    #region States
    private string Brand;
    private string Name;
    
    #endregion

    #region Stats

    private int price;
    private int appeal;
    private int weight;
    private float aero;

    #endregion
    private Engine Car_Engine = new Engine(75, 128, 6000, 0);

    public Car_Class(string brnd, string _name,int _weight, float _aero, int _appeal, int _price)
    {
        this.Brand = brnd;
        this.Name = _name;
        this.weight = _weight;
        this.aero = _aero;
        this.appeal = _appeal;
        this.price = _price;
    }
    public string getname()
    {
        return this.Brand+" "+this.Name;
    }
    public void change_engine(Engine new_engine, Person _Person){
        _Person.Engines_Owned.Append(Car_Engine);
        Car_Engine = new_engine;
    }
    public void calulate_stats(){
        // this.Car_Engine.Horsepower*
        // this.MaxSpeed = 
        
    }
    /// <summary>
    /// Returns the stats in the order, Brand, Name, Weight, Aero, Price.
    /// </summary>
    public string[] getstats()
    {
        String[] output = {Brand,Name,weight.ToString(),aero.ToString(),price.ToString()};
        return output;
    }
    public int getappeal ()
    {
        return appeal;
    }
    public int getacceleration ()
    {
        return ((Car_Engine.Torque*100)/weight);
    }
    public int getspeed ()
    {
        return (int)(Car_Engine.Horsepower+((-69)/(0.8+Math.Pow(((Car_Engine.Torque*aero)/(24)), 2)))+((Car_Engine.Horsepower-(Car_Engine.Torque+((Car_Engine.Horsepower)/(3))))/(0.8+Math.Pow(((Car_Engine.Torque*aero)/(24)), 2)))+Car_Engine.Torque);
    }
}
