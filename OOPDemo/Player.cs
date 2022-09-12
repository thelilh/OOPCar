namespace OOPCar
{
    public class Car
    {
        private string _make;
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
        public void Print(int id)
        {
            Console.WriteLine($"Bil #{id} är en {Make} och har färgen {Color}");
            if (!Debug) return;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Make = {Make}, _make = {_make}, Color = {Color}, _color = {_color}");
            Console.ResetColor();
        }
    }
}
