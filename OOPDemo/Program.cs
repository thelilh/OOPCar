using OOPCar;

var car = new Car
{
    Make = "Volvo",
    Color = "Röd",
    Debug = true
};
var car2 = new Car
{
    Make = "Citroen",
    Color = "Svart"
};
Car[] cars = { car, car2 };
for (var i = 0; i < cars.Length; i++)
{
    cars[i].Print(i + 1);
}