using Xunit;

namespace FerryFunction.Test;

public class UnitTest1
{
    Ferry myBoard = new Ferry();
    [Fact]
    public void ItShouldReturnAcceptedIfCarsNumberIsNotExceeded()
    {
        Assert.Equal("Accepted", myBoard.Board(new Car("yellow", 3, "ZA 745")));  
    }

    [Fact]
    public void ItShouldReturnRejectedIfCarsNumberIsExceeded()
    {
        myBoard.Board(new Car("blue", 1, "QA 451"));
        myBoard.Board(new Car("green", 2, "TA 555"));
        myBoard.Board(new Car("lime", 1, "RA 455"));
        myBoard.Board(new Car("orange", 3, "AM 522"));
        myBoard.Board(new Car("lightblue", 1, "RA 412"));
        myBoard.Board(new Car("skyblue", 1, "NA 147"));
        myBoard.Board(new Car("red", 1, "C 5428"));
        myBoard.Board(new Car("blue", 1, "L 215"));
        myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
        Assert.Equal("Rejected", myBoard.Board(new Car("yellow", 1, "QA 475")));  
    }
       [Fact]
    public void ItShouldReturnRejectedIfCarsCountAmdPeopleCountIsExceeded()
    {
        myBoard.Board(new Car("blue", 5, "QA 451"));
        myBoard.Board(new Car("green", 2, "TA 555"));
        myBoard.Board(new Car("lime", 1, "RA 455"));
        myBoard.Board(new Car("orange", 3, "AM 522"));
        myBoard.Board(new Car("lightblue", 1, "RA 412"));
        myBoard.Board(new Car("skyblue", 5, "NA 147"));
        myBoard.Board(new Car("red", 1, "C 5428"));
        myBoard.Board(new Car("blue", 1, "L 215"));
        myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
         myBoard.Board(new Car("pink", 1, "FD 584"));
        Assert.Equal("Rejected", myBoard.Board(new Car("yellow", 1, "QA 475")));  
    }

    [Fact]
    public void ItShouldReturnHalfPriceIfBoardedMoreThan3Times()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "QA 456"));
        Assert.Equal("Half price", myBoard.Board(new Car("pink", 2, "XA 555")));  
    }

       [Fact]
    public void ItShouldFreeToGoIfBoarded7Times()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        Assert.Equal("You go free!", myBoard.Board(new Car("pink", 2, "XA 555")));  
    }

    [Fact]
    public void ItShouldFreeToGoIfBoardedMoreThan7Times()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        Assert.Equal("Accepted", myBoard.Board(new Car("pink", 2, "XA 555")));  
    }

    [Fact]
    public void ItShouldReturnNumberOfCarsOfASpecificColor()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("yellow", 1, "XA 555"));
        myBoard.Board(new Car("brown", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        Assert.Equal("There are 8 pink cars in the Board", myBoard.CarsOfACertainColor("pink"));  
    }
    [Fact]
     public void ItShouldReturnMessageIfCarsOfASpecificColorAreNotOnBoard()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("yellow", 1, "XA 555"));
        myBoard.Board(new Car("brown", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        Assert.Equal("There are no lime cars in the Board", myBoard.CarsOfACertainColor("lime"));  
    }

    [Fact]
    public void ItShouldReturnAMessageWhenACarLeavesTheBoard()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("yellow", 1, "XA 555"));
        myBoard.Board(new Car("brown", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        Assert.Equal("pink car with 2 passengers has been left", myBoard.CarLeaving(new Car("pink", 2, "XA 555")));   
    }

    [Fact]
    public void ItShouldReturnAMessageWhenACarIsNotOnBoard()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("yellow", 1, "XA 555"));
        myBoard.Board(new Car("brown", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));
        Assert.Equal("orange car with 2 passengers is not on Board", myBoard.CarLeaving(new Car("orange", 2, "XA 555")));   
    }

    [Fact]
    public void ItSHouldReturnAList()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("yellow", 1, "XA 555"));
        myBoard.Board(new Car("brown", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));

        Assert.Equal(myBoard.carsOnBoard, myBoard.getList());   
    }

    [Fact]
    public void ItSHouldReturnTheList()
    {
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("pink", 2, "XA 555"));
        myBoard.Board(new Car("yellow", 1, "XA 555"));
        myBoard.Board(new Car("brown", 1, "XA 555"));
        myBoard.Board(new Car("pink", 1, "XA 555"));

        Assert.Equal(myBoard.CarList, myBoard.listOfCars());   
    }


}