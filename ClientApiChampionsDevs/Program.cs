using ClientApiChampionsDevs;

var carClient = new CarClient();

do
{
    Console.WriteLine();
    Console.WriteLine("Olá, o que você deseja?");
    Console.WriteLine("1 - listar carros");
    Console.WriteLine("2 - buscar carro por nome");
    Console.WriteLine("3 - adicionar carro");
    Console.WriteLine("4 - remover todos os carros");
    Console.WriteLine();
    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            var cars = carClient.GetCars();
            cars.ForEach(c => Console.WriteLine(c.ToString()));
            continue;
        case "2":
            Console.WriteLine("Digite o nome do carro:");
            var carName = Console.ReadLine();
            var car = carClient.GetCar(carName!);
            Console.WriteLine();
            Console.WriteLine(car.ToString());
            continue;
        case "3":
            Console.WriteLine("Digite o nome do carro:");
            var carNameToAdd = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o ano do carro:");
            var carYearToAdd = Console.ReadLine();
            var carToAdd = new Car(carNameToAdd!, int.Parse(carYearToAdd!));
            var addedCar = carClient.AddCar(carToAdd);
            Console.WriteLine();
            Console.WriteLine("Carro adicionado com sucesso.");
            Console.WriteLine(addedCar.ToString());
            continue;
        case "4":
            carClient.DeleteCars();
            Console.WriteLine("Todos os carros foram removidos.");
            continue;
        default:
            break;
    }
}
while (true);