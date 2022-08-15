class Dealer 
{

    private string Type;

    public Dealer(string _Type){
        this.Type = _Type;
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