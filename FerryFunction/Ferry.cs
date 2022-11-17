namespace FerryFunction;

public class Ferry
{
    public int NumberOfCars;
    public int NumberOfPeople;
    public int PeopleCount{get; set;}
    public int CarCount{get; set;}
    public Ferry()
    {
        NumberOfCars = 5;
        NumberOfPeople = 10;
    }
    public string Board(Car test)
    {
        PeopleCount += test.NumberOfPassengers;
        CarCount++;
       if(NumberOfPeople >= PeopleCount && NumberOfCars >= CarCount)
       {
        return "Accepted";
       }
       else
       {
        return "Rejected";
       }
    }
}