using Xunit;

namespace FerryFunction.Test;

public class UnitTest1
{
    Ferry myBoard = new Ferry();
    [Fact]
    public void ItShouldReturnAcceptedIfCarsNumberIsNotExceeded()
    {
        Assert.Equal("Accepted", myBoard.Board(new Car("yellow", 3)));  
    }

    [Fact]
    public void ItShouldReturnRejectedIfCarsNumberIsExceeded()
    {
        myBoard.Board(new Car("blue", 1));
        myBoard.Board(new Car("green", 2));
        myBoard.Board(new Car("lime", 1));
        myBoard.Board(new Car("orange", 3));
        myBoard.Board(new Car("lightblue", 1));
        myBoard.Board(new Car("skyblue", 1));
        myBoard.Board(new Car("red", 1));
        myBoard.Board(new Car("blue", 5));
        myBoard.Board(new Car("pink", 1));
        Assert.Equal("Rejected", myBoard.Board(new Car("yellow", 1)));  
    }
}