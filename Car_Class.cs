class Car_Class {

    #region States
    private int Gear = 0;
    private bool Ignition = false;
    private string Brand;
    
    #endregion

    #region Cosmetics

    #endregion

    #region Stats

    private int weight;
    private int aero;

    #endregion
    private Engine Car_Engine;

    public Car_Class(string brnd)
    {
        this.Brand = brnd;
        this.Car_Engine = new Engine(10, 10);
        
    }
}
