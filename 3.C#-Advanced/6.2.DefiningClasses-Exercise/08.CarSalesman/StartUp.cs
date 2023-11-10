namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main()
        {
            var listEngines = new Dictionary<string, Engine>();
            var listCars = new List<Car>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var engineModel = engineInfo[0];
                var enginePower = int.Parse(engineInfo[1]);
                int? engineDisplacement = engineInfo.Length > 2 && int.TryParse(engineInfo[2], out int displacementValue) ? displacementValue : null;
                string? engineEfficiency = null;

                if (engineInfo.Length > 2 && engineDisplacement == null)
                {
                    engineEfficiency = engineInfo[2];
                }
                else
                {
                    engineEfficiency = engineInfo.Length > 3 ? engineInfo[3] : null;
                }
                listEngines[engineModel] = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
            }
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var carModel = carInfo[0];
                var carEngine = listEngines[carInfo[1]];
                int? carWeight = carInfo.Length > 2 && int.TryParse(carInfo[2], out int weight) ? weight : null;
                string? carColor = null;
                if (carInfo.Length > 2 && carWeight == null)
                {
                    carColor = carInfo[2];
                }
                else
                {
                    carColor = carInfo.Length > 3 ? carInfo[3] : null;
                }
                var car = new Car(carModel, carEngine, carWeight, carColor);
                listCars.Add(car);
            }
            foreach (var car in listCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}