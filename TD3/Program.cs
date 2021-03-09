using System;
using System.Net.Http;

namespace TD3
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            Request request = new Request();
            Utils utils = new Utils();

            string answer;

            if (args.Length < 1)
            {
                answer = request.getContracts(client);
                Contract[] contracts = System.Text.Json.JsonSerializer.Deserialize<Contract[]>(answer);
                utils.displayContracts(contracts);
            }

            if (args.Length == 1)
            {
                answer = request.getStations(client, args[0]);
                Station[] stations = System.Text.Json.JsonSerializer.Deserialize<Station[]>(answer);
                utils.displayStations(stations);
            }

            if (args.Length == 2)
            {
                answer = request.getStation(client, args[0], args[1]);
                Station station = System.Text.Json.JsonSerializer.Deserialize<Station>(answer);
                utils.displayStation(station);
            }

            if (args[0] == "-gps")
            {

            }
        }
    }
}