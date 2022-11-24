namespace ClientApiChampionsDevs
{
    internal class Car
    {
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; } = default!;
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Year}";
        }
    }
}
