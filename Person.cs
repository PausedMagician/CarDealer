class Person : Carowner
{
    // public Car_Class[] Cars_Owned = {};
    public Engine[] Engines_Owned = {};
    public int Money = 0;
    // public int[] Coordinates = {25, 10};

    public void Inventory(){
        
    }
    public Person() {
        Cars = new Car_Class[] {new Car_Class("Cirtoen","c3",2500,0.3f,10,1500)};
    }

}