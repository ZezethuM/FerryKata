using System.Collections;
namespace FerryFunction;

public class Ferry
{
    public int NumberOfCars;
    public int NumberOfPeople;
    public int PeopleCount{get; set;}
    public int CarCount{get; set;}
    public Ferry()
    {
        NumberOfCars = 15;
        NumberOfPeople = 20;
    }
    public List<KeyValuePair<string, int>> carsOnBoard = new List<KeyValuePair<string, int>>();
    public List<Car> CarList = new List<Car>();
    public string Board(Car test)
    {
        int countTrips = 0;
        string helloToday = "";
        carsOnBoard.Add(new KeyValuePair<string, int>(test.Color, test.NumberOfPassengers));
        CarList.Add(new Car(test.Color, test.NumberOfPassengers, test.NumberPlate));

        PeopleCount += test.NumberOfPassengers;
        CarCount++;

        if(NumberOfPeople >= PeopleCount && NumberOfCars >= CarCount)
        {
            foreach (var item in CarList)
            {
                if(item.NumberPlate == test.NumberPlate && item.Color == test.Color)
                {
                    countTrips++;
                    if(countTrips >= 3 && countTrips < 7)
                    {
                        helloToday = "Half price";
                    }
                    else if(countTrips >= 7 && countTrips <= 9)
                    {
                        helloToday = "You go free!";
                    }
                    else
                    {
                        helloToday =  "Accepted";
                    }
                }
            }
        }
        else
        {
            helloToday =  "Rejected";
        }
        return helloToday;
    }
    public string CarsOfACertainColor(string color)
    {
        int count = 0;
        foreach (var item in carsOnBoard)
        {
            if(item.Key == color)
            {
                count++;
            }
        }
        if(count == 0)
        {
            return $"There are no {color} cars in the Board";
        }
        return $"There are {count} {color} cars in the Board";
    }
    public List<KeyValuePair<string, int>>  getList()
    {
        return carsOnBoard;
    }
    public List<Car> listOfCars()
    {
        return CarList;
    }
    public string CarLeaving(Car leaving)
    {
        if(carsOnBoard.Contains(new KeyValuePair<string, int>(leaving.Color,leaving.NumberOfPassengers)))
        {
            carsOnBoard.Remove(new KeyValuePair<string, int>(leaving.Color, leaving.NumberOfPassengers));
            CarCount--;
            PeopleCount -= leaving.NumberOfPassengers;
            return leaving.Color + " car with " + leaving.NumberOfPassengers + " passengers has been left";
        }
        else
        {
            return leaving.Color + " car with " + leaving.NumberOfPassengers + " passengers is not on Board";
        }
    }
}