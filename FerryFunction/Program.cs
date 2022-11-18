using FerryFunction;

Ferry checkCars = new Ferry();

checkCars.Board(new Car("pink", 2, "XA 555"));
checkCars.Board(new Car("pink", 2, "XA 555"));
checkCars.Board(new Car("pink", 2, "XA 555"));
checkCars.Board(new Car("pink", 2, "XA 555"));
checkCars.Board(new Car("pink", 2, "XA 555"));
checkCars.Board(new Car("pink", 2, "XA 555"));
checkCars.Board(new Car("pink", 2, "XA 555"));

Console.WriteLine(checkCars.Board(new Car("pink", 4, "XA 555")));

// Console.WriteLine(checkCars.CarsOfACertainColor("pink"));
// checkCars.CarLeaving(new Car("pink", 2, "TA 4565"));
// checkCars.CarLeaving(new Car("yellow", 5, "PU 75152"));


// foreach (var item in checkCars.listOfCars())
// {
//     Console.WriteLine($"{item.Color}, {item.NumberOfPassengers}");
// }




