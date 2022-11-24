using RestSharp;

namespace ClientApiChampionsDevs
{
    internal class CarClient
    {
        private readonly RestClient _restClient;

        public CarClient()
        {
            const string carApiBaseUrl = "http://localhost:5107/";

            _restClient = new RestClient(carApiBaseUrl);
        }

        public List<Car> GetCars()
        {
            var request = new RestRequest(resource: "cars");

            var cars = _restClient.Get<List<Car>>(request);

            return cars!;
        }

        public Car GetCar(string name)
        {
            var request = new RestRequest(resource: "car")
                .AddQueryParameter("name", name);

            var car = _restClient.Get<Car>(request);

            return car!;
        }

        public Car AddCar(Car carToAdd)
        {
            var request = new RestRequest(resource: "car")
                .AddJsonBody(carToAdd);

            var addedCar = _restClient.Post<Car>(request);

            return addedCar!;
        }

        public void DeleteCars()
        {
            var request = new RestRequest(resource: "cars");

            _restClient.Delete(request);
        }
    }
}
