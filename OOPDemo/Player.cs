namespace OOPCar
{
    public class Car
    {
        private string _make;
        public int _id;
        private string _color;

        public string Make
        {
            get { return _make.ToUpper(); }
            set { _make = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value.ToUpper(); }
        }
        public bool Debug { get; set; }
        public void Print()
        {
            switch (Color.ToLower())
            {
                case "röd":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "svart":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "blå":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "grön":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "vit":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine(":(");
                    break;
            }
            Console.WriteLine($"Bil #{_id} är en {Make} och har färgen {Color}");
            Console.ResetColor();
            if (!Debug) return;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ToString());
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Make: {Make}, _make: {_make}, Color: {Color}, _color: {_color}";
        }
    }
}
