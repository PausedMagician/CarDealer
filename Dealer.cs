class Dealer 
{

    private string Type;

    void Dealer(string Type){
        this._Type = Type;
    }

    public Car_Class[] Cars = {new Car_Class("F"),};
    public bool buycar() 
    {
        return false;
    }
    public bool sellcar() 
    {
        return false;
    }
}