using OOPCar;

string[] makes =
{
    "Volvo v70",
    "Volvo c30",
    "Volvo XC60",
    "Volvo XC90",
    "Volvo XC40",
    "BMW x5",
    "BMW x1",
    "BMW z4",
    "BMW 7-serie",
    "BMW 3-serie",
    "Audi A1",
    "Audi A3",
    "Audi A4",
    "Audi A5",
    "Audi A6",
    "Audi A7",
    "Audi A8",
    "SAAB 95",
    "SAAB 93",
    "Seat Arona",
    "Seat Ateca",
    "Seat Ibiza",
    "Seat Léon",
    "Seat Tarraco",
    "Polestar 1",
    "Polestar 2"
};
string[] colors =
{
    "Röd",
    "Svart",
    "Blå",
    "Grön",
    "Vit"
};

var carList = new Stack<Car> { };
for (var i = 100; i > 0; i--)
{
    var rand = new Random();
    var car = new Car
    {
        _id = i,
        Color = colors[rand.Next(0, colors.Length)],
        Debug = false,
        Make = makes[rand.Next(0, makes.Length)]
    };
    carList.Push(car);
}

foreach (var x in carList)
{
    x.Print();
}