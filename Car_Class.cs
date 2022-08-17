class Car_Class {

    #region States
    private int Gear = 0;
    private bool Ignition = false;
    private string Brand;
    private string Name;
    
    #endregion

    #region Cosmetics

    private ConsoleColor Color;

    #endregion

    #region Stats

    private int weight;
    private float aero;

    private int MaxSpeed;
    private float Acelleration;

    #endregion
    private Engine Car_Engine = new Engine(75, 128);

    public Car_Class(string brnd, string _name,int _weight, float _aero)
    {
        this.Brand = brnd;
        this.Name = _name;
        this.Car_Engine = new Engine(10, 10);
        this.weight = _weight;
        this.aero = _aero;
        
    }
    public void change_engine(Engine new_engine, Person _Person){
        _Person.Engines_Owned.Append(Car_Engine);
        Car_Engine = new_engine;
    }
    public void calulate_stats(){
        // this.Car_Engine.Horsepower*
        // this.MaxSpeed = 
        
    }
    public string[] getstats()
    {
        String[] output = {Brand,Name,weight.ToString(),aero.ToString()};
        return output;
    }
}
